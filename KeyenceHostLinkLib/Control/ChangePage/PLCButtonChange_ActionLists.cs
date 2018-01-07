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
	
	public class PLCButtonChange_ActionLists : DesignerActionList
	{
		private PLCButtonChange dtc;
		private DesignerActionUIService designerActionUISvc;
		public PLCButtonChange_ActionLists(IComponent component) : base(component)
		{
			this.dtc = component as PLCButtonChange;
			
			// Cache a reference to DesignerActionUIService, so the
			// DesigneractionList can be refreshed.
			this.designerActionUISvc = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
		}
		public TabControl MainPage
		{
			get
			{
				return dtc.MainPage;
			}
			set
			{
				GetPropertyByName("MainPage").SetValue(dtc, value);
			}
		}
		public TabPage NextPage
		{
			get
			{
				return dtc.NextPage;
			}
			set
			{
				GetPropertyByName("NextPage").SetValue(dtc, value);
			}
		}
		public string ButtonText
		{
			get
			{
				return dtc.Button1.Text;
			}
			set
			{
				GetPropertyByName("ButtonText").SetValue(dtc, value);
				dtc.Button1.Text = value;
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
