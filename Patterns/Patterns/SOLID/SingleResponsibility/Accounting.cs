namespace Patterns.SOLID.SingleResponsibility
{
    /// <summary>
    /// Accounting.
    /// </summary>
    public class Accounting
    {
        /// <summary>
        /// Calculating an employee's salary.
        /// </summary>
        /// <param name="employeeName">Employee name.</param>
        public void CalculateSalary(string employeeName)
        {
            Console.WriteLine($"Calculated {employeeName}'s salary.");
        }
    }
}
