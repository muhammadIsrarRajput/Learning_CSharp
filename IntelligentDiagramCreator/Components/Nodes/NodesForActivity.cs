using IntelligentDiagramCreator.Components.Shapes;
using IntelligentDiagramCreator.Important;
using MindFusion.Diagramming;
using System.Drawing;

namespace IntelligentDiagramCreator.Components.Nodes
{
    internal class NodesForActivity
    {
        public static Node[] GetNodes()
        {
            //Importing Shapes to make Nodes out of them...
            Shape[] shapes = ShapesForActivity.GetShapes();
            Color defAnch = Color.Red;

            //Defining Nodes Array...
            Node[] nodes = new Node[]
            {
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(48, 25, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(48, 80, true, true, MarkStyle.Circle, defAnch),//Bottom
                        new AnchorPoint(70, 52, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(25, 52, true, true, MarkStyle.Circle, defAnch)//Left
                    }),
                    shapes[0],
                    "Start"),//=============================================================================index=0
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(50, 80, true, true, MarkStyle.Circle, defAnch),//Bottom
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)//Left
                    }),
                    shapes[1],
                    "Activity"),//=============================================================================index=1
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 20, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(50, 70, true, true, MarkStyle.Circle, defAnch),//Bottom
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)//Left
                    }),
                    shapes[2],
                    "Action"),//=============================================================================index=2
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 0, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(50, 100, true, true, MarkStyle.Circle, defAnch),//Bottom
                        new AnchorPoint(100, 50, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(0, 50, true, true, MarkStyle.Circle, defAnch)//Left
                    }),
                    shapes[3],
                    "Decision"),//=============================================================================index=3
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(30, 50, true, true, MarkStyle.Circle, defAnch),//Top Left
                        new AnchorPoint(70, 50, true, true, MarkStyle.Circle, defAnch),//Top Right
                        new AnchorPoint(50, 60, true, true, MarkStyle.Circle, defAnch)//Bottom
                    }),
                    shapes[4],
                    "Join Node"),//=============================================================================index=4
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(50, 38, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(30, 50, true, true, MarkStyle.Circle, defAnch),//Bottom Left
                        new AnchorPoint(70, 50, true, true, MarkStyle.Circle, defAnch)//Bottom Right
                    }),
                    shapes[5],
                    "Fork Node"),//=============================================================================index=5
                new Node(
                    new AnchorPattern(new AnchorPoint[]
                    {
                        new AnchorPoint(48, 25, true, true, MarkStyle.Circle, defAnch),//Top
                        new AnchorPoint(48, 80, true, true, MarkStyle.Circle, defAnch),//Bottom
                        new AnchorPoint(70, 52, true, true, MarkStyle.Circle, defAnch),//Right
                        new AnchorPoint(25, 52, true, true, MarkStyle.Circle, defAnch)//Left
                    }),
                    shapes[6],
                    "End")//=============================================================================index=6
            };
            return nodes;
        }
    }
}