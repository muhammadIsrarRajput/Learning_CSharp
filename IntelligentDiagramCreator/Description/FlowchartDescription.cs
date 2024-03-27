namespace IntelligentDiagramCreator.Description
{
    internal class FlowchartDescription
    {
        public FlowchartDescription() { }

        public string Start()
        {
            string str = @"The ""Start"" symbol is one of the fundamental symbols used in flowcharts to represent the beginning of a process or program. It is typically represented as a rounded rectangle with the word ""Start"" written inside it. The symbol indicates the starting point of the flowchart and the initiation of the process or program.

The ""Start"" symbol is typically followed by a series of other symbols that represent the steps and decisions in the process or program. These symbols are connected by arrows to show the flow and direction of the process. The ""Start"" symbol is essential to the structure and organization of the flowchart, as it establishes the beginning point and sets the stage for the rest of the chart.

In software development, the ""Start"" symbol is often used to represent the initialization of a program or the beginning of a specific function within the program. It can be used to show the user the starting point of the process and provide guidance on the steps that follow. The ""Start"" symbol is an essential component of any flowchart and helps to make the diagram easy to understand and follow.";
            return str;
        }
        public string Input()
        {
            string str = @"The ""Input"" symbol in flowchart represents the action of receiving data from an external source, such as a user or a file. It is used to indicate the start of a process that requires input from the user or from a data source. The Input symbol is represented by a parallelogram shape with the word ""Input"" inside.

In practical terms, the Input symbol can be used to represent any type of data input, such as text, numbers, or other types of data. When using the Input symbol in a flowchart, it is important to indicate the source of the data input, such as a user input field or a file input location.

The Input symbol is usually followed by a processing symbol in the flowchart, which represents the action that is taken with the input data. The processing symbol can perform calculations, manipulate the input data, or perform other actions based on the input data. Overall, the Input symbol is an important component of a flowchart that represents the initial input stage of a process or algorithm.";
            return str;
        }
        public string Process()
        {
            string str = @"The ""Process"" symbol is one of the basic symbols used in a flowchart to represent a specific task or action that needs to be executed as part of a process. It is usually represented as a rectangle with rounded corners. The rectangle is divided into two parts, with the top part containing the name of the process and the bottom part containing a brief description of the task.

In a flowchart, the ""Process"" symbol is used to indicate a step in a process that requires some action to be performed. The action can be anything from simple arithmetic calculations, data manipulation, decision-making, or any other type of operation that needs to be performed to achieve the desired result.

The ""Process"" symbol is a versatile symbol and can be used to represent any type of operation, regardless of its complexity. It can also be used to represent a sub-process or a group of related tasks that need to be performed as part of a larger process.

Overall, the ""Process"" symbol is a fundamental building block of flowcharts and plays a critical role in representing the steps involved in a process in a clear and concise manner.";
            return str;
        }
        public string Decision()
        {
            string str = @"The decision symbol in a flowchart is a key component that represents a decision point or branching in a process. It is typically represented by a diamond-shaped box. The purpose of the decision symbol is to indicate that the flow of the process can take different paths based on a specific condition or criteria.

The content within the decision symbol usually includes a question or a condition that needs to be evaluated. It can be a simple yes/no question, a true/false condition, or any other logical condition that determines the subsequent path of the process.

Inside the decision symbol, the flowchart designer may use arrows or lines to connect the decision symbol to the various paths that can be taken based on the outcome of the condition. Typically, one path leads to the next step or action if the condition is true, while the other path leads to a different step or action if the condition is false.";
            return str;
        }
        public string Connector()
        {
            string str = @"The connector symbol, also known as an off-page connector or reference symbol, is used in flowcharts to connect different parts of a diagram that are located on different pages or sections. Its purpose is to indicate that the flow continues elsewhere in the flowchart.

The content of a connector symbol is typically a label or identifier that corresponds to a specific location in the flowchart where the flow continues. The label is used to reference the destination page or section where the flowchart continues from that point.

Connector symbols are represented by small circles or rectangles with a letter or number inside to distinguish them from each other. They are usually placed at the edge of a page or diagram, and a corresponding connector symbol with the same label is placed at the start of the flow on the destination page.";
            return str;
        }
        public string Output()
        {
            string str = @"The output symbol in a flowchart represents the display or presentation of information, results, or output to the user or system. It is used to indicate the point where the process generates output data that can be seen, recorded, or used for further processing.

The content within the output symbol typically describes the type or nature of the output being produced. This could include printed text, displayed information on a screen, a generated report, a file saved to a specific location, or any other form of output relevant to the process being depicted in the flowchart.

The output symbol is usually represented by a parallelogram-shaped box. It is placed in the flowchart at the point where the output is produced, often after a calculation, decision, or series of operations have been performed.

The purpose of the output symbol is to clearly indicate the outcome or result of the process to the user or system. It serves as a visual representation of where the information produced by the process is directed or made available.";
            return str;
        }
        public string End()
        {
            string str = @"The end symbol, also known as the termination symbol, is used in a flowchart to represent the conclusion or termination of a process or program. It indicates the point where the flowchart or program comes to an end, and no further actions or operations are performed.

The content within the end symbol is typically minimal, often just a label or identifier such as ""End"" or ""Stop."" It serves as a visual indicator that the process has reached its final stage and is complete.

The end symbol is represented by a rounded rectangle or oval shape, which differentiates it from other symbols in the flowchart. It is usually placed at the bottom or rightmost side of the flowchart to indicate the logical end point of the process.

When the flow of the process reaches the end symbol, it signifies that the task or program has finished executing, and the flowchart reader can understand that there are no further steps or actions to be taken.

It is important to note that the end symbol doesn't necessarily mean the entire process has completed in a real-world scenario. It simply signifies the end of the particular flowchart or program being depicted.";
            return str;
        }
    }
}
