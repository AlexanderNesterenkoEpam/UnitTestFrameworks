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
	public class MultiplyTests
	{
		private Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[TestMethod]
		public void CheckMultiply()
		{ 
			//Arrange 
			double firstNumber = 10;
			double secondNumber = 5;
			double resultOfMultiply = 50;

			//Assert
			Assert.AreEqual(resultOfMultiply, _calculator.Multiply(firstNumber, secondNumber));
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
