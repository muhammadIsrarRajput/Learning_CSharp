namespace IntelligentDiagramCreator.Description
{
    internal class ActivityDescription
    {
        public ActivityDescription() { }
        public string Start()
        {
            string str = @"In an activity diagram, the start symbol is represented by a filled-in circle or a rounded rectangle with a small, solid circle inside it. It indicates the initial point of the activity flow. The start symbol represents the beginning of a process or activity within the system being modeled.

When a control flow reaches the start symbol, it means that the activity or process depicted by the diagram is starting or initializing. The start symbol is typically connected to the first action or task in the activity diagram through an outgoing arrow or a transition line, indicating the flow of control from the start point to the subsequent steps.

The start symbol in an activity diagram serves as a reference point, providing a clear starting point for understanding the flow of activities and processes within the system. It helps to illustrate the logical sequence and order in which actions or tasks should be performed.

It's worth noting that the start symbol does not necessarily represent a specific user or system-triggered event but rather the initiation of the activity itself. It sets the stage for the subsequent steps and branches in the activity diagram, allowing for a visual representation of the flow and interactions within the system during the course of the activity.";
            return str;
        }
        public string Activity()
        {
            string str = @"In an activity diagram, the activity symbol represents a specific action, task, or behavior that occurs within a system. It is depicted as a rounded rectangle with rounded corners, and the name of the activity is written inside the rectangle.

                  The activity symbol is used to model the various steps, operations, or actions that are part of a process or workflow.It represents a unit of work that needs to be performed to achieve a particular goal or outcome. The activities can range from simple actions, such as calculations or data manipulation, to complex processes involving multiple steps and decision points.

                  Each activity in the diagram is connected by arrows or lines that depict the flow of control from one activity to another. The arrows indicate the sequence in which the activities are performed, showing the logical order of execution.

                 Within an activity symbol, additional details can be included, such as the resources or actors involved in performing the activity, the duration or time constraints, and any inputs or outputs associated with the activity.These details help provide a more comprehensive understanding of the activity being represented.

                   The activity symbol is essential for capturing the procedural aspects of a system or process.It allows analysts, designers, and stakeholders to visualize and communicate the series of steps and actions required to achieve a specific outcome.By using activity symbols and their connections, the activity diagram provides a clear representation of the flow and dependencies between different activities within a system or process.";

            return str;
        }
        public string Action()
        {
            string str = @"In an activity diagram, the action symbol represents a specific operation or behavior that is performed within an activity. It is depicted as a rectangular shape with rounded corners, and the name of the action is written inside the rectangle.

The action symbol is used to represent atomic or indivisible tasks that are executed as part of an activity. It represents a single unit of work that contributes to the overall behavior or functionality of the system being modeled.

Actions can be simple, such as calculations, data transformations, or method invocations, or they can be more complex, involving multiple steps or interactions with other objects or components. The action symbol is typically used to break down larger activities into smaller, more manageable tasks.

Each action in the diagram is connected by arrows or lines that depict the flow of control from one action to another, indicating the sequence in which the actions are performed. The arrows represent the logical order in which the actions should be executed.

Additional details can be included within an action symbol, such as the resources or objects involved in performing the action, any inputs or outputs associated with the action, and any conditions or constraints that need to be satisfied for the action to be executed.

The action symbol plays a crucial role in modeling the behavior of a system or process. It helps to break down complex activities into smaller, more understandable tasks, allowing for a more detailed representation of the system's behavior. By connecting the action symbols and organizing them in a logical sequence, the activity diagram provides a visual depiction of how actions are performed and how control flows between them.";
            return str;
        }
        public string Decision()
        {
            string str = @"In an activity diagram, the decision symbol represents a point where the flow of control branches based on a condition or decision. It is depicted as a diamond-shaped symbol with one incoming arrow and two or more outgoing arrows.

The decision symbol is used to model a decision point within an activity, where the system or actor needs to make a choice between different paths or actions based on certain conditions or criteria. The condition that determines the branching is usually written inside or near the decision symbol.

When the control flow reaches a decision symbol, the condition associated with it is evaluated, and based on the result, the flow is directed along one of the outgoing arrows. Each outgoing arrow represents a different possible outcome or path that the activity can take.

The decision symbol enables the modeling of branching behavior within an activity, allowing for multiple alternative paths to be represented. It represents a point where the system or actor needs to make a decision or choose between different options, and the flow of control is determined by the evaluation of the condition associated with the decision symbol.

The decision symbol can have multiple outgoing arrows, each labeled with a condition or a constraint that represents a specific branch or path. This allows for modeling complex decision structures with multiple conditions and alternative flows within the activity diagram.

By incorporating decision symbols in an activity diagram, the logic and decision-making aspects of a system or process can be clearly represented, providing a visual understanding of how different paths are taken based on specific conditions or choices.";
            return str;
        }
        public string JoinNode()
        {
            string str = @" The join node is represented by a small square box with multiple incoming arrows and one outgoing arrow. It indicates that multiple branches or flows need to converge at this point before the activity can proceed along the outgoing arrow.

When control flow reaches a join node, it means that the paths leading to the join node must be completed or reached in order for the activity to continue along the outgoing arrow. In other words, the join node waits for all incoming flows to arrive before it proceeds with the next step.

The join node is often used in combination with fork nodes, which represent the creation of parallel flows, to model concurrent or parallel execution paths within the activity diagram. The fork nodes split the flow into multiple paths, and the join nodes bring these paths back together.

The join node helps ensure that all necessary prerequisites or conditions are met before the subsequent activity or task can be executed. It allows for synchronization and coordination of parallel activities or paths within the diagram.

By incorporating join nodes in an activity diagram, it becomes possible to model scenarios where multiple activities or branches need to synchronize or converge before proceeding. This helps to capture complex flows and dependencies in the system being represented by the activity diagram.
outgoing arrows. It signifies that the flow of control is divided into multiple paths at that particular point in the activity diagram.
";
            return str;
        }
        public string ForkNode()
        {
            string str = @"In an activity diagram, a fork node is used to represent the splitting of control flow into multiple concurrent or parallel paths. It indicates that multiple activities or tasks can be executed simultaneously or independently of each other.

The fork node is represented by a small black bar or line, often with a single incoming arrow and multiple outgoing arrows. It signifies that the flow of control is divided into multiple paths at that particular point in the activity diagram.

When control flow reaches a fork node, it means that the activities following the fork can be executed concurrently or in parallel. Each outgoing arrow from the fork node represents a separate path or activity that can be pursued independently.

The fork node is typically used in combination with join nodes, which represent the merging of parallel paths, to model concurrent execution or synchronization within the activity diagram.

By using fork nodes, complex processes or activities can be represented in a more intuitive and visual manner, allowing for the depiction of parallelism and concurrency within a system. It helps to capture scenarios where multiple activities or tasks can occur simultaneously, enhancing the understanding of the overall flow of the system being modeled.

In summary, the fork node in an activity diagram represents the splitting of control flow into multiple concurrent or parallel paths, enabling the modeling of parallel execution and independent activities within the system.";
            return str;
        }
        public string End()
        {
            string str = @"In an activity diagram, the end symbol represents the termination or completion of an activity or process. It indicates the endpoint of the activity flow and signifies that the activity has reached its conclusion.

The end symbol is typically depicted as a circle with a solid border, often labeled with the word ""end"" or a similar identifier inside the circle.

When the control flow reaches the end symbol, it indicates that the activity or process depicted by the diagram has finished or reached its desired state. It represents the point where the activity flow comes to a halt, and no further actions or steps are performed.

The end symbol is usually connected to the preceding activities or decision points through incoming arrows or transition lines, illustrating the flow of control leading up to the end of the activity.

The presence of the end symbol in an activity diagram is crucial for providing a clear and unambiguous indication of the completion of an activity or process. It helps in visually representing the logical conclusion or final state of the system being modeled.

It's important to note that an activity diagram can have multiple end symbols to represent different possible outcomes or termination points within the activity flow. These different end symbols can be labeled to indicate specific results or conditions under which the activity concludes.";
            return str;
        }

    }
}
