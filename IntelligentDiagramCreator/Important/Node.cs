using MindFusion.Diagramming;

namespace IntelligentDiagramCreator.Important
{
    internal class Node
    {
        private AnchorPattern anchor;
        private Shape template;
        private string name;
        private Node n;

        public Node(AnchorPattern anchor, Shape template, string name)
        {
            this.anchor = anchor;
            this.template = template;
            this.name = name;
        }

        public Node(Node n)
        {
            this.n = n;
        }

        public AnchorPattern Anchor
        {
            get { return anchor; }
        }

        public Shape Template
        {
            get { return template; }
        }

        public string Name
        {
            get { return name; }
        }
    }
}
