using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
	[TestClass]
	public class CosTests
	{
		private Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[TestMethod]
		public void CheckCos()
		{
			//Arrange 
			double number = 0;
			double result = 1;

			//Assert
			Assert.AreEqual(result, _calculator.Cos(number));
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
