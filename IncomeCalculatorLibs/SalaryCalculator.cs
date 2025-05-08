namespace IncomeCalculatorLibs
{
    public class SalaryCalculator
    {
        const int hoursInYear = 2080;
        //Methods/Functions that do the salary calculations
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            decimal annualSal = hourlyWage * hoursInYear;
            return annualSal;
        }

        //2nd method
    }
}
