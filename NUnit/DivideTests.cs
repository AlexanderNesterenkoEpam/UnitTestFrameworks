using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Calculator1;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
	[Parallelizable(ParallelScope.Fixtures)]
	public class DivideTests
	{
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		public void VerifyDivide()
		{
			//Arrange 
			int number = 4;
			double degree = 2;
			double result = 2;

			//Assert
			Assert.AreEqual(result, _calculator.Divide(number, degree));
		}

		[Test]
		[TestCase(0, typeof(DivideByZeroException))]
		public void VerifyDivisionByZero(int divider,  Type expectedException)
		{
			//Arrange 
			double number = 4;

		}

		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
