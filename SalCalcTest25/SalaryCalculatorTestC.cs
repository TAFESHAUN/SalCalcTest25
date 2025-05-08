using IncomeCalculatorLibs;

namespace SalCalcTest25
{
    ///<summary>
    ///Setup a Salary Calculator
    /// Use the AAA OF TESTING
    ///To get hourly, divide annual salary by 2080
    ///$100,006.40 / 2080 = $48.08 hr
    ///To get annual, multiply hourly by 2080
    ///$48.08 * 2080 = $100,006.40
    ///</summary>
    [TestClass]
    public sealed class SalaryCalculatorTestC
    {
        //Scoped for all calc tests
        SalaryCalculator calculator = new SalaryCalculator();
        
        //DATA STRUCTURE that we use for all tests
        // LIST, Dictionary, Array, Object, Tree, Stack, Database, Queue, Db Schema, Class, Struct

        /// <summary>
        /// Test the Hourly Salary
        /// </summary>
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //Arange - Setup the data
            //decimal wage = 48.08m;
            //decimal exAnnualSalary = 100006.40m;

            //Act - Access the data
            decimal actAnnualSalary = calculator.GetAnnualSalary(48.08m);

            //Assert - Check the data
            //Assert.AreEqual(expected vs actual)
            Assert.AreEqual(100006.40m, actAnnualSalary);

        }

        [TestMethod]
        public void HourlyWageTest()
        {
            //Arrange - Setup the data
            decimal exWage = 48.08m;
            decimal annualSalary = 100006.40m;

            //Act - Access the data
            decimal actWage = calculator.GetHourlyWage(annualSalary);

            //Assert - Check the data   
            Assert.AreEqual(exWage, actWage);

        }
    }
}
