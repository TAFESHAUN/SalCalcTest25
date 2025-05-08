namespace IncomeCalculatorLibs
{
    public class SalaryCalculator
    {
        const int hoursInYear = 2080;
        //Methods/Functions that do the salary calculations
        public decimal GetAnnualSalary(decimal hourlyWage) => hourlyWage * hoursInYear;
       //Method that gets the hourly wage
       public decimal GetHourlyWage(decimal annualSal) => annualSal / hoursInYear;
    }
}
