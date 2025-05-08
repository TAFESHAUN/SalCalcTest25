using IncomeCalculatorLibs;

namespace SalCalcTest25
{
    ///<summary>
    ///Setup a Salary Calculator
    ///To get hourly, divide annual salary by 2080
    ///$100,006.40 / 2080 = $48.08 hr
    ///To get annual, multiply hourly by 2080
    ///$48.08 * 2080 = $100,006.40
    ///</summary>
    [TestClass]
    public sealed class SalaryCalculatorTestC
    {
        /// <summary>
        /// Test the Hourly Salary
        /// </summary>
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //Arange - Setup the data
            SalaryCalculator calculator = new SalaryCalculator();
            decimal wage = 48.08m;
            decimal exAnnualSalary = 100006.40m;

            //Act - Access the data
            decimal actAnnualSalary = calculator.GetAnnualSalary(wage);

            //Assert - Check the data
            //Assert.AreEqual(expected vs actual)
            Assert.AreEqual(exAnnualSalary, actAnnualSalary);

        }
    }
}
