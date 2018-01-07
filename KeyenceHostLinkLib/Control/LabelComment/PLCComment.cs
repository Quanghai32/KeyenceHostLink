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
using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	[Serializable(), Designer(typeof(PLCBaseControl_Designer<PLCComment_ActionList>))]
		public partial class PLCComment : general.IPLCControl
		{
			public PLCComment()
			{
				InitializeComponent();
			}
		
#region Properties
		[Browsable(false)]
			private new string DataFormat {get; set;}
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
					if (result.CompareTo("E6") == 0)
					{
						Label1.Text = "No comment";
					}
					else
					{
						Label1.Text = result;
					}
					preValue = result;
				}
			}
		}
		public override void CalcCommand(bool Write = false, string value = "")
		{
			//MyBase.CalcCommand(Write, value)
			if (ReferenceEquals(link, null))
			{
				return ;
			}
			link.add.MemType = MemoryType;
			link.add.MemAdd = PLCAddress;
			link.cmd = "RDC " + link.add.MemType + link.add.MemAdd.ToString();
		}
	}
	
}
