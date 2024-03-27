using IntelligentDiagramCreator.Components.Shapes;
using IntelligentDiagramCreator.Important;
using MindFusion.Diagramming;
using System.Drawing;

namespace IntelligentDiagramCreator.Components.Nodes
{
    internal class NodesForFlowchart
    {
        public static Node[] GetNodes()
        {
            //Importing Shapes to make Nodes out of them...
            Shape[] shapes = ShapesForFlowchart.GetShapes();
            Color defAnch = Color.Red;

            //Defining Nodes Array...
            Node[] nodes = new Node[]
            {
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Cross, defAnch),//Top
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 80, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[0],
                    "Start"),//=============================================================================index=0
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(94, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(7, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 78, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[1],
                    "Input"),//=============================================================================index=1
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 80, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[2],
                    "Process"),//=============================================================================index=2
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[3],
                    "Decision"),//=============================================================================index=3
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[4],
                    "Loop"),//=============================================================================index=4
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 35, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(65, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(35, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 65, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[5],
                    "Connector"),//=============================================================================index=5
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(94, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(7, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 78, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[6],
                    "Output"),//=============================================================================index=6
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch),//Left
                        new AnchorPoint(50, 80, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[7],
                    "End")//=============================================================================index=7
            };
            return nodes;
        }
    }
}