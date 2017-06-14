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
	public class AddTests
	{
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		public void VerifyAdd()
		{
			//Arrange 
			double firstNumber = 2;
			double secondNumber = 2;
			double result = 4;

			//Assert
			Assert.AreEqual(result, _calculator.Add(firstNumber, secondNumber));
		}

		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
