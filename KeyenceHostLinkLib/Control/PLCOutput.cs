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
using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	public partial class PLCOutput : general.IPLCControl
	{
		public PLCOutput()
		{
			InitializeComponent();
		}
		
		private IPAddress _IP;
		private int _port;
		private string preValue = "";
		private general.PLCLink link;
#region Properties
		private int _PLCAdress;
		[Category("PLC connection")]
			public int PLCAddress
			{
			get
			{
				return _PLCAdress;
			}
			set
			{
				_PLCAdress = value;
				if (ReferenceEquals(link, null))
				{
					link = new general.PLCLink();
				}
				link.add.MemAdd = _PLCAdress;
			}
		}
		private HostlinkKeyence _PLCLink;
		[Category("PLC connection")]
			public HostlinkKeyence PLCLink
			{
			get
			{
				return _PLCLink;
			}
			set
			{
				if (IPAddress.TryParse(value.IP, out _IP))
				{
					_port = value.port;
				}
				_PLCLink = value;
				if (ReferenceEquals(link, null))
				{
					link = new general.PLCLink();
				}
				link.usingmethod = this;
				link.enable = true;
				CalcRequestCommand();
				_PLCLink.AddLink(link);
			}
		}
		private string _MemType;
		[Category("PLC connection"), Editor(typeof(CustomListPropertiesEditor), typeof(UITypeEditor))]
			public string MemoryType
			{
			get
			{
				return _MemType;
			}
			set
			{
				_MemType = value;
				if (ReferenceEquals(link, null))
				{
					link = new general.PLCLink();
				}
				link.add.MemType = _MemType;
			}
		}
		
#endregion
		
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
						CalcRequestCommand();
					}
					else
					{
						bool txt;
						txt = Convert.ToBoolean(Convert.ToInt16(result));
						if (txt == true)
						{
							Button1.BackColor = System.Drawing.Color.Green;
							Button1.Text = "ON";
						}
						else
						{
							Button1.BackColor = System.Drawing.Color.Red;
							Button1.Text = "OFF";
						}
						preValue = result;
					}
				}
			}
		}
		
		public void CalcRequestCommand(bool write = false, int value = 0)
		{
			if (ReferenceEquals(link, null))
			{
				link = new general.PLCLink();
			}
			if (write)
			{
				if (value == 0)
				{
					link.cmd = "RS " + link.add.MemType + System.Convert.ToString(link.add.MemAdd);
				}
				else
				{
					link.cmd = "ST " + link.add.MemType + System.Convert.ToString(link.add.MemAdd);
				}
			}
			else
			{
				link.cmd = "RD " + link.add.MemType + System.Convert.ToString(link.add.MemAdd) + link.add.format;
			}
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			if (Button1.Text == "ON")
			{
				CalcRequestCommand(true, 0);
			}
			else
			{
				CalcRequestCommand(true, 1);
			}
		}
	}
	
}
