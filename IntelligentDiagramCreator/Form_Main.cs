using IntelligentDiagramCreator.Components.Connectors;
using IntelligentDiagramCreator.Components.Nodes;
using IntelligentDiagramCreator.Description;
using IntelligentDiagramCreator.Important;
using MindFusion.Diagramming;
using MindFusion.Diagramming.Commands;
using MindFusion.Drawing;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using SolidBrush = MindFusion.Drawing.SolidBrush;

namespace IntelligentDiagramCreator
{
    public partial class Form_Main : Form
    {
        //====================================================================================
        //Data Variables
        //====================================================================================
        private int Diagram_ID;
        private const int cGrip = 16;
        private const int cCaption = 32;
        private int total_nodes = 0;
        private Node[] nodes = null;
        private Connector[] connectors = null;
        private NodeProps selected = null;
        private Color anchorColor = Color.Red;
        private MarkStyle anchorStyle = MarkStyle.Circle;
        private string pseudoCode = "";

        private int flag = 0;
        private int decision = 0;
        private int loop = 0;

        //====================================================================================
        //Constructor
        //====================================================================================
        public Form_Main(int id, Rectangle targetBounds)
        {
            InitializeComponent();

            Diagram_ID = id;
            _lblDiagramID.Text = id.ToString();
            this.Bounds = targetBounds;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            TransitionHandler();

            //====================================================================================
            //Setting the features of "_diagram" components
            //====================================================================================
            _diagram.ShapeNodeStyle.Brush = new SolidBrush(Color.FromArgb(156, 170, 198));
            _diagram.ShapeNodeStyle.Stroke = new SolidBrush(Color.FromArgb(0, 0, 99));
            _diagram.DiagramLinkStyle.Brush = new SolidBrush(Color.FromArgb(102, 154, 204));
            _diagram.RouteLinks = true;
            _diagram.ShadowOffsetX = 0;
            _diagram.ShadowOffsetY = 0;
            _diagram.Selection.AllowMultipleSelection = true;
            _diagram.LinkCascadeOrientation = MindFusion.Diagramming.Orientation.Auto;
#if !STANDARD
            _diagram.UndoManager.UndoEnabled = true;
            _diagram.UndoManager.History.Capacity = 30;
#endif
            //====================================================================================
            //Setting the features of "_hidden" components
            //====================================================================================
            _hidden.Bounds = new RectangleF(0, 0, 50, 50);
            _hidden.RestrictItemsToBounds = RestrictToBounds.NoRestriction;
            //====================================================================================
            //Setting Nodes
            //====================================================================================
            Nodes allNodes = new Nodes();
            nodes = allNodes.SetNodes(Diagram_ID);
            foreach (Node n in nodes)
                _nodesListBox.Items.Add(n.Name);
            //====================================================================================
            //Setting Connectors
            //====================================================================================
            Connectors allConnectors = new Connectors();
            connectors = allConnectors.SetConnectors(Diagram_ID);
            foreach (Connector c in connectors)
                _connectionsListbox.Items.Add(c.Name);
            //====================================================================================
            //Disabling the Multiple Connection Types for Flowchart
            //====================================================================================
            if (Diagram_ID == 1)
            {
                _connectionsTypeCombobox.SelectedIndex = 1;
                _connectionsTypeCombobox.Enabled = false;
            }
            else
            {
                _connectionsTypeCombobox.SelectedIndex = 0;
                _connectionsTypeCombobox.Enabled = true;
            }
        }
        //====================================================================================
        //Functions to handle Interface Changes
        //====================================================================================
        private void TransitionHandler()
        {
            //Hint: 2 -> Usecase & 3 -> Activity
            _btnSave.Image = Properties.Resources.UnHovered_Save;
            _btnPrintPreview.Image = Properties.Resources.UnHovered_Print_Preview;
            _btnPrint.Image = Properties.Resources.UnHovered_Print;
            _btnUndo.Image = Properties.Resources.UnClicked_Undo;
            _btnRedo.Image = Properties.Resources.UnClicked_Redo;
            _btnGeneratePseudoCode.Enabled = false;
            _btnGeneratePseudoCode.Visible = false;

            if (Diagram_ID == 1 )
            {
                //Hint: 1 -> Flowchart
                _btnGeneratePseudoCode.Image = Properties.Resources.UnHovered_GeneratePseudoCode;
                _btnGeneratePseudoCode.Enabled = true;
                _btnGeneratePseudoCode.Visible = true;
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //====================================================================================
        //Some GUI Events of Form Corresponding Controls
        //====================================================================================
        private void _btnSave_MouseEnter(object sender, EventArgs e)
        {
            _btnSave.Image = Properties.Resources.Hovered_Save;
        }
        private void _btnSave_MouseLeave(object sender, EventArgs e)
        {
            _btnSave.Image = Properties.Resources.UnHovered_Save;
        }
        private void _btnPrintPreview_MouseEnter(object sender, EventArgs e)
        {
            _btnPrintPreview.Image = Properties.Resources.Hovered_Print_Preview;
        }
        private void _btnPrintPreview_MouseLeave(object sender, EventArgs e)
        {
            _btnPrintPreview.Image = Properties.Resources.UnHovered_Print_Preview;
        }
        private void _btnPrint_MouseEnter(object sender, EventArgs e)
        {
            _btnPrint.Image = Properties.Resources.Hovered_Print;
        }
        private void _btnPrint_MouseLeave(object sender, EventArgs e)
        {
            _btnPrint.Image = Properties.Resources.UnHovered_Print;
        }
        private void _btnUndo_MouseEnter(object sender, EventArgs e)
        {
            _btnUndo.Image = Properties.Resources.Clicked_Undo;
        }
        private void _btnUndo_MouseLeave(object sender, EventArgs e)
        {
            _btnUndo.Image = Properties.Resources.UnClicked_Undo;
        }
        private void _btnRedo_MouseEnter(object sender, EventArgs e)
        {
            _btnRedo.Image = Properties.Resources.Clicked_Redo;
        }
        private void _btnRedo_MouseLeave(object sender, EventArgs e)
        {
            _btnRedo.Image = Properties.Resources.UnClicked_Redo;
        }
        private void _btnGeneratePseudoCode_MouseEnter(object sender, EventArgs e)
        {
            _btnGeneratePseudoCode.Image = Properties.Resources.Hovered_GeneratePseudoCode;
        }
        private void _btnGeneratePseudoCode_MouseLeave(object sender, EventArgs e)
        {
            _btnGeneratePseudoCode.Image = Properties.Resources.UnHovered_GeneratePseudoCode;
        }
        private void _btnZoomIn_Click(object sender, EventArgs e)
        {
            _diagramView.ZoomIn();
        }
        private void _btnZoomOut_Click(object sender, EventArgs e)
        {
            _diagramView.ZoomOut();
        }
        //====================================================================================
        //Events of Form Corresponding Controls
        //====================================================================================
        private void _btnClose_Click(object sender, EventArgs e)
        {
            IDCFormControls g = new IDCFormControls();
            g.Close(ActiveForm);
        }
        private void _btnRestoreDown_Click(object sender, EventArgs e)
        {
            IDCFormControls g = new IDCFormControls();
            g.RestoreDown(ActiveForm);
        }
        private void _btnMinimize_Click(object sender, EventArgs e)
        {
            IDCFormControls g = new IDCFormControls();
            g.Minimize(ActiveForm);
        }
        private void _btnHome_Click(object sender, EventArgs e)
        {
            Form_Home frm = new Form_Home();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
        private void _btnSave_Click(object sender, EventArgs e)
        {
            int xSize = _diagramView.Width;
            int ySize = _diagramView.Height;

            Bitmap bm = new Bitmap(xSize, ySize);

            _diagramView.DrawToBitmap(bm, new Rectangle(0, 0, xSize, ySize));

            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "Save As";
            sf.DefaultExt = "png";
            sf.AddExtension = true;
            sf.Filter = "PNG Image (*.png)|*.png|JPEG Image (*.jpg)|*.jpg|BMP Image (*.bmp)|*.bmp|GIF Image (*.gif)|*.gif|TIFF Image (*.tif)|*.tif";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sf.FileName);

                switch (ext.ToLower())
                {
                    case ".png":
                        bm.Save(sf.FileName, ImageFormat.Png);
                        break;
                    case ".jpg":
                        bm.Save(sf.FileName, ImageFormat.Jpeg);
                        break;
                    case ".bmp":
                        bm.Save(sf.FileName, ImageFormat.Bmp);
                        break;
                    case ".gif":
                        bm.Save(sf.FileName, ImageFormat.Gif);
                        break;
                    case ".tif":
                        bm.Save(sf.FileName, ImageFormat.Tiff);
                        break;
                }

                MessageBox.Show("Diagram Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bm.Dispose();
            sf.Dispose();
        }
        private void _btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (Diagram_ID == 1)
            {
                _diagramView.PrintOptions.DocumentName = "IDC Flowchart";
            }
            else if (Diagram_ID == 2)
            {

                _diagramView.PrintOptions.DocumentName = "IDC Usecase Diagram";
            }
            else if (Diagram_ID == 3)
            {

                _diagramView.PrintOptions.DocumentName = "IDC Activity Diagram";
            }
            _diagramView.PrintOptions.EnableImages = false;
            _diagramView.PrintOptions.EnableInterior = true;
            _diagramView.PrintOptions.EnableShadows = true;
            _diagramView.PrintOptions.Scale = 55;
            _diagramView.PrintPreview();
        }
        private void _btnPrint_Click(object sender, EventArgs e)
        {
            if (Diagram_ID == 1)
            {
                _diagramView.PrintOptions.DocumentName = "IDC Flowchart";
            }
            else if (Diagram_ID == 2)
            {
                _diagramView.PrintOptions.DocumentName = "IDC Usecase Diagram";
            }
            else if (Diagram_ID == 3)
            {
                _diagramView.PrintOptions.DocumentName = "IDC Activity Diagram";
            }
            _diagramView.PrintOptions.EnableImages = false;
            _diagramView.PrintOptions.EnableInterior = true;
            _diagramView.PrintOptions.EnableShadows = true;
            _diagramView.PrintOptions.Scale = 55;
            _diagramView.Print();
        }
        private void _btnUndo_Click(object sender, EventArgs e)
        {
#if !STANDARD
            _diagram.UndoManager.Undo();
#endif
        }
        private void _btnRedo_Click(object sender, EventArgs e)
        {
#if !STANDARD
            _diagram.UndoManager.Redo();
#endif
        }
        private void _btnGeneratePseudoCode_Click(object sender, EventArgs e)
        {
            int xSize = _diagramView.Width;
            int ySize = _diagramView.Height;
            Bitmap bm = new Bitmap(xSize, ySize);
            _diagramView.DrawToBitmap(bm, new Rectangle(0, 0, xSize, ySize));
            bm.Save("Flowchart.jpg", ImageFormat.Jpeg);

            using (var imageStream = new MemoryStream(File.ReadAllBytes("Flowchart.jpg")))
            {
                Image flowchart = Image.FromStream(imageStream);
                Form_Pseudocode frm = new Form_Pseudocode(pseudoCode, flowchart);
                frm.Show();
            }

            bm.Dispose();
        }
        //====================================================================================
        //Important Backend Functions for List Boxes
        //====================================================================================
        private void ListBox_DrawItem(ListBox lb, System.Windows.Forms.DrawItemEventArgs e)
        {
            Rectangle rcc;
            RectangleF rc;
            System.Drawing.SolidBrush brush;
            System.Drawing.Pen selPen;
            System.Drawing.SolidBrush selBrush;
            StringFormat sf;

            rcc = e.Bounds;
            rcc.Inflate(-1, -1);

            rc = new RectangleF((float)e.Bounds.Left + 32, e.Bounds.Top, (float)e.Bounds.Width - 32, e.Bounds.Height);

            brush = new System.Drawing.SolidBrush(Color.Black);
            selPen = new System.Drawing.Pen(Color.Goldenrod);
            selBrush = new System.Drawing.SolidBrush(Color.LightYellow);

            sf = StringFormat.GenericDefault;
            sf.LineAlignment = StringAlignment.Center;

            if ((e.State & DrawItemState.Selected) > 0)
            {
                e.Graphics.FillRectangle(selBrush, rcc);
                e.Graphics.DrawRectangle(selPen, rcc);
            }
            else
            {
                System.Drawing.SolidBrush tb = new System.Drawing.SolidBrush(Color.White);
                e.Graphics.FillRectangle(tb, e.Bounds);
                tb.Dispose();
            }

            e.Graphics.DrawString((string)lb.Items[e.Index], _nodesListBox.Font, brush, rc, sf);

            brush.Dispose();
            selPen.Dispose();
            selBrush.Dispose();
        }
        private void linkInit()
        {
            if (Diagram_ID == 1)//Flowchart
            {
                if (_connectionsListbox.SelectedIndex == 1)
                {
                    _diagram.LinkText = "True";
                }
                else if (_connectionsListbox.SelectedIndex == 2)
                {
                    _diagram.LinkText = "False";
                }
                else
                {
                    _diagram.LinkText = "";
                }
            }
            else if (Diagram_ID == 2)//Usecase
            {
                if (_nodesListBox.SelectedItem.ToString() == "Actor")
                {
                    _diagram.ShapeText = "";
                    _diagram.TextFormat.LineAlignment = StringAlignment.Center;
                }
                else if (_nodesListBox.SelectedItem.ToString() == "UseCase Box")
                {
                    _diagram.TextFormat.LineAlignment = StringAlignment.Near;
                }
                else if (_nodesListBox.SelectedItem.ToString() == "UseCase")
                {
                    _diagram.TextFormat.LineAlignment = StringAlignment.Center;
                }

                if (_connectionsListbox.SelectedIndex == 0)
                {
                    _diagram.DiagramStyle.StrokeDashStyle = DashStyle.Solid;
                }
                else if (_connectionsListbox.SelectedIndex == 1)
                {
                    _diagram.DiagramStyle.StrokeDashStyle = DashStyle.Solid;
                }
                else if (_connectionsListbox.SelectedIndex == 2)
                {
                    _diagram.DiagramStyle.StrokeDashStyle = DashStyle.Solid;
                }
                else if (_connectionsListbox.SelectedIndex == 3)
                {
                    _diagram.LinkText = "<<include>>";
                    _diagram.DiagramStyle.StrokeDashStyle = DashStyle.Dash;
                }
                else if (_connectionsListbox.SelectedIndex == 4)
                {
                    _diagram.LinkText = "<<extend>>";
                    _diagram.DiagramStyle.StrokeDashStyle = DashStyle.Dash; ;
                }
            }
            else if (Diagram_ID == 3)//Activity
            {

            }
        }
        //====================================================================================
        //Important Events of Nodes List Box
        //====================================================================================
        private void _nodesListBox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            _hidden.ClearAll();
            if (e.Index < 0)
            {
                return;
            }
            ListBox_DrawItem(_nodesListBox, e);

            if ((e.State & DrawItemState.Selected) > 0)
            {
                _hidden.BackBrush = new SolidBrush(Color.LightYellow);
            }
            else
            {
                _hidden.BackBrush = new SolidBrush(Color.White);
            }

            ShapeNode node = _hidden.Factory.CreateShapeNode(1, 1, 24, 24);
            node.Shape = nodes[e.Index].Template;

            Bitmap bmp = new Bitmap(32, 32);

            GdiGraphics g = new GdiGraphics(Graphics.FromImage(bmp));
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RenderOptions ro = new RenderOptions();
            node.DrawShadow(g, ro);
            node.Draw(g, ro);
            g.Dispose();

            Rectangle rci = new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 4, 24, 24);
            e.Graphics.DrawImage(bmp, rci, 1, 1, 26, 26, GraphicsUnit.Pixel);
            
            bmp.Dispose();
        }
        private void _nodesListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 32;
        }
        private void _nodesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(new NodeDragItem(_nodesListBox.SelectedIndex), DragDropEffects.Copy);
        }
        //====================================================================================
        //Important Events of Connectors List Box
        //====================================================================================
        private void _connectionsListbox_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ListBox_DrawItem(_connectionsListbox, e);

            System.Drawing.Pen pen = new System.Drawing.Pen(Color.Black);
            Point p0 = new Point(e.Bounds.X + 2, e.Bounds.Y + 13);
            Point p1 = new Point(e.Bounds.X + 19, e.Bounds.Y + 13);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(Pens.Black, p0, p1);

            DiagramLink.DrawArrowhead(new GdiGraphics(e.Graphics), pen, Brushes.LightSkyBlue, connectors[e.Index].Head, new PointF(50, 0), p1, p0, 12F, false);
            
            pen.Dispose();
        }
        private void _connectionsListbox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 32;
        }
        private void _connectionsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            linkInit();

            int si = _connectionsListbox.SelectedIndex;
            if (si < 0 || si >= connectors.Length)
                return;

            _diagram.LinkHeadShape = connectors[si].Head;
        }
        //====================================================================================
        //Important Events of Diagram View
        //====================================================================================
        private void _diagramView_DragDrop(object sender, DragEventArgs e)
        {
            total_nodes++;
            linkInit();


            if (e.Data.GetDataPresent(NodeDragItem.Get_Type()))
            {
                NodeDragItem sdi = (NodeDragItem)e.Data.GetData(NodeDragItem.Get_Type());

                if (sdi.Index >= 0 && sdi.Index < nodes.Length)
                {
                    Point p = _diagramView.PointToClient(new Point(e.X, e.Y));
                    PointF pt = _diagramView.ClientToDoc(new Point(p.X, p.Y));

                    

                    AnchorPattern ap = nodes[sdi.Index].Anchor;
                    foreach (AnchorPoint point in ap.Points)
                    {
                        point.MarkStyle = anchorStyle;
                        point.Color = anchorColor;
                    }

                    ShapeNode b = _diagram.Factory.CreateShapeNode(pt, new SizeF(30, 20));


                    //=========================================================================================
                    if (Diagram_ID == 1)
                    {                     
                        if (_nodesListBox.SelectedItem.ToString() != "Connector")
                            b.Text = _nodesListBox.SelectedItem.ToString();
                        b.Brush = new SolidBrush(Color.White);
                        b.Font = new Font(Font.FontFamily, 12, FontStyle.Bold);
                    }
                    if (Diagram_ID == 2)
                    {
                        b.Brush = new SolidBrush(Color.White);
                    }
                    //=========================================================================================

                    b.Shape = nodes[sdi.Index].Template;
                    b.AnchorPattern = ap;
                    b.HandlesStyle = HandlesStyle.DashFrame;
                }
            }
        }
        private void _diagramView_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(NodeDragItem.Get_Type()))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        //====================================================================================
        //Important Events of Properties Box
        //====================================================================================
        private void _propertiesGridbox_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (_diagram.Selection.Nodes.Count == 0)
                return;

            ShapeNode b = _diagram.Selection.Nodes[0] as ShapeNode;
            if (b == null)
                return;

            ChangeItemCmd cmd = new ChangeItemCmd(b, "Property Change");

            b.Text = selected.Text;
            b.Font = selected.Font;
            b.Brush = new SolidBrush(selected.FillColor);

            cmd.Execute();
        }
        //====================================================================================
        //Important Events of Properties Box
        //====================================================================================
        private void _diagram_NodeActivated(object sender, NodeEventArgs e)
        {
            ShapeNode node = e.Node as ShapeNode;
            if (node != null)
            {
                selected = new NodeProps();
                selected.Text = node.Text;
                selected.Font = node.EffectiveFont;
                selected.FillColor = (node.EffectiveBrush as SolidBrush).Color;

                _propertiesGridbox.SelectedObject = selected;
            }
        }
        private void _diagram_NodeDeactivated(object sender, NodeEventArgs e)
        {
            _propertiesGridbox.SelectedObject = null;
            int noGo = 0;

            if(selected.Text != null)
            {
                if (selected.Text.Contains("Decision"))
                {
                    if (decision == 0)
                    {
                        decision = 1;
                    }
                    else if (decision == 2)
                    {
                        decision = 3;
                        noGo = 1;
                    }
                    else if (decision == 3)
                    {
                        decision = 4;
                    }
                }
                else if (selected.Text.Contains("Loop"))
                {
                    if (loop == 0)
                    {
                        loop = 1;
                    }
                    else if(loop == 2)
                    {
                        loop = 3;
                        noGo = 1;
                    }
                }
                else
                {
                    flag = 1;
                }
                //==============================================================================
                //==============================================================================
                if (decision == 1 || decision == 2 || decision == 3 || decision == 4)
                {
                    //Decision
                    if (decision == 1)//1st Decision Click
                    {
                        pseudoCode += "-----Decision Body Started-----\n";
                        pseudoCode += total_nodes.ToString() + " " + selected.Text + "\n";
                        decision++;
                    }
                    else if (decision == 2)//True Body
                    {
                        pseudoCode += total_nodes.ToString() + " -->(T): " + selected.Text + "\n";
                    }
                    else if (decision == 3 && noGo == 0)//False Body
                    {
                        pseudoCode += total_nodes.ToString() + " -->(F): " + selected.Text + "\n";
                        noGo = 0;
                    }
                    else if (decision == 4)//Last Decision Click
                    {
                        pseudoCode += "-----Decision Body Ended-----\n";
                        decision = 0;
                    }
                }
                else if (loop == 1|| loop == 2 || loop == 3)
                {
                    //Loop
                    if(loop == 1)//1st Loop Click
                    {
                        pseudoCode += "-----Loop Body Started-----\n";
                        pseudoCode += total_nodes.ToString() + " " + selected.Text + "\n";
                        loop++;
                    }
                    else if (loop == 2 && noGo == 0)//True Body
                    {
                        pseudoCode += total_nodes.ToString() + " -->(T): " + selected.Text + "\n";
                    }
                    else if (loop == 3)//Last Loop Click
                    {
                        pseudoCode += "-----Loop Body Ended-----\n";
                        loop = 0;
                    }
                }
                else if (flag == 1)
                {
                    //Normal
                    pseudoCode += total_nodes.ToString() + " " + selected.Text + "\n";
                }
                //==============================================================================
                //==============================================================================
                //MessageBox.Show("Flag = " + flag.ToString() + "\nDecision = " + decision.ToString());
            }
            selected = null;

        }
        //====================================================================================
        //Important Events of Connection Type Combobox
        //====================================================================================
        private void _connectionsTypeCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            LinkShape shape = LinkShape.Polyline;

            switch (_connectionsTypeCombobox.SelectedIndex)
            {
                case 0:
                    shape = LinkShape.Bezier;
                    break;
                case 1:
                    shape = LinkShape.Polyline;
                    break;
            }

            _diagram.LinkShape = shape;
        }
        private void _lblDescription_Click(object sender, EventArgs e)
        {
            if (Diagram_ID == 1)
            {
                FlowchartDescription desc = new FlowchartDescription();
                if (_nodesListBox.SelectedIndex == 0)
                {
                    _descriptionTextbox.Text = desc.Start();
                }
                else if (_nodesListBox.SelectedIndex == 1)
                {
                    _descriptionTextbox.Text = desc.Input();
                }
                else if (_nodesListBox.SelectedIndex == 2)
                {
                    _descriptionTextbox.Text = desc.Process();
                }
                else if (_nodesListBox.SelectedIndex == 3)
                {
                    _descriptionTextbox.Text = desc.Input();
                }
                else if (_nodesListBox.SelectedIndex == 4)
                {
                    _descriptionTextbox.Text = desc.Connector();
                }
                else if (_nodesListBox.SelectedIndex == 5)
                {
                    _descriptionTextbox.Text = desc.Output();
                }
                else 
                {
                    _descriptionTextbox.Text = desc.End();
                }
            }
            else if(Diagram_ID == 2)
            {
                UsecaseDescription desc = new UsecaseDescription();
                if (_nodesListBox.SelectedIndex == 0)
                {
                    _descriptionTextbox.Text = desc.UsecaseBox();
                }
                else if (_nodesListBox.SelectedIndex == 1)
                {
                    _descriptionTextbox.Text = desc.Actor();
                }
                else
                {
                    _descriptionTextbox.Text = desc.Usecase();
                }
            }
            else if(Diagram_ID==3)
            {
                ActivityDescription desc = new ActivityDescription();
                if (_nodesListBox.SelectedIndex == 0)
                {
                    _descriptionTextbox.Text = desc.Start();
                }
                else if (_nodesListBox.SelectedIndex == 1)
                {
                    _descriptionTextbox.Text = desc.Activity();
                }
                else if (_nodesListBox.SelectedIndex == 3)
                {
                    _descriptionTextbox.Text = desc.Action();
                }
                else if (_nodesListBox.SelectedIndex == 4)
                {
                    _descriptionTextbox.Text = desc.Decision();
                }
               else  if (_nodesListBox.SelectedIndex == 5)
                {
                    _descriptionTextbox.Text = desc.JoinNode();
                }
                else if (_nodesListBox.SelectedIndex == 6)
                {
                    _descriptionTextbox.Text = desc.ForkNode();
                }
                else 
                {
                    _descriptionTextbox.Text = desc.End();
                }
               

            }
        }
    }
}