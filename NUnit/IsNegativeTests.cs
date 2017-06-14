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
	public class IsNegativeTests
	{
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		public void VerifyIsNegative()
		{
			//Arrange 
			double negativeNumber = -10;

			//Assert
			Assert.IsTrue(_calculator.isNegative(negativeNumber));
		}

		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
