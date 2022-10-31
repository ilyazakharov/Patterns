namespace Patterns.SOLID.SingleResponsibility
{
    /// <summary>
    /// Cashier.
    /// </summary>
    public class Cashier
    {
        private readonly StoreAndAccounting? workingPlace;
        private readonly Store? store;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cashier"/> class.
        /// </summary>
        /// <param name="workingPlace">A working place.</param>
        /// <param name="store">A store.</param>
        public Cashier(StoreAndAccounting? workingPlace, Store? store)
        {
            this.workingPlace = workingPlace;
            this.store = store;
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

            this.workingPlace.SellProducts("Milk");
        }

        /// <summary>
        /// Work correctly.
        /// </summary>
        public void DoWork()
        {
            if (this.store == null)
            {
                return;
            }

            this.store.SellProducts("Milk");
        }
    }
}
