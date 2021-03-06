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
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Drawing.Design;
using KeyenceHostLinkLib;

//
// Created by SharpDevelop.
// User: v106804
// Date: 28-Apr-16
// Time: 1:50 PM
//
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//
namespace KeyenceHostLinkLib
{
	
	public class PLCNumberBox_ActionLists : DesignerActionList
	{
		private PLCNumberBox dtc;
		private DesignerActionUIService designerActionUISvc;
		public PLCNumberBox_ActionLists(IComponent component) : base(component)
		{
			this.dtc = component as PLCNumberBox;
			
			// Cache a reference to DesignerActionUIService, so the
			// DesigneractionList can be refreshed.
			this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
		}
		[Category("PLC connection"), Editor(typeof(PLCBaseControl_DataFormat_Editer), typeof(UITypeEditor)), DefaultValue(".U")]
			public string DataFormat
			{
			get
			{
				return dtc.DataFormat;
			}
			set
			{
				GetPropertyByName("DataFormat").SetValue(dtc, value);
			}
		}
		[Category("PLC connection"), Editor(typeof(PLCNumberBox_MemoryType_Editer), typeof(UITypeEditor)), DefaultValue("DM")]
			public string MemoryType
			{
			get
			{
				return dtc.MemoryType;
			}
			set
			{
				GetPropertyByName("MemoryType").SetValue(dtc, value);
			}
		}
		public int PLCAddress
		{
			get
			{
				return dtc.PLCAddress;
			}
			set
			{
				GetPropertyByName("PLCAddress").SetValue(dtc, value);
			}
		}
		
		public HostlinkKeyence PLCLink
		{
			get
			{
				return dtc.PLCLink;
			}
			set
			{
				GetPropertyByName("PLCLink").SetValue(dtc, value);
			}
		}
		
		private PropertyDescriptor GetPropertyByName(string propName)
		{
			PropertyDescriptor prop = default(PropertyDescriptor);
			prop = TypeDescriptor.GetProperties(dtc)[propName];
			if (ReferenceEquals(prop, null))
			{
				throw (new ArgumentException("Matching Target property not found!", propName));
			}
			else
			{
				return prop;
			}
		}
		
	}
	
}
