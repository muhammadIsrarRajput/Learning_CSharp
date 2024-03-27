using MindFusion.Diagramming;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace IntelligentDiagramCreator.Components.Shapes
{
    internal class ShapesForFlowchart
    {
        public static Shape[] GetShapes()
        {
            //Defining Shapes Array...
            Shape[] shapes = new Shape[]
            {
                new Shape(
                    new ElementTemplate[]
                    {
                        new RoundRectangleTemplate(0, 20, 100, 60, 6f, Color.Black, DashStyle.Solid, -1)//Rectangle
                    },
                    FillMode.Winding,
                    "Start"),//=============================================================================index=0
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(14, 20, 102, 20, Color.Black, DashStyle.Solid, -1),//Top
                        new LineTemplate(102, 20, 86, 78, Color.Black, DashStyle.Solid, -1),//Right
                        new LineTemplate(0, 78, 14, 20, Color.Black, DashStyle.Solid, -1),//Left
                        new LineTemplate(86, 78, 0, 78, Color.Black, DashStyle.Solid, -1)//Bottom
                    },
                    FillMode.Winding,
                    "Input"),//=============================================================================index=1
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(0, 20, 100, 20, Color.Black, DashStyle.Solid, -1),//Top
                        new LineTemplate(100, 20, 100, 80, Color.Black, DashStyle.Solid, -1),//Right
                        new LineTemplate(0, 80, 0, 20, Color.Black, DashStyle.Solid, -1),//Left
                        new LineTemplate(100, 80, 0, 80, Color.Black, DashStyle.Solid, -1)//Bottom
                    },
                    FillMode.Winding,
                    "Process"),//=============================================================================index=2
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
                        new LineTemplate(50, 0, 100, 50, Color.Black, DashStyle.Solid, -1),//Top Right
                        new LineTemplate(100, 50, 50, 100, Color.Black, DashStyle.Solid, -1),//Bottom Right
                        new LineTemplate(50, 100, 0, 50, Color.Black, DashStyle.Solid, -1),//Bottom Left
                        new LineTemplate(0, 50, 50, 0, Color.Black, DashStyle.Solid, -1)//Top Left
                    },
                    FillMode.Winding,
                    "Loop"),//=============================================================================index=4
                new Shape(
                    new ElementTemplate[]
                    {
                        new ArcTemplate(35, 35, 30, 30, 0f, 360f, Color.Black, DashStyle.Solid, -1)//Circular Arc
                    },
                    FillMode.Winding,
                    "Connector"),//=============================================================================index=5
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(14, 20, 102, 20, Color.Black, DashStyle.Solid, -1),//Top
                        new LineTemplate(102, 20, 86, 78, Color.Black, DashStyle.Solid, -1),//Right
                        new LineTemplate(0, 78, 14, 20, Color.Black, DashStyle.Solid, -1),//Left
                        new LineTemplate(86, 78, 0, 78, Color.Black, DashStyle.Solid, -1)//Bottom
                    },
                    FillMode.Winding,
                    "Output"),//=============================================================================index=6
                new Shape(
                    new ElementTemplate[]
                    {
                        new RoundRectangleTemplate(0, 20, 100, 60, 6f, Color.Black, DashStyle.Solid, -1)//Rectangle
                    },
                    FillMode.Winding,
                    "End")//=============================================================================index=7
            };
            return shapes;
        }
    }
}