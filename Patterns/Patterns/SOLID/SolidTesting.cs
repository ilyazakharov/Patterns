namespace Patterns.SOLID
{
    using Patterns.SOLID.SingleResponsibility;

    /// <summary>
    /// SOLID examples.
    /// </summary>
    public class SolidTesting
    {
        /// <summary>
        /// Testin SOLID principles.
        /// </summary>
        public static void TestSOLID()
        {
            SolidTesting.SRPViolation();
            SolidTesting.SRP();
        }

        // Single Responsibility principle.
        // A module should be responsible to only one actor.
        private static void SRPViolation()
        {
            // Selling and calculating salary are processes that are used by different actors, but in the same class.
            StoreAndAccounting storeAndAcc = new ();
            Cashier cashier = new (storeAndAcc, null);
            Accountant accountant = new (storeAndAcc, null);
            cashier.DoWorkWithSRPViolation();
            accountant.DoWorkWithSRPViolation();
        }

        private static void SRP()
        {
            // Selling and calculating salary are processes that are used by different actors.
            // StoreAndAccounting was divided into two classes, each for one actor.
            Cashier cashier = new(null, new Store());
            Accountant accountant = new(null, new Accounting());
            cashier.DoWork();
            accountant.DoWork();
        }
    } 
}
