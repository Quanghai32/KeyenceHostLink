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
	partial class PLCEditBox : PLCBaseControl
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
			this.butWrite = new System.Windows.Forms.Button();
			this.butWrite.Click += new System.EventHandler(this.butWrite_Click);
			this.txtValue = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			//butWrite
			//
			this.butWrite.Dock = System.Windows.Forms.DockStyle.Right;
			this.butWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (20.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.butWrite.Location = new System.Drawing.Point(183, 0);
			this.butWrite.Name = "butWrite";
			this.butWrite.Size = new System.Drawing.Size(47, 49);
			this.butWrite.TabIndex = 1;
			this.butWrite.Text = "W";
			this.butWrite.UseVisualStyleBackColor = true;
			//
			//txtValue
			//
			this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (20.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtValue.Location = new System.Drawing.Point(0, 0);
			this.txtValue.Multiline = true;
			this.txtValue.Name = "txtValue";
			this.txtValue.ReadOnly = true;
			this.txtValue.Size = new System.Drawing.Size(183, 49);
			this.txtValue.TabIndex = 2;
			//
			//PLCEditBox
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.butWrite);
			this.Name = "PLCEditBox";
			this.Size = new System.Drawing.Size(230, 49);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Button butWrite;
		internal System.Windows.Forms.TextBox txtValue;
		
	}
	
}
