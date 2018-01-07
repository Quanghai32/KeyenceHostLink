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

using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	
	[Serializable(), Designer(typeof(PLCBaseControl_Designer<PLCButtonChange_ActionLists>))]
		public partial class PLCButtonChange
		{
			public PLCButtonChange()
			{
				InitializeComponent();
			}
		
#region Properties
		private TabControl _MainPage;
		public TabControl MainPage
		{
			get
			{
				return _MainPage;
			}
			set
			{
				_MainPage = value;
			}
		}
		private TabPage _NextPage;
		public TabPage NextPage
		{
			get
			{
				return _NextPage;
			}
			set
			{
				_NextPage = value;
			}
		}
		public string ButtonText
		{
			get
			{
				return Button1.Text;
			}
			set
			{
				Button1.Text = value;
			}
		}
		public FlatStyle ButtonType
		{
			get
			{
				return Button1.FlatStyle;
			}
			set
			{
				Button1.FlatStyle = value;
			}
		}
		
#endregion
		public void PLCButtonChange_FontChanged(object sender, EventArgs e)
		{
			Button1.Font = Font;
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			if (!ReferenceEquals(MainPage, null))
			{
				if (!ReferenceEquals(NextPage, null))
				{
					MainPage.SelectedTab = NextPage;
				}
			}
		}
		
		
		public void PLCButtonChange_Load(object sender, EventArgs e)
		{
			if (!ReferenceEquals(MainPage, null) && !DesignMode)
			{
				MainPage.ItemSize = new Size(0, 1);
				//MainPage.SizeMode = TabSizeMode.Fixed
				//MainPage.Appearance = TabAppearance.FlatButtons
			}
		}
	}
	
}
