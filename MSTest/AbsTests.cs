using System;
using System.Threading;
using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest
{
	[TestClass]
	public class AbsTests
	{
		private Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[TestMethod]
		public void CheckAbs()
		{
			//Arrange 
			double number = -5;
			double result = 5;

			//Assert
			Assert.AreEqual(result, _calculator.Abs(number));
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
