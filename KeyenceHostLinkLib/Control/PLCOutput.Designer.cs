// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Linq;
// End of VB project level imports

using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class PLCOutput : System.Windows.Forms.UserControl
	{
		
		//UserControl overrides dispose to clean up the component list.
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
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.Color.Red;
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (20.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button1.Location = new System.Drawing.Point(3, 3);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(79, 62);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "OFF";
			this.Button1.UseVisualStyleBackColor = false;
			//
			//PLCOutput
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Button1);
			this.Name = "PLCOutput";
			this.Size = new System.Drawing.Size(86, 68);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Button Button1;
		
	}
	
}
