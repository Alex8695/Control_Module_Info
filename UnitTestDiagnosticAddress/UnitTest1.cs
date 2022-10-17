using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DA = Control_Module_Info.Model.Diagnostic_Address_Info;
using System.Diagnostics;

namespace UnitTest
{
	[TestClass]
	public class Diagnostic_Address
	{						

		[TestMethod]
		public void As_HEX()
		{
			DA da = new DA(address: "005F");	 

			Debug.WriteLine($"HEX:       {da.AsHex.PadLeft(6)}");
			Assert.IsTrue(da.AsHex == "0x5F");
							  
		}

		[TestMethod]
		public void As_int32()
		{
			DA da = new DA(address: "005F");

			Debug.WriteLine($"INT32: {da.AsInt32.ToString().PadLeft(6)}");
			Assert.IsTrue(da.AsInt32 == 95);	  
		}

		[TestMethod]
		public void As_String()
		{
			DA da = new DA(address: "005F");

			Debug.WriteLine($"STR: {da.AsString.PadLeft(6)}");
			Assert.IsTrue(da.AsString == "005F");	   
		}

		[TestMethod]
		public void As_HEX_String()
		{
			DA da = new DA(address: "005F");

			Debug.WriteLine($"HEX STR: {da.AsStringHex.PadLeft(6)}");
			Assert.IsTrue(da.AsStringHex == "0x00 0x5F");  
		}

		[TestMethod]
		public void As_String_Short()
		{
			DA da = new DA(address: "005F");

			Debug.WriteLine($"STR SHORT: {da.AsStringShort.PadLeft(6)}");
			Assert.IsTrue(da.AsStringShort == "5F");   
		}

		[TestMethod]
		public void To_String()
		{
			DA da = new DA(address: "005F");		  

			Debug.WriteLine($"ToString():");
			Debug.WriteLine(da.ToString());

			Assert.IsTrue(da.ToString().Length > 0);
		}

	}
}
