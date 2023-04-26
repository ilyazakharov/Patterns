using Patterns.AbstractFactory;
using Patterns.AbstractFactory.ComputerAccessories;
using Patterns.Adapter;
using Patterns.Bridge;
using Patterns.Builder;
using Patterns.ChainOfResposibility;
using Patterns.Command;
using Patterns.Composite;
using Patterns.CurcuitBreaker;
using Patterns.Decorator;
using Patterns.Facade.FacadeExample;
using Patterns.Facade.FactoryMethodForFacade;
using Patterns.FactoryMethod;
using Patterns.Flyweight;
using Patterns.Interpretor;
using Patterns.Iterator;
using Patterns.Mediator;
using Patterns.Memento;
using Patterns.Observer;
using Patterns.Proxy;
using Patterns.Singleton;
using Patterns.SOLID;
using Patterns.State;
using Patterns.Strategy;
using Patterns.TemplateMethod;
using File = Patterns.Composite.File;

TestMemento();

static void TestMemento()
{
    GameHistory gameHistory = new ();
    Witcher witcher = new ();

    gameHistory.SaveGame(witcher.Save(), 1);

    witcher.GetDamage(40);
    Console.WriteLine(witcher);

    var savedWitcher = gameHistory.LoadGame(1);
    if (savedWitcher is not null)
    {
        witcher.Load(savedWitcher);
    }

    Console.WriteLine(witcher);
}

static void TestMediator()
{
    // Mediator is used when you have several entities that should talk with each other, but you don't want them to know about each other.
    ManageMediator mediator = new ManageMediator();
    Colleague pupil = new Pupil(mediator);
    Colleague teacher = new Teacher(mediator);
    Colleague parent = new Parent(mediator);
    mediator.Parent = parent;
    mediator.Teacher = teacher;
    mediator.Pupil = pupil;

    pupil.Send("Why the sky is blue?");
    teacher.Send("Talk with your kid about physics!");
    parent.Send("Physics is very important!");
}

static void TestInterpretor()
{
    // If you have some language with simple rules you may use interpretor to describe it.
    // Interpreter has terminal expression (e.g. IntExpression) and nonterminal expressions (e.g. AddExpression) which may be combined.
    MathContext context = new();

    int x = 10;
    int y = 50;
    int z = 15;

    context.SetValue("x", x);
    context.SetValue("y", y);
    context.SetValue("z", z);

    // x + y - z
    IExpression expr = new SubtractExpression(
        new AddExpression(new IntExpression("x"), new IntExpression("y")),
        new IntExpression("z"));

    Console.WriteLine(expr.Interpret(context));
}

static void TestFlyweight()
{
    // Flyweight is used when there is a huge amount of typical objects and you need to care about memory.
    // Objects have the same internal state, but can behave differently by accepting some external values.
    // In this examples units have internal speed, but their strength depends on external factor (CurrentStrength).
    UnitFactory factory = new();

    for (int i = 0; i < 5; i++)
    {
        IUnit? archer = factory.GetUnit("Archer");
        archer?.Move();
        archer?.Strike(CurrentStrength());

        IUnit? knight = factory.GetUnit("Knight");
    }

    for (int i = 0; i < 5; i++)
    {
        IUnit? knight = factory.GetUnit("Knight");
        knight?.Move();
        knight?.Strike(CurrentStrength() * 2);
    }

    return;

    int CurrentStrength()
    {
        Random rnd = new();
        return rnd.Next(10, 80);
    }
}

static void TestChainOfResposibility()
{
    // Chain of responsibility is used when you need several sequential handlers and the order should be incapsulated from the client.
    IHandler unprocessable = new Unprocessable();
    IHandler support = new Support { NextHandler = unprocessable };
    IHandler callCanter = new CallCenter { NextHandler = support };
    IHandler machine = new AnsweringMachine { NextHandler = callCanter };

    var simpleRequest = new Request(1);
    var unusualRequest = simpleRequest with { Meaning = 2 };
    var complexRequest = simpleRequest with { Meaning = 3 };
    var unexpectedRequest = simpleRequest with { Meaning = 4 };

    machine.Handle(simpleRequest);
    machine.Handle(unusualRequest);
    machine.Handle(complexRequest);
    machine.Handle(unexpectedRequest);
}

static void TestBuilder()
{
    // Used when you need to construct a complex object, but the constructing rules should be incapsulated.
    HouseBuilder houseBuilder = new();
    House house = houseBuilder
        .WithMedievalFacade()
        .WithPark()
        .Build();
    Console.WriteLine(house);
}

static void TestBridge()
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

static void TestCirquitBreaker()
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

static void TestLazyProxy()
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

static void TestState()
{
    // State works very similar to strategy, but it is used for other purposes - the state is internal thing while in strategy pattern it is determined by client.
    Water water = new(50);
    water.Heat();
    water.Heat();
    water.Freeze();
    water.Freeze();
    water.Freeze();
    water.Heat();
}

static void TestComposite()
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

static void PrintFiles(Component component)
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

static void TestIterator()
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

static void TestTemplateMethod()
{
    // Template method define an algorithm and leave the details to be implemented by the child classes.
    ReadingService classicBook = new ClassicBook();
    ReadingService eBook = new EBook();
    classicBook.Process();
    Console.WriteLine();
    eBook.Process();
}

static void TestFacade()
{
    // Facade simplifies work with several objects.
    // Here we use factory method to create the appropriate facade.
    IDishMakerCreator chickenWithPotatoesCreator = new ChickenWithPotatoesMakerCreator();

    // Then we use facade, that makes all the needed cooking, although we could do it ourselves.
    IDishMakerFacade chickenWithPotatoesMaker = chickenWithPotatoesCreator.CreateDishMakerFacade();
    Console.WriteLine(chickenWithPotatoesMaker.MakeDish());
}

static void TestAdapter()
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

static void TestCommand()
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

static void TestAbstractFactory()
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

static void TestFactoryMethod()
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

static void TestDecorator()
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

static void TestObserver()
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

static void TestStrategy()
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

static void TestSingleton()
{
    // Singleton is the class that's being initialized only once.
    // All later calls use this initialized instance.
    Parallel.For(1, 10, x => Console.WriteLine(Singleton.Instance(x).SingletonNum));
}
