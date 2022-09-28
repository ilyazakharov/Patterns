// Patterns for education

using Patterns.Singleton;

/// <summary>
/// Main program.
/// </summary>
internal class Program
{
    /// <summary>
    ///  Main entry to the program.
    /// </summary>
    /// <param name="args">Default parameter.</param>
    private static void Main(string[] args)
    {
        TestSingletone();
    }

    /// <summary>
    /// Shows the singletone pattern.
    /// </summary>
    private static void TestSingletone()
    {
        Parallel.For(1, 10, x => Console.WriteLine(Singleton.Instance(x).SingletonNum));
    }
}