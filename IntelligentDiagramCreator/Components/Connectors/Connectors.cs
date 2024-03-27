using IntelligentDiagramCreator.Important;

namespace IntelligentDiagramCreator.Components.Connectors
{
    internal class Connectors
    {
        public Connector[] SetConnectors(int DiagID)
        {
            if (DiagID == 1)//Flowchart
            {
                return ConnectorsForFlowchart.GetConnectors();
            }
            else if (DiagID == 2)//Usecase Diagram
            {
                return ConnectorsForUsecase.GetConnectors();
            }
            else//Activity Diagram
            {
                return ConnectorsForActivity.GetConnectors();
            }
        }
    }
}