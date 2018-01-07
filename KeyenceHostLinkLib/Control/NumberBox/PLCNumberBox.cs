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

using System.Net;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;
using System.Windows.Forms;
using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	
	[Serializable(), Designer(typeof(PLCNumberBox_Designer))]
		public partial class PLCNumberBox : general.IPLCControl
		{
			public PLCNumberBox()
			{
				InitializeComponent();
			}
		
#region Properties
		[Category("Appearance")]
			public Color InputColor
			{
			get
			{
				return txtValue.BackColor;
			}
			set
			{
				txtValue.BackColor = value;
			}
		}
		[Category("Appearance")]
			public HorizontalAlignment TextAlign
			{
			get
			{
				return txtValue.TextAlign;
			}
			set
			{
				txtValue.TextAlign = value;
			}
		}
		
#endregion
		
		private delegate void SetUsedCallback(string value);
		public void useResult(string result)
		{
			if (link.enable == false)
			{
				return ;
			}
			if (this.InvokeRequired)
			{
				SetUsedCallback d = new SetUsedCallback(useResult);
				this.Invoke(d, new object[] {result});
			}
			else
			{
				result = result.Replace("\r\n", "");
				if (preValue != result)
				{
					string txt = "";
					switch (DataFormat)
					{
						case ".U":
							txt = System.Convert.ToString(Convert.ToUInt16(result));
							break;
						case ".S":
							txt = System.Convert.ToString(Convert.ToInt16(result));
							break;
						case ".D":
							txt = System.Convert.ToString(Convert.ToUInt32(result));
							break;
						case ".L":
							txt = System.Convert.ToString(Convert.ToInt32(result));
							break;
						case ".H":
							txt = result;
							break;
						default:
							txt = System.Convert.ToString(Convert.ToUInt16(result));
							break;
					}
					txtValue.Text = txt;
					preValue = result;
				}
			}
		}
	}
	
}
