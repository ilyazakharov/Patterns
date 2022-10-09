namespace Patterns.AbstractFactory
{
    using Patterns.AbstractFactory.ComputerAccessories;

    /// <summary>
    /// Intel accessories factory. Abstract factories are usually singletons.
    /// </summary>
    public class IntelAccessoriesFactory : IComputerAccessoriesFactory
    {
        private static readonly object LockObj = new ();
        private static IntelAccessoriesFactory instance;

        /// <summary>
        /// Creates a singletone.
        /// </summary>
        /// <returns>Singleton instance.</returns>
        public static IntelAccessoriesFactory Instance()
        {
            if (instance != null)
            {
                return instance;
            }

            lock (LockObj)
            {
                if (instance != null)
                {
                    return instance;
                }

                instance = new IntelAccessoriesFactory();
            }

            return instance;
        }

        /// <inheritdoc/>
        public IMotherboard CreateMotherboard()
        {
            return new GygabyteMB();
        }

        /// <inheritdoc/>
        public IProcessor CreateProcessor()
        {
            return new IntelProcessor();
        }
    }
}