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
    public class AbsTests
    {		
		private Calculator _calculator;

		[SetUp]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			Thread.Sleep(5000);
		}

		[Test]
		[TestCase(-10.0, 10.0)]
		[TestCase("5", 5)]
		public void VerifyAbs(string number, double result)
		{
			//Act
			double absoluteValue = _calculator.Abs(number);

			//Assert
			Assert.AreEqual(result, absoluteValue);
		}

		[Test]
		public void VerifyAbs_Exception()
		{
			string number = "number";

			//Act
			double absoluteValue = _calculator.Abs(number);

			//Assert
			Assert.That(absoluteValue, Throws.TypeOf<NotFiniteNumberException>());
		}

		[TearDown]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	 }
}

