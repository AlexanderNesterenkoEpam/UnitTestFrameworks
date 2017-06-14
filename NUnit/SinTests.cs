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
	public class SinTests
	{
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		public void VerifySin()
		{
			//Arrange 
			double number = 0;
			double result = 0;

			//Assert
			Assert.AreEqual(result, _calculator.Sin(number));
		}

		[Test]
		public void VerifySin2()
		{
			//Arrange 
			double number = 0;
			double result = 0;

			//Assert
			Assert.AreEqual(result, _calculator.Sin(number));
		}


		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
