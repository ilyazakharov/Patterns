# SOLID
## Single responsibility principle (SRP)
# Creational patterns
## Abstract factory
Provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.
## Builder
Encapsulates the construction of a product and allows it to be constructed in steps.
## Factory method
Defines an interface for  createing an object. Subclasses decide which concrete object ro create.
## Prototype
Objects have the abiility to clone themselves.
## Singleton
Class can have only one instance.
# Structural patterns
## Adapter
Lets a client to work with some interface by interacting with it with other interface.
## Bridge
Places the implementation and the abstraction in separate hierarchies.
## Composite
Provides a way to work with tree structures. Client can work with structures and leaves the same way.
## Decorator
Adds a new behaviour to an object dynamically.
## Facade
Provides a way to work with a complex set of classes like it was just one class.
## Flyweight
Allows to create many similar objects, but keeping in memory only one.
## Proxy
Provides a placeholder for another object to control access to it.
# Behavioral patterns
## Chain of responsibility
Provides a chain of actions which is incapulated in called objects. Client know nothing about the chain.
## Command
Encapsulates request as an object and lets to undo and redo requests.
## Interpretor
Represents a language and its rules with classes.
## Iterator
Encapsulates the way to iterate a collection.
## Mediator
Provides a way for several objects to interact with each other without knowing about each other.
## Memento
Encapsulates a way to save and load a state of an object.
## Observer
Provides a way for consuming classes to subsribe to events of the producer class.
## State
Encapsulates the state and state-dependent behaviour of the class into a state class.
## Strategy
Encapsulates the behaviour into another class using association (aggregation or composition).
## Template method
Provides to set the steps of an algorithm in an abstract class, but lets the subclasses to provide the implementation of every step.
## Visitor
Encapsulates the behaviour of the class in visitor classes.
# Microservices patterns
## Cirquit breaker
Provides a protection from DDOS-ing for a service.