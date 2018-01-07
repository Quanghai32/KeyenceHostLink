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
	
	public class PLCRunningStatus_ActionLists : DesignerActionList
	{
		private PLCRunningStatus dtc;
		private DesignerActionUIService designerActionUISvc;
		public PLCRunningStatus_ActionLists(IComponent component) : base(component)
		{
			this.dtc = component as PLCRunningStatus;
			
			// Cache a reference to DesignerActionUIService, so the
			// DesigneractionList can be refreshed.
			this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
		}
		
		public HostlinkKeyence PLC_Link
		{
			get
			{
				return dtc.PLCLink;
			}
			set
			{
				//dtc.PLCLink = value
				GetPropertyByName("PLCLink").SetValue(dtc, value);
			}
		}
		
		public bool DisplayOnly
		{
			get
			{
				return dtc.DisplayOnly;
			}
			set
			{
				GetPropertyByName("DisplayOnly").SetValue(dtc, value);
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
