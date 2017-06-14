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
	public class IsNegativeTests
	{
		private Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[TestMethod]
		public void CheckIsNegative()
		{
			//Arrange 
			double negativeNumber = -10;

			//Assert
			Assert.IsTrue(_calculator.isNegative(negativeNumber));
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
