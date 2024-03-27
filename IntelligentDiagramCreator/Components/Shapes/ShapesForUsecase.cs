using MindFusion.Diagramming;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace IntelligentDiagramCreator.Components.Shapes
{
    internal class ShapesForUsecase
    {
        public static Shape[] GetShapes()
        {
            //Defining Shapes Array...
            Shape[] shapes = new Shape[]
            {
                new Shape(
                    new ElementTemplate[]
                    {
                        new LineTemplate(0, 0, 100, 0, Color.Black, DashStyle.Solid, -1),//Top
                        new LineTemplate(100, 0, 100, 100, Color.Black, DashStyle.Solid, -1),//Right
                        new LineTemplate(0, 100, 0, 0, Color.Black, DashStyle.Solid, -1),//Left
                        new LineTemplate(100, 100, 0, 100, Color.Black, DashStyle.Solid, -1)//Bottom
                    },
                    FillMode.Winding,
                    "Usecase Box"),//=============================================================================index=0
                new Shape(
                    new ElementTemplate[]
                    {
                        new ArcTemplate(40, 0, 20, 20, 90f, 360f, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(50, 20, 70, 20, Color.Black, DashStyle.Solid, -1),
                        new ArcTemplate(65, 20, 10, 10, 270f, 90f, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(75, 25, 75, 60, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(75, 60, 68, 60, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(68, 60, 68, 30, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(68, 30, 64, 30, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(64, 30, 64, 100, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(64, 100, 52, 100, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(52, 100, 52, 65, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(52, 65, 48, 65, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(48, 65, 48, 100, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(48, 100, 36, 100, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(36, 100, 36, 30, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(36, 30, 32, 30, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(32, 30, 32, 60, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(32, 60, 25, 60, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(25, 60, 25, 25, Color.Black, DashStyle.Solid, -1),
                        new ArcTemplate(25, 20, 10, 10, 180f, 90f, Color.Black, DashStyle.Solid, -1),
                        new LineTemplate(30, 20, 50, 20, Color.Black, DashStyle.Solid, -1)
                    },
                    FillMode.Winding,
                    "Actor"),//=============================================================================index=1
                new Shape(
                    new ElementTemplate[]
                    {
                        new ArcTemplate(0, 20, 100, 60, 0f, 360f, Color.Black, DashStyle.Solid, -1)//Circular Arc
                    },
                    FillMode.Winding,
                    "Usecase")//=============================================================================index=2
            };
            return shapes;
        }
    }
}