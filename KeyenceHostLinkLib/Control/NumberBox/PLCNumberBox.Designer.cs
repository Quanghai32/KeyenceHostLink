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
	partial class PLCNumberBox : PLCBaseControl
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
			this.txtValue = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			//txtValue
			//
			this.txtValue.Anchor = (System.Windows.Forms.AnchorStyles) ((((int) (System.Windows.Forms.AnchorStyles.Top) | (int) System.Windows.Forms.AnchorStyles.Bottom) 
				| (int) System.Windows.Forms.AnchorStyles.Left) 
				| (int) System.Windows.Forms.AnchorStyles.Right);
			this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", (float) (20.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtValue.Location = new System.Drawing.Point(4, 4);
			this.txtValue.Multiline = true;
			this.txtValue.Name = "txtValue";
			this.txtValue.ReadOnly = true;
			this.txtValue.Size = new System.Drawing.Size(171, 42);
			this.txtValue.TabIndex = 0;
			this.txtValue.Text = "12345678";
			//
			//PLCNumberBox
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtValue);
			this.Name = "PLCNumberBox";
			this.Size = new System.Drawing.Size(178, 50);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.TextBox txtValue;
		
	}
	
}
