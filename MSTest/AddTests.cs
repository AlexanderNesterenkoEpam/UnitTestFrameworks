using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Calculator1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MSTest
{
	[TestClass]
	public class AddTests
	{
		private Calculator _calculator;
		public TestContext TestContext { get; set; }

		[TestInitialize]
		public void TestInitialize()
		{
			_calculator = new Calculator();
			//Thread.Sleep(5000);

		}
		// C:/TempAlex/Data.xml
		//[TestMethod]
		//[DeploymentItem(@"C:\\TempAlex\\Data.xml")]



		//[DataSource("MyExcelDataSource")]
		//[DeploymentItem("MSTest\\Data.xlsx")]
		[TestMethod]
		[DeploymentItem("Data.xml")]
		[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\Data.xml", "Row", DataAccessMethod.Sequential)]
		public void CheckAdd()
		{
			object a = (string)this.TestContext.DataRow["a"];
			object b = (string)this.TestContext.DataRow["b"];
			double result = Double.Parse((string)this.TestContext.DataRow["c"]);

			Assert.AreEqual(result, _calculator.Add(a, b));
		}


		[TestCleanup]
		public void TestCleanUp()
		{
			_calculator = null;
		}
	}
}
