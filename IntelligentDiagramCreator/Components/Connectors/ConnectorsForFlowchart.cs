using IntelligentDiagramCreator.Important;
using MindFusion.Diagramming;

namespace IntelligentDiagramCreator.Components.Connectors
{
    internal class ConnectorsForFlowchart
    {
        public static Connector[] GetConnectors()
        {
            //Defining Connectors Array...
            Connector[] connectors = new Connector[]
            {
                new Connector(
                    ArrowHeads.Arrow,
                    "Flow Line"),
                new Connector(
                    ArrowHeads.Arrow,
                    "True (Case)"),
                new Connector(
                    ArrowHeads.Arrow,
                    "False (Case)")
            };
            return connectors;
        }
    }
}