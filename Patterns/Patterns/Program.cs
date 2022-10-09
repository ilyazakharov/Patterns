﻿using Patterns.Decorator;
using Patterns.FactoryMethod;
using Patterns.Observer;
using Patterns.Singleton;
using Patterns.Strategy;

/// <summary>
/// Main program.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        TestFactoryMethod();
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