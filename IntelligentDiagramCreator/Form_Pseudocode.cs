using IntelligentDiagramCreator.Important;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace IntelligentDiagramCreator
{
    public partial class Form_Pseudocode : Form
    {
        //====================================================================================
        //Data Variables
        //====================================================================================
        private const int cGrip = 16;
        private const int cCaption = 32;
        private string pseudoCode = "";

        //====================================================================================
        //Constructor
        //====================================================================================
        public Form_Pseudocode(string pc, Image img)
        {
            InitializeComponent();

            _pnlMain.ColumnStyles[0].SizeType = SizeType.Percent;
            _pnlMain.ColumnStyles[0].Width = 80;
            _pnlMain.ColumnStyles[2].SizeType = SizeType.Percent;
            _pnlMain.ColumnStyles[2].Width = 20;

            _rtbPseudoCode.Font = new System.Drawing.Font(_rtbPseudoCode.Font.FontFamily, 12);

            pseudoCode = pc;
            _pbFlowchart.Image = img;

            _btnBack.Image = Properties.Resources.UnHovered_Back;
            _btnSave.Image = Properties.Resources.UnHovered_Save;
            _btnGeneratePC.Image = Properties.Resources.UnHovered_Convert;

            _btnSave.Enabled = false;
        }
        //====================================================================================
        //Functions to handle Interface Changes
        //====================================================================================
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
        private void _btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void _btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Save Pseudo Code";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                if (Path.GetExtension(filePath).ToLower() == ".txt")
                {
                    // Save as text file
                    SaveAsText(filePath);
                }
                else if (Path.GetExtension(filePath).ToLower() == ".pdf")
                {
                    // Save as PDF file
                    SaveAsPdf(filePath);
                }
                else
                {
                    MessageBox.Show("Invalid file format. Please select a .txt or .pdf file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SaveAsText(string filePath)
        {
            string pseudoCode = _rtbPseudoCode.Text;
            try
            {
                File.WriteAllText(filePath, pseudoCode);
                MessageBox.Show("Pseudo Code saved as a text file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveAsPdf(string filePath)
        {
            string pseudoCode = _rtbPseudoCode.Text;
            try
            {
                Document document = new Document();
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();
                document.Add(new Paragraph(pseudoCode));
                document.Close();
                MessageBox.Show("Pseudo Code saved as a PDF file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //====================================================================================
        //PseudoCode Generation Functions
        //====================================================================================
        private void _btnGeneratePC_Click(object sender, EventArgs e)
        {
            _rtbPseudoCode.Text = pseudoCode;
            _btnSave.Enabled = true;
        }
        //====================================================================================
        //Some GUI Events of Form Corresponding Controls
        //====================================================================================
        private void _btnBack_MouseEnter(object sender, EventArgs e)
        {
            _btnBack.Image = Properties.Resources.Hovered_Back;
        }
        private void _btnBack_MouseLeave(object sender, EventArgs e)
        {
            _btnBack.Image = Properties.Resources.UnHovered_Back;
        }
        private void _btnSave_MouseEnter(object sender, EventArgs e)
        {
            _btnSave.Image = Properties.Resources.Hovered_Save;
        }
        private void _btnSave_MouseLeave(object sender, EventArgs e)
        {
            _btnSave.Image = Properties.Resources.UnHovered_Save;
        }
        private void _btnGeneratePC_MouseEnter(object sender, EventArgs e)
        {
            _btnGeneratePC.Image = Properties.Resources.Hovered_Convert;
        }
        private void _btnGeneratePC_MouseLeave(object sender, EventArgs e)
        {
            _btnGeneratePC.Image = Properties.Resources.UnHovered_Convert;
        }
    }
}