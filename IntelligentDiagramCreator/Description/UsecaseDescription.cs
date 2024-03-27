namespace IntelligentDiagramCreator.Description
{
    internal class UsecaseDescription
    {
        public UsecaseDescription() { }

        public string UsecaseBox()
            {
                string str = @"In a use case diagram, the Use Case Box represents the boundary that encapsulates the system under consideration and defines its scope. It visually represents the functions or actions that the system performs to interact with its actors (users, external systems, or other entities).

The Use Case Box is typically a rectangle that contains the use cases, which are represented by ovals or ellipses within the box. Each use case describes a specific functionality or behavior of the system from the perspective of an actor.

The Use Case Box provides a high-level overview of the system's features and interactions, helping to identify the main use cases and actors involved. It serves as a visual representation of the system's boundaries and the functionalities it offers to its users.

In addition to use cases, the Use Case Box may also include system boundaries, actors, and relationships between actors and use cases. The relationships between the actors and use cases are typically represented by lines with arrows indicating the direction of interaction.

Overall, the Use Case Box in a use case diagram provides a concise representation of the system's functionalities, its interactions with actors, and the overall scope of the system being modeled.";
                return str;
            }

        public string Actor()
            {
                string str = @"In a use case diagram, an actor represents an entity that interacts with the system being modeled. An actor can be a person, another system, or an external entity that interacts with the system to accomplish a specific goal.

Actors are depicted as stick figures or other symbols outside the system boundary, usually on the left-hand side of the diagram. They are connected to the use cases by lines, indicating the interactions and relationships between the actor and the system.

Actors in a use case diagram are not limited to individuals directly involved in the system's development or operation. They can represent various roles or personas that interact with the system, such as users, administrators, external systems, or even hardware devices.

Actors play a crucial role in identifying the system's requirements and defining the use cases. They initiate the interactions with the system by triggering or participating in use cases, and they receive the system's responses or outputs.

By including actors in a use case diagram, it becomes possible to visualize and understand the different external entities and their roles in the system's functionality. This helps in capturing the system's external view and ensures that the system's requirements align with the needs of its users and stakeholders.";
                return str;
            }

        public string Usecase()
            {
            string str = @"In a use case diagram, a Use Case represents a specific functionality or behavior that a system provides to its users (actors). It describes a set of interactions between the system and its users to achieve a specific goal.

A Use Case is typically depicted as an oval or ellipse in the diagram and is labeled with a descriptive name. It represents a discrete unit of functionality that provides value to the users or helps achieve a specific objective within the system.

Use cases capture the external view of the system, focusing on what the system does rather than how it does it. They represent the system's actions from the perspective of the actors involved, showcasing the main tasks or functions that the system supports.

Each Use Case may have associated actors, which are entities that interact with the system to perform the use case. Actors can be users, other systems, devices, or any external entity that interacts with the system.

Use cases can be connected to actors or other use cases through relationships, which illustrate the dependencies and interactions between different elements of the system.

In summary, a Use Case in a use case diagram represents a specific functionality or behavior of the system that is of interest to its users. It helps provide a clear understanding of the system's purpose and how it interacts with its actors to fulfill their needs or accomplish certain goals.";
                return str;
            }

        }
    }

