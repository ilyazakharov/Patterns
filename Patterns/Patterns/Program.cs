// Patterns for education
using Patterns.Observer;
using Patterns.Singleton;
using Patterns.Strategy;

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
        TestStrategy();
    }

    /// <summary>
    /// Shows the singleton pattern.
    /// </summary>
    private static void TestSingleton()
    {
        // Singleton is the class that's being initialized only once.
        // All later calls use this initialized instance.
        Parallel.For(1, 10, x => Console.WriteLine(Singleton.Instance(x).SingletonNum));
    }

    private static void TestObserver()
    {
        // Observer is one-to-many publisher-subscribers pattern.
        // corporateEventHandler is a publisher, while banks and companies are subscribers.
        CorporateEventHandler corporateEventHandler = new CorporateEventHandler();
        Bank sber = new Bank("Sber", corporateEventHandler);
        Bank vtb = new Bank("VTB", corporateEventHandler);
        AssetsManagementCompany company = new AssetsManagementCompany("First AM", corporateEventHandler);

        corporateEventHandler.ProcessData("dividents", 100);
        corporateEventHandler.ProcessData("IPO", 9900);

        vtb.StopListening();
        corporateEventHandler.ProcessData("SPO", 3000);
    }

    private static void TestStrategy()
    {
        // Strategy uses association for implementing behavour of different algorythms.
        // Drivers are the aggregate type of assosiation.
        // Fly behavour is the composite type of assosiation.
        IDriver human = new Human("John");
        IDriver alien = new Alien("Agrawwev");

        List<Conveyance> conveyances = new List<Conveyance>()
        {
            new Car(human),
            new Plane(alien),
        };

        conveyances.ForEach(x =>
        {
            x.MoveForward();
            x.ImplementFly();
            x.ImplementShout();
            Console.WriteLine();
        });

        // Using strategy pattern gives us an opportunity to change the behavour ad hoc.
        conveyances[1].Driver = human;
        conveyances[1].MoveForward();
        conveyances[1].ImplementShout();
    }
}