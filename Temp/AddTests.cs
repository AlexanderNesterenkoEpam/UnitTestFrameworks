using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Temp
{
	[TestClass]
	public class AddTests
	{
		private Calculator _calculator;

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
		}

		[TestMethod]
		public void CheckAdd()
		{
			double a = 4;
			double b = 2;
			double result = 6;

			//Assert
			Assert.AreEqual(result, _calculator.Add(a, b));
		}

		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
