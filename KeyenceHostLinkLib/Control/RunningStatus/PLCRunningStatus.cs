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
using System.Drawing;
using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	//<Serializable(), Designer(GetType(PLCRunningStatus_Designer))>
	[Serializable(), Designer(typeof(PLCBaseControl_Designer<PLCRunningStatus_ActionLists>))]
		public partial class PLCRunningStatus : general.IPLCControl
		{
			public PLCRunningStatus()
			{
				InitializeComponent();
			}
		
		private bool _isRunning;
#region Properties
		[Browsable(false)]
			new public string MemoryType {get; set;}
		[Browsable(false)]
			new public int PLCAddress {get; set;}
		private Color _RunColor = Color.Green;
		public Color RunColor
		{
			get
			{
				return _RunColor;
			}
			set
			{
				_RunColor = value;
				updateDisplay();
			}
		}
		private Color _StopColor = Color.Red;
		public Color StopColor
		{
			get
			{
				return _StopColor;
			}
			set
			{
				_StopColor = value;
				updateDisplay();
			}
		}
		private string _RunText = "Running";
		public string RunText
		{
			get
			{
				return _RunText;
			}
			set
			{
				_RunText = value;
				updateDisplay();
			}
		}
		private string _StopText = "Stop";
		public string StopText
		{
			get
			{
				return _StopText;
			}
			set
			{
				_StopText = value;
				updateDisplay();
			}
			
		}
		public override Font Font
		{
			get
			{
				if (ReferenceEquals(butRun, null))
				{
					return null;
				}
				return butRun.Font;
			}
			set
			{
				if (ReferenceEquals(butRun, null))
				{
					return ;
				}
				butRun.Font = value;
			}
		}
		private bool _DisplayOnly;
		public bool DisplayOnly
		{
			get
			{
				return _DisplayOnly;
			}
			set
			{
				_DisplayOnly = value;
				butRun.Enabled = !_DisplayOnly;
			}
		}
		
		
#endregion
		
#region Impliment and inherit function
		private delegate void useResultCallback(string value);
		public void useResult(string result)
		{
			if (this.InvokeRequired)
			{
				useResultCallback d = new useResultCallback(useResult);
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
						bool txt;
						txt = Convert.ToBoolean(Convert.ToInt16(result));
						if (txt == true)
						{
							_isRunning = true;
							butRun.BackColor = _RunColor;
							butRun.Text = _RunText;
						}
						else
						{
							_isRunning = false;
							butRun.BackColor = _StopColor;
							butRun.Text = _StopText;
						}
						preValue = result;
					}
				}
			}
		}
		
		public override void CalcCommand(bool Write = false, string value = "")
		{
			if (ReferenceEquals(link, null))
			{
				link = new general.PLCLink();
			}
			if (Write)
			{
				link.cmd = "M" + value;
			}
			else
			{
				link.cmd = "?M";
			}
		}
		
#endregion
		
#region Other function
		private void updateDisplay()
		{
			if (ReferenceEquals(butRun, null))
			{
				return ;
			}
			if (_isRunning)
			{
				butRun.BackColor = _RunColor;
				butRun.Text = _RunText;
			}
			else
			{
				butRun.BackColor = _StopColor;
				butRun.Text = _StopText;
			}
		}
		
		public void butRun_Click(object sender, EventArgs e)
		{
			if (_DisplayOnly)
			{
				return ;
			}
			if (butRun.Text == RunText)
			{
				CalcCommand(true, "0");
			}
			else
			{
				CalcCommand(true, "1");
			}
		}
#endregion
		
	}
	
}
