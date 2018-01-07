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

using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Windows.Forms;
using KeyenceHostLinkLib;

//
// Created by SharpDevelop.
// User: v106804
// Date: 04-May-16
// Time: 10:20 AM
//
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//
namespace KeyenceHostLinkLib
{
	public class CustomListPropertiesEditor : UITypeEditor
	{
		public string[] MemoryName = new string[] {"Relay", "Link relay", "Internal auxiliary relay", "Latch relay", "Control relay", "Virtual relay", "Data memory", "Extended data memory", "File register", "Link register (FM)", "Link register (ZF)", "Temporary data memory", "Index register", "Timer", "Timer (current value)", "Timer (setting value)", "Counter", "Counter (current value)", "Counter (setting value)", "High-speed counter", "High-speed counter comparator (setting value)", "Digital trimmer", "Control memory", "Virtual memory"};
		public string[] MemoryValue = new string[] {"R", "B", "MR", "LR", "CR", "VB", "DM", "EM", "FM", "ZF", "W", "TM", "Z", "T", "TC", "TS", "C", "CC", "CS", "CTH", "CTC", "AT", "CM", "VM"};
		private IWindowsFormsEditorService frmsvr;
		public CustomListPropertiesEditor()
		{
			
		}
		public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.DropDown;
		}
		public override dynamic EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			frmsvr = (IWindowsFormsEditorService) (provider.GetService(typeof(IWindowsFormsEditorService)));
			if (ReferenceEquals(frmsvr, null))
			{
				return null;
			}
			ListBox lstbox = new ListBox();
			lstbox.Items.AddRange(MemoryName);
			lstbox.SelectedIndex = 0;
			lstbox.SelectedIndexChanged += ListBox1SelectedIndexChanged;
			frmsvr.DropDownControl(lstbox);
			return MemoryValue[lstbox.SelectedIndex];
		}
		
		private void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			frmsvr.CloseDropDown();
		}
	}
	
}
