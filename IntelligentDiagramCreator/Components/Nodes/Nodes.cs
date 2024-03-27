using IntelligentDiagramCreator.Important;

namespace IntelligentDiagramCreator.Components.Nodes
{
    internal class Nodes
    {
        public Node[] SetNodes(int DiagID)
        {
            if (DiagID == 1)//Flowchart
            {
                return NodesForFlowchart.GetNodes();
            }
            else if (DiagID == 2)//Usecase Diagram
            {
                return NodesForUsecase.GetNodes();
            }
            else//Activity Diagram
            {
                return NodesForActivity.GetNodes();
            }
        }
    }
}