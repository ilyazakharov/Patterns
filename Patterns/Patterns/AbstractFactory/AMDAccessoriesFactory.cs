namespace Patterns.AbstractFactory
{
    using Patterns.AbstractFactory.ComputerAccessories;

    /// <summary>
    /// AMD accessories factory.
    /// </summary>
    public class AMDAccessoriesFactory : IComputerAccessoriesFactory
    {
        private static readonly object LockObj = new ();
        private static AMDAccessoriesFactory instance;

        private AMDAccessoriesFactory()
        {
        }

        /// <summary>
        /// Creates a singletone. Abstract factories are usually singletons.
        /// </summary>
        /// <returns>Singleton instance.</returns>
        public static AMDAccessoriesFactory Instance()
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

                instance = new AMDAccessoriesFactory();
            }

            return instance;
        }

        /// <inheritdoc/>
        public IMotherboard CreateMotherboard()
        {
            return new AsusMB();
        }

        /// <inheritdoc/>
        public IProcessor CreateProcessor()
        {
            return new AMDProcessor();
        }
    }
}