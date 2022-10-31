namespace Patterns.SOLID.SingleResponsibility
{
    /// <summary>
    /// Accountant.
    /// </summary>
    public class Accountant
    {
        private readonly StoreAndAccounting? workingPlace;
        private readonly Accounting? accounting;

        /// <summary>
        /// Initializes a new instance of the <see cref="Accountant"/> class.
        /// </summary>
        /// <param name="workingPlace">A working place.</param>
        /// <param name="accounting">An accounting.</param>
        public Accountant(StoreAndAccounting? workingPlace, Accounting? accounting)
        {
            this.workingPlace = workingPlace;
            this.accounting = accounting;
        }

        /// <summary>
        /// Work with violation of SRP.
        /// </summary>
        public void DoWorkWithSRPViolation()
        {
            if (this.workingPlace == null)
            {
                return;
            }

            this.workingPlace.CalculateSalary("John Doe");
        }

        /// <summary>
        /// Work correctly.
        /// </summary>
        public void DoWork()
        {
            if (this.accounting == null)
            {
                return;
            }

            this.accounting.CalculateSalary("John Doe");
        }
    }
}
