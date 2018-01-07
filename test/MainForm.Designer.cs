// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports

using test;

namespace test
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class MainForm : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Label3 = new System.Windows.Forms.Label();
            this.PlcNumberBox2 = new KeyenceHostLinkLib.PLCNumberBox();
            this.PlcComment2 = new KeyenceHostLinkLib.PLCComment();
            this.PlcNumberBox1 = new KeyenceHostLinkLib.PLCNumberBox();
            this.PlcComment1 = new KeyenceHostLinkLib.PLCComment();
            this.PlcButtonChange1 = new KeyenceHostLinkLib.PLCButtonChange();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Label2 = new System.Windows.Forms.Label();
            this.PlcButtonChange3 = new KeyenceHostLinkLib.PLCButtonChange();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Label1 = new System.Windows.Forms.Label();
            this.PlcRunningStatus1 = new KeyenceHostLinkLib.PLCRunningStatus();
            this.PlcButtonChange4 = new KeyenceHostLinkLib.PLCButtonChange();
            this.PlcEditBox3 = new KeyenceHostLinkLib.PLCEditBox();
            this.PlcEditBox2 = new KeyenceHostLinkLib.PLCEditBox();
            this.PlcEditBox1 = new KeyenceHostLinkLib.PLCEditBox();
            this.PlcComment5 = new KeyenceHostLinkLib.PLCComment();
            this.PlcComment6 = new KeyenceHostLinkLib.PLCComment();
            this.PlcButtonChange2 = new KeyenceHostLinkLib.PLCButtonChange();
            this.PlcNumberBox3 = new KeyenceHostLinkLib.PLCNumberBox();
            this.PlcComment3 = new KeyenceHostLinkLib.PLCComment();
            this.PlcNumberBox4 = new KeyenceHostLinkLib.PLCNumberBox();
            this.PlcComment4 = new KeyenceHostLinkLib.PLCComment();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(284, 242);
            this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.PlcNumberBox2);
            this.TabPage1.Controls.Add(this.PlcComment2);
            this.TabPage1.Controls.Add(this.PlcNumberBox1);
            this.TabPage1.Controls.Add(this.PlcComment1);
            this.TabPage1.Controls.Add(this.PlcButtonChange1);
            this.TabPage1.Location = new System.Drawing.Point(4, 25);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(276, 213);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "TabPage1";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(44, 3);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(188, 31);
            this.Label3.TabIndex = 9;
            this.Label3.Text = "Value in DEC";
            // 
            // PlcNumberBox2
            // 
            this.PlcNumberBox2.InputColor = System.Drawing.SystemColors.Control;
            this.PlcNumberBox2.Location = new System.Drawing.Point(148, 97);
            this.PlcNumberBox2.Name = "PlcNumberBox2";
            this.PlcNumberBox2.PLCAddress = 101;
            this.PlcNumberBox2.Size = new System.Drawing.Size(118, 50);
            this.PlcNumberBox2.TabIndex = 2;
            this.PlcNumberBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PlcComment2
            // 
            this.PlcComment2.Location = new System.Drawing.Point(8, 103);
            this.PlcComment2.Name = "PlcComment2";
            this.PlcComment2.PLCAddress = 101;
            this.PlcComment2.Size = new System.Drawing.Size(134, 39);
            this.PlcComment2.TabIndex = 1;
            // 
            // PlcNumberBox1
            // 
            this.PlcNumberBox1.InputColor = System.Drawing.SystemColors.Control;
            this.PlcNumberBox1.Location = new System.Drawing.Point(148, 41);
            this.PlcNumberBox1.Name = "PlcNumberBox1";
            this.PlcNumberBox1.Size = new System.Drawing.Size(118, 50);
            this.PlcNumberBox1.TabIndex = 2;
            this.PlcNumberBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PlcComment1
            // 
            this.PlcComment1.Location = new System.Drawing.Point(8, 47);
            this.PlcComment1.Name = "PlcComment1";
            this.PlcComment1.Size = new System.Drawing.Size(134, 39);
            this.PlcComment1.TabIndex = 1;
            // 
            // PlcButtonChange1
            // 
            this.PlcButtonChange1.AutoSize = true;
            this.PlcButtonChange1.BackColor = System.Drawing.Color.Lime;
            this.PlcButtonChange1.ButtonText = "NEXT";
            this.PlcButtonChange1.ButtonType = System.Windows.Forms.FlatStyle.Flat;
            this.PlcButtonChange1.Location = new System.Drawing.Point(145, 174);
            this.PlcButtonChange1.MainPage = this.TabControl1;
            this.PlcButtonChange1.Name = "PlcButtonChange1";
            this.PlcButtonChange1.NextPage = this.TabPage2;
            this.PlcButtonChange1.Size = new System.Drawing.Size(123, 53);
            this.PlcButtonChange1.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Label2);
            this.TabPage2.Controls.Add(this.PlcButtonChange3);
            this.TabPage2.Controls.Add(this.PlcButtonChange2);
            this.TabPage2.Controls.Add(this.PlcNumberBox3);
            this.TabPage2.Controls.Add(this.PlcComment3);
            this.TabPage2.Controls.Add(this.PlcNumberBox4);
            this.TabPage2.Controls.Add(this.PlcComment4);
            this.TabPage2.Location = new System.Drawing.Point(4, 25);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(276, 213);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "TabPage2";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(49, 3);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(178, 31);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Value in Hex";
            // 
            // PlcButtonChange3
            // 
            this.PlcButtonChange3.AutoSize = true;
            this.PlcButtonChange3.BackColor = System.Drawing.Color.Lime;
            this.PlcButtonChange3.ButtonText = "NEXT";
            this.PlcButtonChange3.ButtonType = System.Windows.Forms.FlatStyle.Flat;
            this.PlcButtonChange3.Location = new System.Drawing.Point(147, 174);
            this.PlcButtonChange3.MainPage = this.TabControl1;
            this.PlcButtonChange3.Name = "PlcButtonChange3";
            this.PlcButtonChange3.NextPage = this.TabPage3;
            this.PlcButtonChange3.Size = new System.Drawing.Size(123, 53);
            this.PlcButtonChange3.TabIndex = 7;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.Label1);
            this.TabPage3.Controls.Add(this.PlcRunningStatus1);
            this.TabPage3.Controls.Add(this.PlcButtonChange4);
            this.TabPage3.Controls.Add(this.PlcEditBox3);
            this.TabPage3.Controls.Add(this.PlcEditBox2);
            this.TabPage3.Controls.Add(this.PlcEditBox1);
            this.TabPage3.Controls.Add(this.PlcComment5);
            this.TabPage3.Controls.Add(this.PlcComment6);
            this.TabPage3.Location = new System.Drawing.Point(4, 25);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(276, 213);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "TabPage3";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(70, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(136, 31);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "Set value";
            // 
            // PlcRunningStatus1
            // 
            this.PlcRunningStatus1.BackColor = System.Drawing.Color.Green;
            this.PlcRunningStatus1.DisplayOnly = false;
            this.PlcRunningStatus1.Location = new System.Drawing.Point(0, 0);
            this.PlcRunningStatus1.MemoryType = null;
            this.PlcRunningStatus1.Name = "PlcRunningStatus1";
            this.PlcRunningStatus1.PLCAddress = 0;
            this.PlcRunningStatus1.RunColor = System.Drawing.Color.Green;
            this.PlcRunningStatus1.RunText = "R";
            this.PlcRunningStatus1.Size = new System.Drawing.Size(49, 49);
            this.PlcRunningStatus1.StopColor = System.Drawing.Color.Red;
            this.PlcRunningStatus1.StopText = "S";
            this.PlcRunningStatus1.TabIndex = 7;
            // 
            // PlcButtonChange4
            // 
            this.PlcButtonChange4.AutoSize = true;
            this.PlcButtonChange4.BackColor = System.Drawing.Color.Lime;
            this.PlcButtonChange4.ButtonText = "BACK";
            this.PlcButtonChange4.ButtonType = System.Windows.Forms.FlatStyle.Flat;
            this.PlcButtonChange4.Location = new System.Drawing.Point(6, 174);
            this.PlcButtonChange4.MainPage = this.TabControl1;
            this.PlcButtonChange4.Name = "PlcButtonChange4";
            this.PlcButtonChange4.NextPage = this.TabPage2;
            this.PlcButtonChange4.Size = new System.Drawing.Size(123, 53);
            this.PlcButtonChange4.TabIndex = 6;
            // 
            // PlcEditBox3
            // 
            this.PlcEditBox3.Location = new System.Drawing.Point(156, 161);
            this.PlcEditBox3.MemoryType = "R";
            this.PlcEditBox3.Name = "PlcEditBox3";
            this.PlcEditBox3.PLCAddress = 500;
            this.PlcEditBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlcEditBox3.Size = new System.Drawing.Size(89, 36);
            this.PlcEditBox3.TabIndex = 5;
            // 
            // PlcEditBox2
            // 
            this.PlcEditBox2.Location = new System.Drawing.Point(116, 109);
            this.PlcEditBox2.Name = "PlcEditBox2";
            this.PlcEditBox2.PLCAddress = 101;
            this.PlcEditBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PlcEditBox2.Size = new System.Drawing.Size(152, 49);
            this.PlcEditBox2.TabIndex = 5;
            // 
            // PlcEditBox1
            // 
            this.PlcEditBox1.Location = new System.Drawing.Point(116, 53);
            this.PlcEditBox1.Name = "PlcEditBox1";
            this.PlcEditBox1.Size = new System.Drawing.Size(152, 49);
            this.PlcEditBox1.TabIndex = 5;
            // 
            // PlcComment5
            // 
            this.PlcComment5.Location = new System.Drawing.Point(10, 114);
            this.PlcComment5.Name = "PlcComment5";
            this.PlcComment5.PLCAddress = 101;
            this.PlcComment5.Size = new System.Drawing.Size(100, 39);
            this.PlcComment5.TabIndex = 3;
            // 
            // PlcComment6
            // 
            this.PlcComment6.Location = new System.Drawing.Point(10, 58);
            this.PlcComment6.Name = "PlcComment6";
            this.PlcComment6.Size = new System.Drawing.Size(100, 39);
            this.PlcComment6.TabIndex = 4;
            // 
            // PlcButtonChange2
            // 
            this.PlcButtonChange2.AutoSize = true;
            this.PlcButtonChange2.BackColor = System.Drawing.Color.Lime;
            this.PlcButtonChange2.ButtonText = "BACK";
            this.PlcButtonChange2.ButtonType = System.Windows.Forms.FlatStyle.Flat;
            this.PlcButtonChange2.Location = new System.Drawing.Point(6, 174);
            this.PlcButtonChange2.MainPage = this.TabControl1;
            this.PlcButtonChange2.Name = "PlcButtonChange2";
            this.PlcButtonChange2.NextPage = this.TabPage1;
            this.PlcButtonChange2.Size = new System.Drawing.Size(123, 53);
            this.PlcButtonChange2.TabIndex = 7;
            // 
            // PlcNumberBox3
            // 
            this.PlcNumberBox3.DataFormat = ".H";
            this.PlcNumberBox3.InputColor = System.Drawing.SystemColors.Control;
            this.PlcNumberBox3.Location = new System.Drawing.Point(148, 99);
            this.PlcNumberBox3.Name = "PlcNumberBox3";
            this.PlcNumberBox3.PLCAddress = 101;
            this.PlcNumberBox3.Size = new System.Drawing.Size(118, 50);
            this.PlcNumberBox3.TabIndex = 5;
            this.PlcNumberBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PlcComment3
            // 
            this.PlcComment3.Location = new System.Drawing.Point(8, 105);
            this.PlcComment3.Name = "PlcComment3";
            this.PlcComment3.PLCAddress = 101;
            this.PlcComment3.Size = new System.Drawing.Size(134, 39);
            this.PlcComment3.TabIndex = 3;
            // 
            // PlcNumberBox4
            // 
            this.PlcNumberBox4.DataFormat = ".H";
            this.PlcNumberBox4.InputColor = System.Drawing.SystemColors.Control;
            this.PlcNumberBox4.Location = new System.Drawing.Point(148, 43);
            this.PlcNumberBox4.Name = "PlcNumberBox4";
            this.PlcNumberBox4.Size = new System.Drawing.Size(118, 50);
            this.PlcNumberBox4.TabIndex = 6;
            this.PlcNumberBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PlcComment4
            // 
            this.PlcComment4.Location = new System.Drawing.Point(8, 49);
            this.PlcComment4.Name = "PlcComment4";
            this.PlcComment4.Size = new System.Drawing.Size(134, 39);
            this.PlcComment4.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.TabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read PLC memory";
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.ResumeLayout(false);

		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabPage TabPage3;
		internal KeyenceHostLinkLib.PLCButtonChange PlcButtonChange1;
		internal KeyenceHostLinkLib.PLCNumberBox PlcNumberBox1;
		internal KeyenceHostLinkLib.PLCComment PlcComment1;
		internal KeyenceHostLinkLib.PLCNumberBox PlcNumberBox2;
		internal KeyenceHostLinkLib.PLCComment PlcComment2;
		internal KeyenceHostLinkLib.PLCButtonChange PlcButtonChange3;
		internal KeyenceHostLinkLib.PLCRunningStatus PlcRunningStatus1;
		internal KeyenceHostLinkLib.PLCButtonChange PlcButtonChange4;
		internal KeyenceHostLinkLib.PLCEditBox PlcEditBox2;
		internal KeyenceHostLinkLib.PLCEditBox PlcEditBox1;
		internal KeyenceHostLinkLib.PLCComment PlcComment5;
		internal KeyenceHostLinkLib.PLCComment PlcComment6;
		internal KeyenceHostLinkLib.PLCButtonChange PlcButtonChange2;
		internal KeyenceHostLinkLib.PLCNumberBox PlcNumberBox3;
		internal KeyenceHostLinkLib.PLCComment PlcComment3;
		internal KeyenceHostLinkLib.PLCNumberBox PlcNumberBox4;
		internal KeyenceHostLinkLib.PLCComment PlcComment4;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal KeyenceHostLinkLib.PLCEditBox PlcEditBox3;
        private System.ComponentModel.IContainer components;
    }
	
}
