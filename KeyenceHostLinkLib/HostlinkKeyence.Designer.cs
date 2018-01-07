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
	public partial class HostlinkKeyence : System.ComponentModel.Component
	{
		
		[System.Diagnostics.DebuggerNonUserCode()]public HostlinkKeyence(System.ComponentModel.IContainer container) : this()
		{
			
			//Required for Windows.Forms Class Composition Designer support
			if (container != null)
			{
				container.Add(this);
			}
			
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]public HostlinkKeyence()
		{
			
			//This call is required by the Component Designer.
			InitializeComponent();
			
		}
		
		//Component overrides dispose to clean up the component list.
		//    <System.Diagnostics.DebuggerNonUserCode()> _
		//    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		//        Try
		//            If disposing AndAlso components IsNot Nothing Then
		//                components.Dispose()
		//            End If
		//        Finally
		//            MyBase.Dispose(disposing)
		//        End Try
		//    End Sub
		
		//Required by the Component Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Component Designer
		//It can be modified using the Component Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			
		}
		
	}
	
}
