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

using KeyenceHostLinkLib;

namespace KeyenceHostLinkLib
{
	//
	// Created by SharpDevelop.
	// User: v106804
	// Date: 04-May-16
	// Time: 11:59 AM
	//
	// To change this template use Tools | Options | Coding | Edit Standard Headers.
	//
	public class PLCBaseControl_DataFormat_Editer : CustomListPropertiesEditor
	{
		public PLCBaseControl_DataFormat_Editer()
		{
			base.MemoryName = new string[] {"Unsigned 16-bit DEC (.U)", "Signed 16-bit DEC (.S)", "Unsigned 32-bit DEC (.D)", "Signed 32-bit DEC (.L)", "16-bit HEX (.H)"};
			base.MemoryValue = new string[] {".U", ".S", ".D", ".L", ".H"};
		}
	}
	
}
