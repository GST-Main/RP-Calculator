﻿namespace RP_Calculator
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.radio_4900 = new System.Windows.Forms.RadioButton();
			this.radio_9900 = new System.Windows.Forms.RadioButton();
			this.radio_19900 = new System.Windows.Forms.RadioButton();
			this.radio_35000 = new System.Windows.Forms.RadioButton();
			this.radio_49900 = new System.Windows.Forms.RadioButton();
			this.radio_99000 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox_InputRP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_perRP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_Result = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// radio_4900
			// 
			this.radio_4900.AutoSize = true;
			this.radio_4900.Location = new System.Drawing.Point(6, 17);
			this.radio_4900.Name = "radio_4900";
			this.radio_4900.Size = new System.Drawing.Size(111, 19);
			this.radio_4900.TabIndex = 0;
			this.radio_4900.TabStop = true;
			this.radio_4900.Text = "4,900원(565RP)";
			this.radio_4900.UseVisualStyleBackColor = true;
			this.radio_4900.CheckedChanged += new System.EventHandler(this.radio_4900_CheckedChanged);
			// 
			// radio_9900
			// 
			this.radio_9900.AutoSize = true;
			this.radio_9900.Location = new System.Drawing.Point(6, 42);
			this.radio_9900.Name = "radio_9900";
			this.radio_9900.Size = new System.Drawing.Size(121, 19);
			this.radio_9900.TabIndex = 1;
			this.radio_9900.TabStop = true;
			this.radio_9900.Text = "9,900원(1.200RP)";
			this.radio_9900.UseVisualStyleBackColor = true;
			this.radio_9900.CheckedChanged += new System.EventHandler(this.radio_9900_CheckedChanged);
			// 
			// radio_19900
			// 
			this.radio_19900.AutoSize = true;
			this.radio_19900.Location = new System.Drawing.Point(6, 67);
			this.radio_19900.Name = "radio_19900";
			this.radio_19900.Size = new System.Drawing.Size(128, 19);
			this.radio_19900.TabIndex = 2;
			this.radio_19900.TabStop = true;
			this.radio_19900.Text = "19,900원(2,450RP)";
			this.radio_19900.UseVisualStyleBackColor = true;
			this.radio_19900.CheckedChanged += new System.EventHandler(this.radio_19900_CheckedChanged);
			// 
			// radio_35000
			// 
			this.radio_35000.AutoSize = true;
			this.radio_35000.Location = new System.Drawing.Point(6, 92);
			this.radio_35000.Name = "radio_35000";
			this.radio_35000.Size = new System.Drawing.Size(128, 19);
			this.radio_35000.TabIndex = 3;
			this.radio_35000.TabStop = true;
			this.radio_35000.Text = "35,000원(4,350RP)";
			this.radio_35000.UseVisualStyleBackColor = true;
			this.radio_35000.CheckedChanged += new System.EventHandler(this.radio_35000_CheckedChanged);
			// 
			// radio_49900
			// 
			this.radio_49900.AutoSize = true;
			this.radio_49900.Location = new System.Drawing.Point(6, 117);
			this.radio_49900.Name = "radio_49900";
			this.radio_49900.Size = new System.Drawing.Size(128, 19);
			this.radio_49900.TabIndex = 4;
			this.radio_49900.TabStop = true;
			this.radio_49900.Text = "49,900원(6,275RP)";
			this.radio_49900.UseVisualStyleBackColor = true;
			this.radio_49900.CheckedChanged += new System.EventHandler(this.radio_49900_CheckedChanged);
			// 
			// radio_99000
			// 
			this.radio_99000.AutoSize = true;
			this.radio_99000.Location = new System.Drawing.Point(6, 142);
			this.radio_99000.Name = "radio_99000";
			this.radio_99000.Size = new System.Drawing.Size(135, 19);
			this.radio_99000.TabIndex = 5;
			this.radio_99000.TabStop = true;
			this.radio_99000.Text = "99,000원(13,000RP)";
			this.radio_99000.UseVisualStyleBackColor = true;
			this.radio_99000.CheckedChanged += new System.EventHandler(this.radio_99000_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radio_9900);
			this.groupBox1.Controls.Add(this.radio_99000);
			this.groupBox1.Controls.Add(this.radio_4900);
			this.groupBox1.Controls.Add(this.radio_49900);
			this.groupBox1.Controls.Add(this.radio_19900);
			this.groupBox1.Controls.Add(this.radio_35000);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 168);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "충전 금액";
			// 
			// textBox_InputRP
			// 
			this.textBox_InputRP.Location = new System.Drawing.Point(231, 12);
			this.textBox_InputRP.Name = "textBox_InputRP";
			this.textBox_InputRP.Size = new System.Drawing.Size(86, 23);
			this.textBox_InputRP.TabIndex = 7;
			this.textBox_InputRP.TextChanged += new System.EventHandler(this.textBox_InputRP_TextChanged);
			this.textBox_InputRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_InputRP_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(323, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "RP";
			// 
			// textBox_perRP
			// 
			this.textBox_perRP.Location = new System.Drawing.Point(50, 186);
			this.textBox_perRP.Name = "textBox_perRP";
			this.textBox_perRP.ReadOnly = true;
			this.textBox_perRP.Size = new System.Drawing.Size(100, 23);
			this.textBox_perRP.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "RP 당";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(156, 189);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = "원";
			// 
			// textBox_Result
			// 
			this.textBox_Result.Location = new System.Drawing.Point(231, 41);
			this.textBox_Result.Name = "textBox_Result";
			this.textBox_Result.ReadOnly = true;
			this.textBox_Result.Size = new System.Drawing.Size(86, 23);
			this.textBox_Result.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(323, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "원";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 221);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox_Result);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_perRP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_InputRP);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "RP Calculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RadioButton radio_4900;
		private RadioButton radio_9900;
		private RadioButton radio_19900;
		private RadioButton radio_35000;
		private RadioButton radio_49900;
		private RadioButton radio_99000;
		private GroupBox groupBox1;
		private TextBox textBox_InputRP;
		private Label label1;
		private TextBox textBox_perRP;
		private Label label2;
		private Label label3;
		private TextBox textBox_Result;
		private Label label4;
	}
}