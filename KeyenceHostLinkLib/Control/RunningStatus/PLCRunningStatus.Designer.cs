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
	partial class PLCRunningStatus : PLCBaseControl
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
			this.butRun = new System.Windows.Forms.Button();
			this.butRun.Click += new System.EventHandler(this.butRun_Click);
			this.SuspendLayout();
			//
			//butRun
			//
			this.butRun.Dock = System.Windows.Forms.DockStyle.Fill;
			this.butRun.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (20.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.butRun.Location = new System.Drawing.Point(0, 0);
			this.butRun.Name = "butRun";
			this.butRun.Size = new System.Drawing.Size(150, 49);
			this.butRun.TabIndex = 0;
			this.butRun.Text = "Button1";
			this.butRun.UseVisualStyleBackColor = true;
			//
			//PLCRunningStatus
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.butRun);
			this.Name = "PLCRunningStatus";
			this.Size = new System.Drawing.Size(150, 49);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.Button butRun;
		
	}
	
}
