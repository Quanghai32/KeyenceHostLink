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

using System.ComponentModel.Design;
using System.Windows.Forms.Design;
using KeyenceHostLinkLib;

//
// Created by SharpDevelop.
// User: v106804
// Date: 28-Apr-16
// Time: 1:52 PM
//
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//
namespace KeyenceHostLinkLib
{
	
	public class PLCBaseControl_Designer<T> : System.Windows.Forms.Design.ControlDesigner where T : DesignerActionList
	{
		private DesignerActionListCollection _actionLists;
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				if (ReferenceEquals(_actionLists, null))
				{
					_actionLists = new DesignerActionListCollection();
					object aaa = Activator.CreateInstance(typeof(T), this.Component);
					_actionLists.Add((T) aaa);
				}
				return _actionLists;
			}
		}
	}
	
}
