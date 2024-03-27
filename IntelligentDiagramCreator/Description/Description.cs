namespace IntelligentDiagramCreator.Description
{
    internal class Description
    {
        public Description() { }

        public string IDC()
        {
            string str = @"The system is an offline desktop application for Windows, Linux, and Mac OS that uses UML diagrams and Flowcharts to specify, visualize, and construct software systems. It aims to help software engineering students and developers quickly understand the system and save time in meetings by giving stakeholders an overview of the system. The application will be free of cost and does not require registration or an internet connection. Users can import/export files in different formats such as PDF, PNG, and JPG/JPEG. Additionally, the application generates pseudo-code from the flowchart, making it easier for students and developers to generate code for their projects. Overall, the system provides a comprehensive and user-friendly solution for software development.";
            return str;
        }
        public string Flowchart()
        {
            string str = @"A flowchart is a graphical representation of a process or algorithm, which uses various symbols to depict the steps involved in the process. It is a powerful tool for visualizing and understanding the logic of a program or system. Flowcharts can be used to analyze, design, document, and improve various types of processes and systems.

Flowcharts consist of various shapes and symbols, each representing a different type of step or decision in the process. The most commonly used flowchart symbols are:

Start and End symbols: These are used to indicate the beginning and end of a process.
Process symbols: These represent a step in the process, such as a calculation, data entry, or other action.
Decision symbols: These are used to represent a decision point in the process, such as a yes/no question or a branching condition.
Connector symbols: These are used to connect different parts of the flowchart, indicating the flow of the process.
Input/Output symbols: These are used to represent data input or output in the process.
To create a flowchart, you start by identifying the key steps involved in the process and then use the appropriate symbols to represent each step. You then connect the symbols using arrows to show the flow of the process. Decision points are represented by diamond-shaped symbols, and the arrows coming out of them show the possible paths the process can take based on the decision.

Flowcharts are an excellent tool for understanding the code flow of a program, especially in complex systems where there are multiple possible paths that the program can take. By creating a flowchart of the program, you can see the entire code flow at a glance, which can help you identify potential errors, bottlenecks, or areas for optimization. Flowcharts can also be used to document the code flow, making it easier for other developers to understand and modify the program.

In conclusion, a flowchart is an essential tool for understanding the code flow of a program. It provides a visual representation of the steps involved in the process and the possible paths the program can take. Flowcharts can be used to analyze, design, document, and improve various types of processes and systems. By creating a flowchart of your program, you can better understand its logic and identify areas for improvement.";
            return str;
        }

        public string Usecase()
        {
            string str = @"
A UML (Unified Modeling Language) use case diagram is a type of diagram used in software development to visually represent the interactions between actors (users or other systems) and a system or application. Use case diagrams are an important tool for understanding and documenting the functional requirements of a system, and are often used early in the development process to identify and prioritize use cases.

In a use case diagram, use cases are represented as ovals, and actors are represented as stick figures. Lines connecting the actors and use cases show the relationships between them. Typically, the use cases are organized into systems, which are represented by rectangles that enclose the related use cases.

Use case diagrams are useful for several purposes:

Requirements gathering: Use case diagrams can be used to gather and document the functional requirements of a system or application. By identifying the actors and use cases, developers can understand the scope of the system and the interactions it will have with external entities.

Communication: Use case diagrams can be used to communicate the functional requirements of a system to stakeholders, including users, managers, and developers. By presenting the interactions between actors and use cases in a clear and simple format, use case diagrams can help ensure that everyone involved in the project has a shared understanding of the system.

Analysis: Use case diagrams can be used to analyze the behavior of a system and identify areas where improvements can be made. By examining the interactions between actors and use cases, developers can identify potential bottlenecks or areas of inefficiency.

Testing: Use case diagrams can be used to create test cases and scenarios, which can be used to validate that the system is working as expected. By creating a comprehensive set of test cases based on the use cases, developers can ensure that the system is tested thoroughly and accurately.

In summary, a UML use case diagram is a valuable tool for understanding the interactions between actors and a system or application. By using use case diagrams early in the development process, developers can ensure that the functional requirements of the system are understood and documented, and that stakeholders have a shared understanding of the system.";
            return str;
        }

        public string Activity()
        {
            string str = @"A UML activity diagram is a graphical representation of the workflow or process flow of a system or process. It is a visual representation of the steps that a system or process goes through to complete a task or achieve a goal.

Activity diagrams are similar to flowcharts, but they have a more formalized structure and notation. They are used to model business processes, software workflows, and other processes in which the steps are sequential and need to be understood by multiple stakeholders.

In an activity diagram, there are several elements that make up the structure. The basic building blocks of an activity diagram are actions, transitions, control flows, and objects.

Actions represent individual steps in the process, while transitions represent the connections between the steps. Control flows are used to show the order in which the steps are executed, while objects represent the actors or entities involved in the process.

Activity diagrams also include various symbols and notations to represent specific aspects of the process, such as decision points, loops, and parallel flows.

The main purpose of an activity diagram is to provide a clear, visual representation of the steps involved in a process or system. This helps stakeholders to understand the process more easily, identify potential issues or inefficiencies, and make improvements to the process.

Overall, the UML activity diagram is a powerful tool for modeling and understanding complex processes, and it is commonly used in a wide range of industries, from software development to manufacturing to business management.";
            return str;
        }

        public string Sequence()
        {
            string str = @"A UML sequence diagram is a graphical representation of the interactions between objects or components in a system or process. It is used to visualize how objects communicate with each other and how the messages are passed between them.

The sequence diagram is composed of a vertical axis representing time and a horizontal axis representing the objects or components in the system. Each object is represented by a rectangle called a lifeline, and the messages between objects are represented by arrows connecting the lifelines.

The messages exchanged between the objects can be synchronous or asynchronous. Synchronous messages are those that require an immediate response, while asynchronous messages do not require an immediate response and can be processed later.

Sequence diagrams can also include additional notations, such as conditions, loops, and iterations, to represent more complex scenarios. For example, a loop notation can be used to represent a repeated sequence of messages between objects.

The main purpose of a sequence diagram is to provide a visual representation of the interactions between objects in a system or process. This helps stakeholders to understand the flow of the system, identify potential issues or bottlenecks, and make improvements to the system.

Overall, the UML sequence diagram is a powerful tool for modeling and understanding complex systems, and it is commonly used in a wide range of industries, from software development to telecommunications to healthcare. It is particularly useful for systems that involve multiple objects or components that interact with each other in a specific order.";
            return str;
        }

        public string Class()
        {
            string str = @"A UML class diagram is a type of static structure diagram that represents the structure of a system by showing the classes, their attributes, methods, and the relationships between them. It is commonly used in object-oriented programming (OOP) to visualize the relationships between classes in a software system.

The class diagram consists of a collection of classes, interfaces, and their relationships. Each class is represented as a rectangle, with the class name at the top, followed by the attributes (data members) and methods (member functions) in the middle and bottom of the rectangle, respectively.

The relationships between classes are shown as lines connecting the classes. These relationships can be of several types, including inheritance, association, aggregation, and composition.

Inheritance is a relationship between a superclass (parent class) and a subclass (child class), where the subclass inherits the attributes and methods of the superclass. This relationship is represented as a solid line with a closed arrowhead pointing to the superclass.

Association is a relationship between two or more classes, where one class uses or is connected to another class. This relationship is represented as a line with an arrowhead pointing to the used class.

Aggregation is a relationship between two classes, where one class contains or is a part of another class. This relationship is represented as a line with a diamond-shaped open arrowhead pointing to the contained class.

Composition is a more specific form of aggregation, where the contained class cannot exist without the containing class. This relationship is represented as a line with a filled diamond-shaped arrowhead pointing to the contained class.

The UML class diagram is a powerful tool for modeling and designing complex software systems. It provides a visual representation of the structure of a system and the relationships between its components, which can help developers to identify potential design flaws and improve the overall quality of the system.";
            return str;
        } 

        public string Component()
        {
            string str = @"A UML Component Diagram is a type of structural diagram in the Unified Modeling Language (UML) that describes the organization and dependencies of components in a software system. A component is a modular unit of software that can be easily replaceable, reusable, and encapsulated. The component diagram shows the relationships among components, interfaces, and ports in a system.

In a component diagram, each component is represented as a rectangle with its name inside. A component can have one or more interfaces, which are shown as small rectangles at the edge of the component. The interfaces define the communication between components. A component can also have one or more ports, which are represented as small squares on the edge of the component. Ports provide a way for components to interact with the external environment.

The component diagram shows how components are connected to each other through their interfaces. The interfaces define the services that a component provides or requires. The connections between components are shown as lines with arrows, indicating the direction of communication. The lines can also have labels that describe the type of connection, such as ""uses"" or ""implements"".

In addition to components, the component diagram can also include artifacts, which are physical files or software modules that are used to implement the components. Artifacts are represented as rectangles with a small icon in the corner.

The component diagram is useful for understanding the architecture of a system and identifying the components and interfaces that make up the system. It is also useful for identifying potential areas for reuse and for managing the dependencies between components. The component diagram can be used in the early stages of software development to create a high-level view of the system architecture, and can be refined as the design progresses.";
            return str;
        }
    }
}
