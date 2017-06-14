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
	public class MultiplyTests
	{
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		public void VerifyMultiply()
		{
			//Arrange 
			double firstNumber = 10;
			double secondNumber = 5;
			double resultOfMultiply = 50;

			//Assert
			Assert.AreEqual(resultOfMultiply, _calculator.Multiply(firstNumber, secondNumber));
		}

		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
