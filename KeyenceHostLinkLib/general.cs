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

using System.Net.Sockets;
using KeyenceHostLinkLib;


namespace KeyenceHostLinkLib
{
	public sealed class general
	{
		
		public struct PLCMemory
		{
			public string MemType;
			public int MemAdd;
			public string format;
		}
		public class PLCLink
		{
			public PLCMemory add;
			public IPLCControl usingmethod;
			public bool enable;
			public string cmd;
		}
		public interface IPLCControl
		{
			void useResult(string result);
		}
	}
	
}
