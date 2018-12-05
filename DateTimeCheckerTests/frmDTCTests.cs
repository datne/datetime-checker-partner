using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateTimeChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeChecker.Tests
{
	[TestClass()]
	public class frmDTCTests
	{
		frmDTC frmDate = new frmDTC();
		
		//Test CheckNumber
		[TestMethod()]
		public void TestNumber()
		{
			string day = "30";
			bool check = frmDate.CheckNumber(day);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestNumber1()
		{
			string day = "asd";
			bool check = frmDate.CheckNumber(day);
			Assert.IsFalse(check);
		}
		[TestMethod()]
		public void TestNumber2()
		{
			string day = "@#$";
			bool check = frmDate.CheckNumber(day);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_Day0_Month0_Year0()
		{
			ushort y=0;
			byte m=0;
			byte d=0;
			bool check = frmDate.IsValidDate(y,m,d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate1_D0_M0_Y2012()
		{
			ushort y = 2012;
			byte m = 0;
			byte d = 0;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}
		[TestMethod()]
		public void TestIsValidDate1_D0_M1_Y0()
		{
			ushort y = 0;
			byte m = 1;
			byte d = 0;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate1_D1_M0_Y0()
		{
			ushort y = 0;
			byte m = 0;
			byte d = 1;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate1_D0_M1_Y2012()
		{
			ushort y = 2012;
			byte m = 1;
			byte d = 0;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}
		[TestMethod()]
		public void TestIsValidDate1_D1_M0_Y2012()
		{
			ushort y = 2012;
			byte m = 0;
			byte d = 1;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D1_M1_Y0()
		{
			ushort y = 0;
			byte m = 1;
			byte d = 1;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M4_Y2012()
		{
			ushort y = 2012;
			byte m = 4;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M6_Y2012()
		{
			ushort y = 2012;
			byte m = 6;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M9_Y2012()
		{
			ushort y = 2012;
			byte m = 9;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M11_Y2012()
		{
			ushort y = 2012;
			byte m = 11;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}
		[TestMethod()]
		public void TestIsValidDate_D1_M1_Y3001()
		{
			ushort y = 3001;
			byte m = 1;
			byte d = 1;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D1_M13_Y2012()
		{
			ushort y = 2012;
			byte m = 13;
			byte d = 1;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D32_M11_Y2012()
		{
			ushort y = 2012;
			byte m = 11;
			byte d = 32;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}
		[TestMethod()]
		public void TestIsValidDate_D29_M2_Y2001()
		{
			ushort y = 2001;
			byte m = 2;
			byte d = 29;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D28_M2_Y2001()
		{
			ushort y = 2001;
			byte m = 2;
			byte d = 28;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}
		[TestMethod()]
		public void TestIsValidDate_D29_M2_Y2000()
		{
			ushort y = 2000;
			byte m = 2;
			byte d = 29;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M1_Y2000()
		{
			ushort y = 2000;
			byte m = 1;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M3_Y2000()
		{
			ushort y = 2000;
			byte m = 3;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M5_Y2000()
		{
			ushort y = 2000;
			byte m = 5;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M7_Y2000()
		{
			ushort y = 2000;
			byte m = 7;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M8_Y2000()
		{
			ushort y = 2000;
			byte m = 8;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M10_Y2000()
		{
			ushort y = 2000;
			byte m = 10;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M12_Y2000()
		{
			ushort y = 2000;
			byte m = 12;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsTrue(check);
		}
		[TestMethod()]
		public void TestIsValidDate_D99_M2_Y2012()
		{
			ushort y = 2012;
			byte m = 2;
			byte d = 99;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}
		[TestMethod()]
		public void TestIsValidDate_D32_M99_Y2012()
		{
			ushort y = 2012;
			byte m = 99;
			byte d = 32;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}

		[TestMethod()]
		public void TestIsValidDate_D31_M13_Y999()
		{
			ushort y = 9999;
			byte m = 13;
			byte d = 31;
			bool check = frmDate.IsValidDate(y, m, d);
			Assert.IsFalse(check);
		}



	}
}