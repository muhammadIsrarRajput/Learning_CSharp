using IntelligentDiagramCreator.Components.Shapes;
using IntelligentDiagramCreator.Important;
using MindFusion.Diagramming;
using System.Drawing;

namespace IntelligentDiagramCreator.Components.Nodes
{
    internal class NodesForUsecase
    {
        public static Node[] GetNodes()
        {
            //Importing Shapes to make Nodes out of them...
            Shape[] shapes = ShapesForUsecase.GetShapes();
            Color defAnch = Color.Red;

            //Defining Nodes Array...
            Node[] nodes = new Node[]
            {
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        //Because UseCase box have no connection points. Its just represent system.
                    }),
                    shapes[0],
                    "UseCase Box"),//=============================================================================index=0
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),
                        new AnchorPoint(75, 30, true, true, MarkStyle.Circle, defAnch),
                        new AnchorPoint(25, 30, true, true, MarkStyle.Circle, defAnch),
                        new AnchorPoint(75, 60, true, true, MarkStyle.Circle, defAnch),
                        new AnchorPoint(25, 60, true, true, MarkStyle.Circle, defAnch),
                        new AnchorPoint(65, 80, true, true, MarkStyle.Circle, defAnch),
                        new AnchorPoint(35, 80, true, true, MarkStyle.Circle, defAnch),
                        new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch)
                    }),
                    shapes[1],
                    "Actor"),//=============================================================================index=1
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 80, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[2],
                    "Usecase")//=============================================================================index=2
            };
            return nodes;
        }
    }
}