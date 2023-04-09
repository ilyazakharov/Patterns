using Patterns.AbstractFactory;
using Patterns.AbstractFactory.ComputerAccessories;
using Patterns.Adapter;
using Patterns.Bridge;
using Patterns.Command;
using Patterns.Composite;
using Patterns.CurcuitBreaker;
using Patterns.Decorator;
using Patterns.Facade.FacadeExample;
using Patterns.Facade.FactoryMethodForFacade;
using Patterns.FactoryMethod;
using Patterns.Iterator;
using Patterns.Observer;
using Patterns.Proxy;
using Patterns.Singleton;
using Patterns.SOLID;
using Patterns.State;
using Patterns.Strategy;
using Patterns.TemplateMethod;
using File = Patterns.Composite.File;

/// <summary>
/// Main program.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        TestBridge();
    }

    private static void TestBridge()
    {
        // Usually used when you have two hierarchies and every element in the first hierarchy should be used with every element in the second hierrahy.
        // the bridge pattern lets you not to create cartesian product for these two hierarchies.
        IRenderer rasterRenderer = new RasterRenderer();
        IRenderer vectorRenderer = new VectorRenderer();

        Shape circle = new Circle(rasterRenderer, 10);
        circle.Draw();
        circle.Renderer = vectorRenderer;
        circle.Draw();

        Shape square = new Square(rasterRenderer, 15);
        square.Draw();
        square.Renderer = vectorRenderer;
        square.Draw();
    }

    private static void TestCirquitBreaker()
    {
        // Cirquit breaker disables the ability to call the external repository for some time after te repository has thrown an error.
        ExternalServiceRepository repository = new ExternalServiceRepository();
        ICircuitBreaker cb = new AntiDdosCurcuitBreaker(2);

        // Everything works fine.
        repository.ShouldThrow = false;
        cb.Execute(repository.DoSomeWork);

        // Error is thrown.
        repository.ShouldThrow = true;
        cb.Execute(repository.DoSomeWork);

        // Erro is thrown from the cirquit breaker.
        Task.Delay(1000).Wait();
        cb.Execute(repository.DoSomeWork);

        // Timeout has passed, tries to call the repository, but fails.
        Task.Delay(1000).Wait();
        cb.Execute(repository.DoSomeWork);

        // The repository is fine now, but the exception is thrown by the curuit breaker because the timeout has not passed since last error in repository.
        Task.Delay(1000).Wait();
        repository.ShouldThrow = false;
        cb.Execute(repository.DoSomeWork);

        // Timeout has passed, calls the repository and succeeds.
        Task.Delay(1000).Wait();
        cb.Execute(repository.DoSomeWork);

        // Everything works fine.
        cb.Execute(repository.DoSomeWork);
    }

    private static void TestLazyProxy()
    {
        /// If there is a heavy class that is not used everytime and you don't want to have it instantiated it and keep in memory you may use Proxy pattern.
        /// The object is created only when needed. Also it may cache some values.
        IHeavyClass heavyClass = new LazyHeavyClassProxy();

        bool isRareEvent = true;
        if (isRareEvent)
        {
            Console.WriteLine(heavyClass.GetValue(10));
        }
    }

    private static void TestState()
    {
        // State works very similar to strategy, but it is used for other purposes - the state is internal thing while in strategy pattern it is determined by client.
        Water water = new (50);
        water.Heat();
        water.Heat();
        water.Freeze();
        water.Freeze();
        water.Freeze();
        water.Heat();
    }

    private static void TestComposite()
    {
        Component mainFolder = new Folder("Source");
        Component secondaryFolder = new Folder("CompositeProject");
        Component readmeFile = new File("README.MD");
        Component exeFile = new File("main.exe");
        Component pictureFile = new File("funny.jpeg");

        mainFolder.Add(secondaryFolder);
        mainFolder.Add(pictureFile);
        secondaryFolder.Add(readmeFile);
        secondaryFolder.Add(exeFile);

        PrintFiles(mainFolder);

        mainFolder.Remove(pictureFile);
        pictureFile.Print();
    }

    private static void PrintFiles(Component component)
    {
        foreach (Component c in component.GetSubComponents())
        {
            try
            {
                PrintFiles(c);
            }
            catch (NotImplementedException)
            {
                c.Open();
            }
        }
    }

    private static void TestIterator()
    {
        CafeMenu cafeMenu = new(new List<MenuItem>
        {
            new MenuItem("Burger", false),
            new MenuItem("Salad", true),
        });

        IMenuItemIterator iterator = cafeMenu.GetIterator();
        while (iterator.HasNext())
        {
            MenuItem item = iterator.Next();
            Console.WriteLine($"Item: {item.Name}, gluten free: {item.IsGlutenFree}");
        }
    }

    private static void TestTemplateMethod()
    {
        // Template method define an algorithm and leave the details to be implemented by the child classes.
        ReadingService classicBook = new ClassicBook();
        ReadingService eBook = new EBook();
        classicBook.Process();
        Console.WriteLine();
        eBook.Process();
    }

    private static void TestFacade()
    {
        // Facade simplifies work with several objects.
        // Here we use factory method to create the appropriate facade.
        IDishMakerCreator chickenWithPotatoesCreator = new ChickenWithPotatoesMakerCreator();

        // Then we use facade, that makes all the needed cooking, although we could do it ourselves.
        IDishMakerFacade chickenWithPotatoesMaker = chickenWithPotatoesCreator.CreateDishMakerFacade();
        Console.WriteLine(chickenWithPotatoesMaker.MakeDish());
    }

    private static void TestAdapter()
    {
        // Adapter adaptizes one interface to the other.
        ICar car = new SpecificCar();
        car.Drive();
        car.Accelerate();
        car.Stop();

        IPlane plane = new SpecificPlane();
        PlaneAdapter adapter = new(plane);
        adapter.Drive();
        adapter.Accelerate();
        adapter.Stop();
    }

    private static void TestCommand()
    {
        // Command pattern lets us to encapslate a request as an object.
        ClientAccount acc1 = new("QWERTY", 10);
        ClientAccount acc2 = new("ASDF", 0);

        List<ICommand> sellCommands = new()
        {
            new SellStock(acc1),
            new SellStock(acc2),
        };

        List<ICommand> buyCommands = new()
        {
            new BuyStock(acc1),
            new BuyStock(acc2),
        };

        StockExchange exchange = new(sellCommands, buyCommands);

        exchange.Sell(0);
        exchange.Sell(1);
        exchange.Redo();
        exchange.Undo();
        exchange.Undo();
        exchange.Undo();
        exchange.Buy(1);
        Console.WriteLine(acc1.ToString());
        Console.WriteLine(acc2.ToString());

        ICommand buy2Sell1Command = new MacroCommand(
            new List<ICommand>()
                {
                    new BuyStock(acc1),
                    new BuyStock(acc1),
                    new SellStock(acc1),
                },
            new List<ICommand>()
                {
                    new SellStock(acc1),
                });
        exchange.SellCommands.Add(buy2Sell1Command);
        exchange.Sell(2);
        exchange.Redo();
        exchange.Undo();
        Console.WriteLine(acc1.ToString());
    }

    private static void TestAbstractFactory()
    {
        // Abstract factory creates families of different objects.
        IComputerAccessoriesFactory intelFactory = IntelAccessoriesFactory.Instance();
        IComputerAccessoriesFactory amdFactory = AMDAccessoriesFactory.Instance();

        List<Computer> computers = new()
        {
            new Computer(intelFactory, "Intel hi-pro", new KingstonMemory()),
            new Computer(amdFactory, "AMD station", new KingstonMemory()),
        };

        computers.ForEach(x => Console.WriteLine(x.Description()));
    }

    private static void TestFactoryMethod()
    {
        // Factory method can create instances of different entities.
        OperationCreator bank = new OperationalBank();
        OperationCreator exchange = new Exchange();

        List<Oper> opers = new List<Oper>()
        {
            bank.CreateOperation("UEI1234", 140006.5m),
            exchange.CreateOperation("KJ235423", 23452.8m),
        };

        opers.ForEach(x => Console.WriteLine(x.ToString()));
    }

    private static void TestDecorator()
    {
        // Decorator show O-principle of SOLID
        // You can create as many classes as you need to decorate main class.
        Operation inOper = new InOperation("Q123", 125.45m);
        inOper = new OperWithCommission(inOper);
        Operation outOper = new OperationWithContragent(
            new OperWithCommission(
                new OutOperation("RT5543", 42.1m)));

        Console.WriteLine($"{inOper.Description} amount = {inOper.Amount} and number = {inOper.ExtNumber}");
        Console.WriteLine($"{outOper.Description} amount = {outOper.Amount} and number = {outOper.ExtNumber}");
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

        // Using Strategy pattern gives us an opportunity to change the behavour ad hoc.
        conveyances[1].Driver = human;
        conveyances[1].MoveForward();
        conveyances[1].ImplementShout();
    }

    private static void TestSingleton()
    {
        // Singleton is the class that's being initialized only once.
        // All later calls use this initialized instance.
        Parallel.For(1, 10, x => Console.WriteLine(Singleton.Instance(x).SingletonNum));
    }
}