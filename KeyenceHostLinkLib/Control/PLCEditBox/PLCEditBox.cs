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

using System.ComponentModel;
using System.Net;
using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	[Serializable(), Designer(typeof(PLCEditBox_Designer))]
		public partial class PLCEditBox : general.IPLCControl
		{
			public PLCEditBox()
			{
				InitializeComponent();
			}
		private delegate void SetUsedCallback(string value);
		public void useResult(string result)
		{
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
					if (string.Compare(result, "OK") == 0)
					{
						CalcCommand();
					}
					else
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
		
		public void butWrite_Click(object sender, EventArgs e)
		{
			if (butWrite.Text == "W")
			{
				link.enable = false;
				txtValue.ReadOnly = false;
				butWrite.Text = "S";
			}
			else
			{
				butWrite.Text = "W";
				link.enable = true;
				txtValue.ReadOnly = true;
				preValue = "";
				CalcCommand(true, txtValue.Text.Replace("\r\n", ""));
			}
		}
	}
	
}
