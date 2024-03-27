using System.Drawing;
using System.Web.UI.WebControls;

namespace IntelligentDiagramCreator.Important
{
    internal class NodeProps
    {
        private string text;
        private Font font;
        private Color fillColor;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public Font Font
        {
            get { return font; }
            set { font = value; }
        }

        public Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

    }
}
