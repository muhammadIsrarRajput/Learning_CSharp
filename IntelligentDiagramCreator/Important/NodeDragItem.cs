using System;

namespace IntelligentDiagramCreator.Important
{
    internal class NodeDragItem
    {
        private int index;

        public NodeDragItem(int index)
        {
            this.index = index;
        }

        public static Type Get_Type()
        {
            return new NodeDragItem(0).GetType();
        }

        public int Index
        {
            get { return index; }
        }
    }
}
