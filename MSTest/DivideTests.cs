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
	public class DivideTests
	{
		private Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[TestMethod]
		public void CheckDivide4_2()
		{
			//Arrange 
			int number = 4;
			double degree = 2;
			double result = 2;

			//Assert
			Assert.AreEqual(result, _calculator.Divide(number, degree));
		}

		[TestMethod]
		[ExpectedException(typeof(System.DivideByZeroException))]
		public void CheckDivisionByZero()
		{
			//Arrange 
			int number = 4;
			double degree = 0;

          _calculator.Divide(number, degree);
		}
		
		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
