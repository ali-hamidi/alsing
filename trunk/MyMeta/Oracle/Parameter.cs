using System;
using System.Data;
using System.Data.OleDb;

namespace MyMeta.Oracle
{

	using System.Runtime.InteropServices;
	[ComVisible(true), ClassInterface(ClassInterfaceType.AutoDual), ComDefaultInterface(typeof(IParameter))]

	public class OracleParameter : Parameter
	{
		public OracleParameter()
		{

		}
	}
}
