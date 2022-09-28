namespace Patterns.Singleton
{
    /// <summary>
    /// Singleton pattern class.
    /// </summary>
    public class Singleton
    {
        private static readonly object LockObj = new ();
        private static volatile Singleton? instance;

        /// <summary>
        /// Initializes a new instance of the <see cref="Singleton"/> class.
        /// </summary>
        /// <param name="singletonNum">Value of the instance.</param>
        public Singleton(int singletonNum)
        {
            this.SingletonNum = singletonNum;
        }

        /// <summary>
        /// Gets the value of the instance.
        /// </summary>
        public int SingletonNum { get; }

        /// <summary>
        /// Function to return singleton object.
        /// </summary>
        /// <param name="num">Value of the instance.</param>
        /// <returns>Singleton object.</returns>
        public static Singleton Instance(int num)
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

                instance = new Singleton(num);
            }

            return instance;
        }
    }
}
