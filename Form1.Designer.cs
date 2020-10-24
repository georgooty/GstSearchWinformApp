namespace GstSearchWinformApp
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.gstSeatchtextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.captchaTextBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.generateBtn = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter GST number:";
			// 
			// gstSeatchtextBox
			// 
			this.gstSeatchtextBox.Location = new System.Drawing.Point(135, 21);
			this.gstSeatchtextBox.Name = "gstSeatchtextBox";
			this.gstSeatchtextBox.Size = new System.Drawing.Size(221, 20);
			this.gstSeatchtextBox.TabIndex = 1;
			this.gstSeatchtextBox.Click += new System.EventHandler(this.gstSeatchtextBox_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(43, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enter captcha:";
			// 
			// captchaTextBox
			// 
			this.captchaTextBox.Location = new System.Drawing.Point(135, 155);
			this.captchaTextBox.Name = "captchaTextBox";
			this.captchaTextBox.Size = new System.Drawing.Size(221, 20);
			this.captchaTextBox.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(135, 62);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(132, 67);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// generateBtn
			// 
			this.generateBtn.Location = new System.Drawing.Point(281, 62);
			this.generateBtn.Name = "generateBtn";
			this.generateBtn.Size = new System.Drawing.Size(119, 23);
			this.generateBtn.TabIndex = 5;
			this.generateBtn.Text = "Generate captcha";
			this.generateBtn.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(46, 241);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(434, 79);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(43, 225);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Result";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(332, 200);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(148, 35);
			this.searchButton.TabIndex = 8;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 330);
			this.Controls.Add(this.searchButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.generateBtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.captchaTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gstSeatchtextBox);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox gstSeatchtextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox captchaTextBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button generateBtn;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button searchButton;
	}
}

