using IntelligentDiagramCreator.Important;
using MindFusion.Diagramming;

namespace IntelligentDiagramCreator.Components.Connectors
{
    internal class ConnectorsForActivity
    {
        public static Connector[] GetConnectors()
        {
            //Defining Connectors Array...
            Connector[] connectors = new Connector[]
            {
                new Connector(
                    ArrowHeads.Arrow,
                    "Arrow"),
                new Connector(
                    ArrowHeads.None,
                    "None"),
                new Connector(
                    ArrowHeads.Triangle,
                    "Triangle")
            };
            return connectors;
        }
    }
}