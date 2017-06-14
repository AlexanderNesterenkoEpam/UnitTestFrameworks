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
	public class IsPositiveTests
	{
		private Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[TestMethod]
		public void CheckIsPositive()
		{
			//Arrange 
			double positiveNumber = 10;

			//Assert
			Assert.IsTrue(_calculator.isPositive(positiveNumber));
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
