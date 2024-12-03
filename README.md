# Design-Patterns
All Design Pattern code and explanations are here. Each folder contains the explanation and C# code written for Visual Studio Code.

I aim to keep the code simple and well-explained. Read the explanation inside each folder, clone the pattern to your environment, and run it to explore and understand it better.

# Adapter

### Definition
The **Adapter Pattern** (also known as the *Wrapper Pattern*) allows two incompatible interfaces to work together by acting as a bridge. It translates one interface into another that the client expects, enabling seamless interaction between otherwise incompatible components.

### Key Features
- Converts the interface of one class into another expected by the client.
- Facilitates compatibility without modifying existing code.
- Used to adapt legacy code or integrate third-party libraries.

# Bridge

### Definition
The **Bridge** is a structural design pattern that separates an abstraction from its implementation, allowing them to vary independently. It achieves this by using composition to decouple abstraction and implementation instead of relying on inheritance.

### Key Features
- Abstraction and implementation are not tightly coupled at compile time.
- Both abstraction and implementation can evolve independently without impacting clients.
- Promotes flexibility by favoring composition over inheritance.

### When to Use
- When you need runtime binding of an implementation.
- To reduce class proliferation caused by combining multiple interfaces and implementations.
- To share a single implementation across multiple abstractions.
- To handle orthogonal (independent) class hierarchies effectively.

Before Bridge Pattern:

                      ----Shape---
                  /                  \
         Rectangle                    Circle
        /         \                  /      \
	BlueRectangle  RedRectangle BlueCircle RedCircle


After Bridge Pattern:

             ----Shape---                        Color
            /            \                       /   \
	Rectangle(Color)   Circle(Color)           Blue   Red

# Builder

### Definition
The **Builder** is a creational design pattern used when constructing a complex object step by step. Unlike a factory, which creates an entire object in a single method call, a builder allows for the construction of an object through a series of method calls, making it easier to handle complex objects with many parts.

### Key Features
- Useful for creating complex objects with many parts.
- Allows for step-by-step construction, where each method adds a part to the object.
- Focuses on assembling parts in a specific order to produce the final object.

### When to Use
- When creating objects that require multiple steps or configurations.
- To separate the construction of an object from its representation, allowing for different variations of the object.
- When a simple factory method is not sufficient due to the complexity of the object being created.

# Chain of Responsibility

### Definition
The **Chain of Responsibility** is a behavioral design pattern that allows a request to be passed through a chain of handlers. Each handler in the chain examines the request and either processes it or passes it along to the next handler.

### Key Features
- Decouples the sender of the request from its receivers.
- Simplifies objects by removing the need to know about the structure of the chain or hold references to its members.
- Supports dynamic changes by adding or removing handlers in the chain.

### Benefits
- **Decoupling**: Sender and receiver are independent.
- **Simplified Objects**: Handlers don't need to know about each other.
- **Flexibility**: Responsibility can be changed or extended dynamically by modifying the chain.

### Drawbacks
- **Uncertainty**: The request may not be handled if no handler in the chain is suitable.
- **Debugging**: Runtime behavior may be complex and difficult to trace.

### Potential Use Cases
- **Event handling**: For example, mouse clicks or keyboard events are passed through multiple handlers (e.g., focus handling, validation, logging).
- **Email processing**: An email might be processed through a series of filters (e.g., spam filter, classification, forwarding).
- **Servlet Filters**: 
  - A filter checks user authentication and passes to the next filter.
  - The next filter checks user permissions.
  - The next filter logs the request and passes it along.
  - Finally, if no more filters exist, the target resource is invoked.

# Command

### Definition
The **Command** is a behavioral design pattern that encapsulates a request as an object, allowing the sender to decouple itself from the receiver. This means that the executor doesn't need to know what the command does, how it's executed, or what context is involved; all of that is abstracted within the command itself.

### Key Features
- **Decoupling**: The sender does not need to know the specifics of how the command is executed.
- **Encapsulation**: The command stores all the information necessary to perform an action.
- **Flexibility**: Commands can be stored, passed around, or scheduled for later execution.

### When to Use
- When you need to queue commands, schedule them, or pass them as parameters.
- When you want to support undo/redo functionality, as each command is a self-contained object.
- When you need to decouple the object that invokes the operation from the one that performs it.

### Benefits
- **Hiding Implementation**: The actual execution of the command is hidden from the caller.
- **Extensibility**: You can easily add new commands without changing existing code by creating new command classes.

# Composite

### Definition
The **Composite** is a structural design pattern that allows you to treat individual objects and compositions of objects uniformly. It is used to represent part-whole hierarchies, where individual objects and their compositions are treated the same way, enabling clients to work with complex structures without needing to distinguish between components and their containers.

### When to Use
- When you need to represent part-whole hierarchies of objects (e.g., tree structures, organizational charts).
- When you want clients to interact with individual objects and compositions in a uniform way, without needing to differentiate between them.

# Decorator

### Definition
The **Decorator** is a structural design pattern that allows you to add additional functionality to a specific object dynamically, without altering the class of the object. Unlike subclassing, which applies changes to all objects of a class, the **Decorator Pattern** enables you to extend the behavior of individual objects while keeping other instances unaffected.

### When to Use
- When you need to add functionality to a single object without affecting others of the same class.
- When subclassing would result in a large number of classes due to various combinations of functionality.

# Facade

### Definition
The **Facade** is a structural design pattern that provides a simplified interface to a complex system, hiding its internal complexities. It offers a high-level interface that makes the system easier to use and decouples the client code from the subsystem details, allowing the system to be modified with minimal impact on the client.

### When to Use
- When you want to simplify interaction with a complex system or subsystem.
- To provide a unified interface to a set of interfaces in a subsystem.
- When you need to decouple client code from complex subsystem details, making the system easier to maintain and extend.

# Factory

### Definition
The **Factory** is a creational design pattern that allows you to create objects without exposing the instantiation logic to the client. The client simply provides the necessary input, and the factory handles the creation of the object, including any dependencies or complex initialization.

### When to Use
- When object creation is complex or requires several steps.
- To decouple the client from the specific classes that need to be instantiated.
- When you need to centralize object creation in one place, simplifying the code for clients.

# Flyweight

### Definition
The **Flyweight** is a structural design pattern that optimizes resource usage by sharing objects. Instead of creating a new instance for each request, it reuses existing objects that are similar, creating new ones only when no match is found. This pattern is especially useful when dealing with large numbers of objects to minimize memory usage.

### When to Use
- When you have a large number of similar objects and need to optimize memory usage.
- To reduce the overhead of creating numerous objects that have many common attributes.
- In scenarios like text editors, where characters are reused across a large document.

### Key Features
- **Reuse**: Objects are shared and reused, minimizing memory consumption.
- **Efficient**: New objects are created only when no existing match is found.
- **Optimized Memory**: Makes sense in scenarios where many identical or similar objects are needed.

### Example Use Case
In a text editor, instead of creating a new object for each character in a 10,000-word document, the Flyweight pattern uses just 26 objects (for each letter of the alphabet). These objects are reused whenever the same character is needed, optimizing memory.

# Interpreter

### Definition
The **Interpreter** is a behavioral design pattern that defines a representation for the grammar of a language and provides an interpreter to evaluate sentences in that language. It's commonly used for implementing Domain-Specific Languages (DSLs) where a specific problem domain is expressed in a language that the interpreter can process.

### When to Use
- When you need to define a grammar for a simple language.
- When you need to interpret sentences in that language and execute actions based on the sentences.
- In situations where new expressions need to be easily added or existing ones modified without altering the core logic of a class.

### Key Benefits
- **Flexibility**: Allows new expressions to be added easily by modifying or extending the interpreter.
- **Separation of Concerns**: Separates the parsing logic from the rest of the application, making it more maintainable.
- **Adaptability**: Useful in contexts like search queries or configuration languages, where expressions can change over time.

### Example Use Case
If you have complex search expressions that must often be evaluated, embedding them directly in your code is inflexible. The Interpreter pattern lets you represent these search expressions as sentences in a simple language, making it easy to modify or extend the search logic without changing the core class.


# Mediator

### Definition
The **Mediator** is a behavioral design pattern that centralizes communication between objects. Instead of interacting directly, objects communicate through the mediator, which coordinates their actions and reduces dependencies.

### When to Use
- When you need to coordinate interactions between multiple objects.
- To decouple objects and avoid complex direct dependencies.
- When the order of actions is important.

### Key Features
- **Centralized Coordination**: Mediator manages the communication between objects.
- **Decoupling**: Objects interact through the mediator, not directly.
- **Simplified Communication**: Reduces complex dependencies.

### Example Use Case
When multiple objects (A, B, C) need to interact, the mediator controls the sequence of actions, ensuring coordination and avoiding direct dependencies between them.

# Memento

### Definition
The **Memento** is a behavioral pattern that allows an object's state to be saved and restored without breaking encapsulation. It is commonly used for undo/redo functionality.

### When to Use
- When you need to save and restore an object's state.
- To implement undo/redo features.
- When preserving encapsulation while allowing state changes.

### Key Features
- **State Saving**: The object saves its state in a memento.
- **Encapsulation**: The internal state remains hidden.
- **Restoration**: The object restores its state from the memento.

### Example Use Case
In a text editor, the memento pattern allows saving and restoring document versions for undo/redo functionality without exposing the document's structure.

# Observer

### Definition
The **Observer** is a behavioral design pattern that establishes a one-to-many dependency, where a change in one object automatically notifies and updates all its dependent objects.

### When to Use
- When multiple objects need to be updated when one object changes.
- When you need to decouple the object that changes from the objects that depend on it.

### Key Features
- **One-to-Many Relationship**: A single object (subject) notifies multiple dependent objects (observers).
- **Automatic Updates**: Observers are automatically notified when the subject’s state changes.

### Example Use Case
In Twitter, when you follow someone, your account (Observer) is added to their follower list. Whenever they tweet, you automatically see their posts in your feed, as you're notified by the system (Observable).

# Prototype

### Definition
The **Prototype** is a creational pattern that allows you to clone a pre-configured object and modify it to fit specific needs. It helps eliminate repetitive configuration code by using an existing object as a starting point.

### When to Use
- When object creation is complex and requires predefined configurations.
- To avoid repetitive code for creating similar objects with slight modifications.

### Key Features
- **Cloning**: Objects are cloned and then adjusted to meet specific requirements.
- **Configuration Efficiency**: Saves time by using an existing object as a template.

### Example Use Case
If you need multiple instances of an object with similar configurations, you can clone a pre-configured prototype and modify it instead of creating each object from scratch.

# Proxy

### Definition
The **Proxy** pattern provides an object that controls access to another object, adding extra functionality like caching or access control.

### When to Use
- When you need to control access to an object.
- To add extra functionality (e.g., caching or validation) before interacting with the real object.
- When working with expensive resources like large objects or network connections.

### Key Features
- **Access Control**: Manages access to the real object.
- **Extra Functionality**: Adds features like caching or permission checks.
- **Transparency**: Both proxy and real object share the same interface.

### Example Use Case
A proxy can check user permissions before granting access to a sensitive resource, like a database or file.

# Singleton

Ensure a class has only one instance, and provide a global point of access to it.

# State

### Definition
The **State** pattern allows an object to change its behavior based on its internal state, avoiding large conditional statements and improving maintainability.

### When to Use
- When an object needs to change its behavior based on its internal state.
- When state-specific behavior should be defined independently, allowing flexibility in adding or modifying states.

### Key Features
- **Encapsulation**: Each state has its own class that handles state-specific behavior.
- **Delegation**: The object delegates behavior to its current state object, enabling easy state changes at runtime.

### Example Use Case
In a media player, different behaviors (play, pause, stop) can be implemented as separate state classes. The player changes its state object based on user actions, enabling it to behave differently depending on the current state.

# Strategy

### Definition
The **Strategy** pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows the algorithm to vary independently from the clients that use it.

### When to Use
- When you have multiple ways to perform an operation, and you want to allow flexibility in selecting the algorithm at runtime or design time.
- To avoid conditional statements and make it easy to switch between different algorithms.

### Key Features
- **Encapsulation**: Each algorithm is encapsulated in a separate class.
- **Interchangeability**: Clients can switch between algorithms easily at runtime.
- **Polymorphism**: The strategy pattern typically uses polymorphism to change the behavior dynamically.

### Example Use Case
In a payment system, you can have multiple payment strategies (credit card, PayPal, etc.). The user can select the payment method at runtime, and the system will use the corresponding strategy to process the payment.

# Template Method

### Definition
The **Template Method** pattern defines the structure of an algorithm in an abstract class, allowing subclasses to implement specific steps of the algorithm without changing its overall structure.

### When to Use
- When you want to define the skeleton of an algorithm, but leave some steps to be implemented by subclasses.
- To avoid code duplication by providing default behavior in a base class, while allowing specific parts to be customized.
---

### Key Features
- **Abstract Base Class**: The algorithm structure is defined in an abstract class, with some steps left for subclass implementation.
- **Tightly Coupled**: Subclasses are tightly coupled to the base class since they rely on its predefined algorithm.

### Differences from Strategy
- **Granularity**: Template Method focuses on customizing parts of an algorithm, while Strategy allows complete replacement of an algorithm.
- **Coupling**: Template Method creates tighter coupling between client and base class, whereas Strategy maintains loose coupling.

# Visitor

### Definition
The **Visitor** pattern allows adding new operations to an object structure without modifying the objects themselves.

### When to Use
- When you need to add new operations to classes without changing their code.
- When the object structure consists of many unrelated classes.

### Key Features
- **Visitor Object**: Defines operations for the object structure.
- **Accept Method**: Objects delegate operations to the visitor using `accept(visitor)`.

### Benefits
- **Extensibility**: New operations can be added via new visitors.
- **Separation of Concerns**: Operations are decoupled from the object structure.
