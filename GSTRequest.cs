using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GstSearchWinformApp
{
	public class GSTRequest
	{
		public string captcha { get; set; }
		public string gstin { get; set; }

		public GSTRequest()
		{
			captcha = string.Empty;
			gstin = string.Empty;
		}
	}
}
