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
	public class IsPositiveTests
	{
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		public void VerifyIsPositive()
		{
			//Arrange 
			double positiveNumber = 10;

			//Assert
			Assert.IsTrue(_calculator.isPositive(positiveNumber));
		}

		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
