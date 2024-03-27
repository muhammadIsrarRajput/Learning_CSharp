using MindFusion.Diagramming;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace IntelligentDiagramCreator.Components.Shapes
{
    internal class ShapesForActivity
    {
        public static Shape[] GetShapes()
        {
            //Defining Shapes Array...
            Shape[] shapes = new Shape[]
            {
                new Shape(
                    new ElementTemplate[]
                    {
                        new ArcTemplate(25, 25, 45, 55, 0f, 360f, Color.Black, DashStyle.Solid, -1)//Circular Arc
                    },
                    FillMode.Winding,
                    "Start"),//=============================================================================index=0
                new Shape(
                    new ElementTemplate[]
                    {
                        new RoundRectangleTemplate(0, 20, 100, 60, 6f, Color.Black, DashStyle.Solid, -1)//Rectangle
                    },
                    FillMode.Winding,
                    "Activity"),//=============================================================================index=1
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(0, 20, 100, 20, Color.Black, DashStyle.Solid, -1),//Top
                        new LineTemplate(100, 20, 100, 70, Color.Black, DashStyle.Solid, -1),//Right
                        new LineTemplate(100, 70, 0, 70, Color.Black, DashStyle.Solid, -1),//Bottom
                        new LineTemplate(0, 70, 0, 20, Color.Black, DashStyle.Solid, -1)//Left
                    },
                    FillMode.Winding,
                    "Action"),//=============================================================================index=2
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(50, 0, 100, 50, Color.Black, DashStyle.Solid, -1),//Top Right
                        new LineTemplate(100, 50, 50, 100, Color.Black, DashStyle.Solid, -1),//Bottom Right
                        new LineTemplate(50, 100, 0, 50, Color.Black, DashStyle.Solid, -1),//Bottom Left
                        new LineTemplate(0, 50, 50, 0, Color.Black, DashStyle.Solid, -1)//Top Left
                    },
                    FillMode.Winding,
                    "Decision"),//=============================================================================index=3
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(100, 50, 100, 60, Color.Black, DashStyle.Solid, -1),//Right
                        new LineTemplate(100, 60, 50, 60, Color.Black, DashStyle.Solid, -1),//Bottom
                        new LineTemplate(50, 60, 0, 60, Color.Black, DashStyle.Solid, -1),//Top
                        new LineTemplate(0, 60, 0, 50, Color.Black, DashStyle.Solid, -1)//Left
                    },
                    FillMode.Winding,
                    "Join Node"),//=============================================================================index=4
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(0, 40, 50, 40, Color.Black, DashStyle.Solid, -1),//Top
                        new LineTemplate(50, 40, 100, 40, Color.Black, DashStyle.Solid, -1),//Bottom
                        new LineTemplate(100, 40, 100, 50, Color.Black, DashStyle.Solid, -1),//Right
                        new LineTemplate(0, 50, 0, 40, Color.Black, DashStyle.Solid, -1)//Left
                    },
                    FillMode.Winding,
                    "Fork Node"),//=============================================================================index=5
                new Shape(
                    new ElementTemplate[]
                    {
                        new ArcTemplate(25, 25, 45, 55, 0f, 360f, Color.Black, DashStyle.Solid, -1),//Circular Arc
                        new ArcTemplate(29, 29, 37, 47, 0f, 360f, Color.Black, DashStyle.Solid, -1)//Circular Arc
                    },
                    FillMode.Winding,
                    "End")
            };
            return shapes;
        }
    }
}