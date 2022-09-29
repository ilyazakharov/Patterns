// Patterns for education

using Patterns.Observer;
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
        TestObserver();
    }

    /// <summary>
    /// Shows the singleton pattern.
    /// </summary>
    private static void TestSingleton()
    {
        Parallel.For(1, 10, x => Console.WriteLine(Singleton.Instance(x).SingletonNum));
    }

    private static void TestObserver()
    {
        CorporateEventHandler corporateEventHandler = new CorporateEventHandler();
        Bank sber = new Bank("Sber", corporateEventHandler);
        Bank vtb = new Bank("VTB", corporateEventHandler);
        AssetsManagementCompany company = new AssetsManagementCompany("First AM", corporateEventHandler);

        corporateEventHandler.ProcessData("dividents", 100);
        corporateEventHandler.ProcessData("IPO", 9900);

        vtb.StopListening();
        corporateEventHandler.ProcessData("SPO", 3000);
    }
}