using MindFusion.Diagramming;

namespace IntelligentDiagramCreator.Important
{
    internal class Connector
    {
        private Shape head;
        private string name;

        public Connector(Shape head, string name)
        {
            this.head = head;
            this.name = name;
        }

        public Shape Head
        {
            get { return head; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
