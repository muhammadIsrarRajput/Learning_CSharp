using IntelligentDiagramCreator.Important;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntelligentDiagramCreator
{
    public partial class Form_Home : Form
    {
        //====================================================================================
        //Data Variables
        //====================================================================================
        private int Diagram_ID = 0;
        private bool leftPannelExpand = true;
        private const int cGrip = 16;
        private const int cCaption = 32;
        //====================================================================================
        //Constructor
        //====================================================================================
        public Form_Home()
        {
            InitializeComponent();
            TransitionHandler();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //====================================================================================
        //Functions for Interface Changes
        //====================================================================================
        private void ClickedMenu()
        {
            _btnMenu.ForeColor = Color.Black;
            _btnMenu.BackColor = Color.FromArgb(192, 251, 182);
            _btnMenu.Image = Properties.Resources.FullMenu;

            _pbLogo.BackgroundImage = Properties.Resources.IUMLDC;
            _pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            _rtbDescription.ForeColor = Color.Black;
            _rtbDescription.Text = @"Inteligent UML Diagram Creator";

            _btnCreateNew.Visible = false;
        }
        private void UnclickedMenu()
        {
            _btnMenu.ForeColor = Color.White;
            _btnMenu.BackColor = Color.FromArgb(60, 188, 57);
        }
        private void ClickedFlowchart()
        {
            _btnFlowchart.ForeColor = Color.Black;
            _btnFlowchart.BackColor = Color.FromArgb(192, 251, 182);
            _btnFlowchart.Image = Properties.Resources.Clicked_Diagram;

            _pbLogo.BackgroundImage = Properties.Resources.Flowchart;
            _pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            _rtbDescription.ForeColor = Color.Black;
            _rtbDescription.Text = @"Flowchart";

            _btnCreateNew.Visible = true;
        }
        private void UnclickedFlowchart()
        {
            _btnFlowchart.ForeColor = Color.White;
            _btnFlowchart.BackColor = Color.FromArgb(60, 188, 57);
            _btnFlowchart.Image = Properties.Resources.UnClicked_Diagram;
        }
        private void ClickedUsecase()
        {
            _btnUsecase.ForeColor = Color.Black;
            _btnUsecase.BackColor = Color.FromArgb(192, 251, 182);
            _btnUsecase.Image = Properties.Resources.Clicked_Diagram;

            _pbLogo.BackgroundImage = Properties.Resources.UsecaseDiagram;
            _pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            _rtbDescription.ForeColor = Color.Black;
            _rtbDescription.Text = @"Usecase Diagram";

            _btnCreateNew.Visible = true;
        }
        private void UnclickedUsecase()
        {
            _btnUsecase.ForeColor = Color.White;
            _btnUsecase.BackColor = Color.FromArgb(60, 188, 57);
            _btnUsecase.Image = Properties.Resources.UnClicked_Diagram;
        }
        private void ClickedActivity()
        {
            _btnActivity.ForeColor = Color.Black;
            _btnActivity.BackColor = Color.FromArgb(192, 251, 182);
            _btnActivity.Image = Properties.Resources.Clicked_Diagram;

            _pbLogo.BackgroundImage = Properties.Resources.ActivityDiagram;
            _pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            _rtbDescription.ForeColor = Color.Black;
            _rtbDescription.Text = @"Activity Diagram";

            _btnCreateNew.Visible = true;
        }
        private void UnclickedActivity()
        {
            _btnActivity.ForeColor = Color.White;
            _btnActivity.BackColor = Color.FromArgb(60, 188, 57);
            _btnActivity.Image = Properties.Resources.UnClicked_Diagram;
        }
        private void ClickedSequence()
        {
            _btnSequence.ForeColor = Color.Black;
            _btnSequence.BackColor = Color.FromArgb(192, 251, 182);
            _btnSequence.Image = Properties.Resources.Clicked_Diagram;

            _pbLogo.BackgroundImage = Properties.Resources.SeqeunceDiagram;
            _pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            _rtbDescription.ForeColor = Color.Black;
            _rtbDescription.Text = @"Sequence Diagram";

            _btnCreateNew.Visible = true;
        }
        private void UnclickedSequence()
        {
            _btnSequence.ForeColor = Color.White;
            _btnSequence.BackColor = Color.FromArgb(60, 188, 57);
            _btnSequence.Image = Properties.Resources.UnClicked_Diagram;
        }
        private void ClickedClass()
        {
            _btnClass.ForeColor = Color.Black;
            _btnClass.BackColor = Color.FromArgb(192, 251, 182);
            _btnClass.Image = Properties.Resources.Clicked_Diagram;

            _pbLogo.BackgroundImage = Properties.Resources.ClassDiagram;
            _pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            _rtbDescription.ForeColor = Color.Black;
            _rtbDescription.Text = @"Class Diagram";

            _btnCreateNew.Visible = true;
        }
        private void UnclickedClass()
        {
            _btnClass.ForeColor = Color.White;
            _btnClass.BackColor = Color.FromArgb(60, 188, 57);
            _btnClass.Image = Properties.Resources.UnClicked_Diagram;
        }
        private void ClickedComponent()
        {
            _btnComponent.ForeColor = Color.Black;
            _btnComponent.BackColor = Color.FromArgb(192, 251, 182);
            _btnComponent.Image = Properties.Resources.Clicked_Diagram;

            _pbLogo.BackgroundImage = Properties.Resources.ComponentDiagram;
            _pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            _rtbDescription.ForeColor = Color.Black;
            _rtbDescription.Text = @"Component Diagram";

            _btnCreateNew.Visible = true;
        }
        private void UnclickedComponent()
        {
            _btnComponent.ForeColor = Color.White;
            _btnComponent.BackColor = Color.FromArgb(60, 188, 57);
            _btnComponent.Image = Properties.Resources.UnClicked_Diagram;
        }
        //====================================================================================
        //Functions to handle Interface Changes
        //====================================================================================
        private void TransitionHandler()
        {
            Description.Description desc = new Description.Description();
            
            if (Diagram_ID == 0)
            {
                ClickedMenu();

                UnclickedFlowchart();
                UnclickedUsecase();
                UnclickedActivity();
                UnclickedSequence();
                UnclickedClass();
                UnclickedComponent();

                _rtbDescription.Text = desc.IDC();
            }
            else if (Diagram_ID == 1)
            {
                UnclickedMenu();

                ClickedFlowchart();

                UnclickedUsecase();
                UnclickedActivity();
                UnclickedSequence();
                UnclickedClass();
                UnclickedComponent();

                _rtbDescription.Text = desc.Flowchart();
            }
            else if (Diagram_ID == 2)
            {
                UnclickedMenu();
                UnclickedFlowchart();

                ClickedUsecase();
                
                UnclickedActivity();
                UnclickedSequence();
                UnclickedClass();
                UnclickedComponent();

                _rtbDescription.Text = desc.Usecase();
            }
            else if (Diagram_ID == 3)
            {
                UnclickedMenu();
                UnclickedFlowchart();
                UnclickedUsecase();

                ClickedActivity();

                UnclickedSequence();
                UnclickedClass();
                UnclickedComponent();

                _rtbDescription.Text=desc.Activity();
            }
            else if (Diagram_ID == 4)
            {
                UnclickedMenu();
                UnclickedFlowchart();
                UnclickedUsecase();
                UnclickedActivity();

                ClickedSequence();

                UnclickedClass();
                UnclickedComponent();

                _rtbDescription.Text = desc.Sequence();
            }
            else if (Diagram_ID == 5)
            {
                UnclickedMenu();
                UnclickedFlowchart();
                UnclickedUsecase();
                UnclickedActivity();
                UnclickedSequence();

                ClickedClass();

                UnclickedComponent();

                _rtbDescription.Text = desc.Class();
            }
            else if (Diagram_ID == 6)
            {
                UnclickedMenu();
                UnclickedFlowchart();
                UnclickedUsecase();
                UnclickedActivity();
                UnclickedSequence();
                UnclickedClass();

                ClickedComponent();

                _rtbDescription.Text = desc.Component();
            }
        }
        private void _pannelLeftTimer_Tick(object sender, EventArgs e)
        {
            if (leftPannelExpand)
            {
                _pannelLeft.Width -= 10;
                _btnMenu.Image = Properties.Resources.MiniMenu;
                _btnFlowchart.Enabled = false;
                _btnUsecase.Enabled = false;
                _btnActivity.Enabled = false;
                _btnSequence.Enabled = false;
                _btnClass.Enabled = false;
                _btnComponent.Enabled = false;

                if (_pannelLeft.Width == _pannelLeft.MinimumSize.Width)
                {
                    leftPannelExpand = false;
                    _pannelLeftTimer.Stop();
                }
            }
            else
            {
                _pannelLeft.Width += 10;
                _btnMenu.Image = Properties.Resources.FullMenu;
                _btnFlowchart.Enabled = true;
                _btnUsecase.Enabled = true;
                _btnActivity.Enabled = true;
                _btnSequence.Enabled = true;
                _btnClass.Enabled = true;
                _btnComponent.Enabled = true;

                if (_pannelLeft.Width == _pannelLeft.MaximumSize.Width)
                {
                    leftPannelExpand = true;
                    _pannelLeftTimer.Stop();
                }
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
        //Events of Form Corresponding Controls
        //====================================================================================
        private void _btnMenu_Click(object sender, EventArgs e)
        {
            Diagram_ID = 0;
            TransitionHandler();
            _pannelLeftTimer.Start();
        }
        private void _btnFlowchart_Click(object sender, EventArgs e)
        {
            Diagram_ID = 1;
            TransitionHandler();
        }
        private void _btnUsecase_Click(object sender, EventArgs e)
        {
            Diagram_ID = 2;
            TransitionHandler();
        }
        private void _btnActivity_Click(object sender, EventArgs e)
        {
            Diagram_ID = 3;
            TransitionHandler();
        }
        private void _btnSequence_Click(object sender, EventArgs e)
        {
            Diagram_ID = 4;
            TransitionHandler();
        }
        private void _btnClass_Click(object sender, EventArgs e)
        {
            Diagram_ID = 5;
            TransitionHandler();
        }
        private void _btnComponent_Click(object sender, EventArgs e)
        {
            Diagram_ID = 6;
            TransitionHandler();
        }
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
        private void _btnCreateNew_Click(object sender, EventArgs e)
        {
            if (Diagram_ID == 1 || Diagram_ID == 2 || Diagram_ID == 3)
            {
                Rectangle sourceBounds = this.Bounds;
                Form_Main frm = new Form_Main(Diagram_ID, sourceBounds);
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Work In Progress. It's our Future Work.");
            }
        }
    }
}