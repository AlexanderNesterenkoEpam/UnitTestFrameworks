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
	public class PowTests
	{
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		public void VerifyPow()
		{
			//Arrange 
			int number = 2;
			double degree = 2;
			double result = 4;

			double res = _calculator.Pow(number, degree);

			//Assert
			Assert.AreEqual(result, _calculator.Pow(number, degree));
		}

		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
