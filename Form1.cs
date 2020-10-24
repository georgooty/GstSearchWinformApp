using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GstSearchWinformApp
{
	public partial class Form1 : Form
	{
		private const string baseAddress = "https://services.gst.gov.in/services/";
		private delegate void SafeCallDelegate(string text);

		static HttpClient client = new HttpClient();
		public Form1()
		{
			InitializeComponent();

			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

			client.BaseAddress = new Uri(baseAddress);
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));
		}

		private async Task GetGSTDetails()
		{
			try
			{
				//https://services.gst.gov.in/services/api/search/taxpayerDetails
				//{gstin: "32AABCA9317J1ZT", captcha: "307880"}
				GSTRequest gstReq = new GSTRequest();
				gstReq.captcha = captchaTextBox.Text.Trim();
				gstReq.gstin = gstSeatchtextBox.Text.Trim();
				string jsonData = JsonConvert.SerializeObject(gstReq);
				var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
				string uri = "api/search/taxpayerDetails";
				HttpResponseMessage mess = await client.PostAsync(uri, content);
				if (mess.IsSuccessStatusCode)
				{
					string result = await mess.Content.ReadAsStringAsync();
					SetGstDetails(result);
					
				}
			}
			catch(Exception ex)
			{

			}
		}

		private void SetGstDetails(string result)
		{
			if (!string.IsNullOrEmpty(result))
			{
				if (richTextBox1.InvokeRequired)
				{
					var d = new SafeCallDelegate(SetGstDetails);
					richTextBox1.Invoke(d, new object[] { result });
				}
				else
				{
					richTextBox1.Text = result;
				}



			}
		}
		private async Task<System.IO.Stream> GetCaptchaAsyc()
		{
			System.IO.Stream dataBuffer = null;
			try
			{

				Random r = new Random();
				double genRand = r.NextDouble();
				string uri = string.Format("captcha?rnd={0}", genRand);
				HttpResponseMessage mess = await client.GetAsync(uri);
				if (mess.IsSuccessStatusCode)
				{
					dataBuffer = await mess.Content.ReadAsStreamAsync();
					if (dataBuffer != null)
					{
						pictureBox1.Image = new Bitmap(dataBuffer);

					}
				}
			}
			catch (Exception ex)
			{

			}

			return dataBuffer;
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			Task.Run(() => GetGSTDetails());
		}

		private void gstSeatchtextBox_Click(object sender, EventArgs e)
		{
			Task.Run(() => GetCaptchaAsyc());
		}
	}
}
