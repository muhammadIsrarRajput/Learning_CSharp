namespace IntelligentDiagramCreator
{
    partial class Form_Pseudocode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pseudocode));
            this._pnlTop = new System.Windows.Forms.Panel();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnBack = new System.Windows.Forms.Button();
            this._btnMinimize = new System.Windows.Forms.Button();
            this._btnRestoreDown = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this._pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this._btnGeneratePC = new System.Windows.Forms.Button();
            this._pbFlowchart = new System.Windows.Forms.PictureBox();
            this._rtbPseudoCode = new System.Windows.Forms.RichTextBox();
            this._dragControler = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this._pnlNote = new System.Windows.Forms.Panel();
            this._lblNote = new System.Windows.Forms.Label();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._pnlTop.SuspendLayout();
            this._pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbFlowchart)).BeginInit();
            this._pnlNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlTop
            // 
            this._pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._pnlTop.Controls.Add(this._btnSave);
            this._pnlTop.Controls.Add(this._btnBack);
            this._pnlTop.Controls.Add(this._btnMinimize);
            this._pnlTop.Controls.Add(this._btnRestoreDown);
            this._pnlTop.Controls.Add(this._btnClose);
            this._pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlTop.Location = new System.Drawing.Point(0, 0);
            this._pnlTop.Name = "_pnlTop";
            this._pnlTop.Size = new System.Drawing.Size(700, 50);
            this._pnlTop.TabIndex = 2;
            // 
            // _btnSave
            // 
            this._btnSave.FlatAppearance.BorderSize = 0;
            this._btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSave.Image = global::IntelligentDiagramCreator.Properties.Resources.UnHovered_Save;
            this._btnSave.Location = new System.Drawing.Point(60, 10);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(27, 27);
            this._btnSave.TabIndex = 9;
            this._toolTip.SetToolTip(this._btnSave, "Save Pseudocode");
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            this._btnSave.MouseEnter += new System.EventHandler(this._btnSave_MouseEnter);
            this._btnSave.MouseLeave += new System.EventHandler(this._btnSave_MouseLeave);
            // 
            // _btnBack
            // 
            this._btnBack.FlatAppearance.BorderSize = 0;
            this._btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBack.Image = global::IntelligentDiagramCreator.Properties.Resources.UnHovered_Back;
            this._btnBack.Location = new System.Drawing.Point(10, 10);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(27, 27);
            this._btnBack.TabIndex = 8;
            this._toolTip.SetToolTip(this._btnBack, "Back");
            this._btnBack.UseVisualStyleBackColor = true;
            this._btnBack.Click += new System.EventHandler(this._btnBack_Click);
            this._btnBack.MouseEnter += new System.EventHandler(this._btnBack_MouseEnter);
            this._btnBack.MouseLeave += new System.EventHandler(this._btnBack_MouseLeave);
            // 
            // _btnMinimize
            // 
            this._btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnMinimize.FlatAppearance.BorderSize = 0;
            this._btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this._btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMinimize.Image = global::IntelligentDiagramCreator.Properties.Resources.Minimize;
            this._btnMinimize.Location = new System.Drawing.Point(595, 10);
            this._btnMinimize.Name = "_btnMinimize";
            this._btnMinimize.Size = new System.Drawing.Size(25, 25);
            this._btnMinimize.TabIndex = 7;
            this._toolTip.SetToolTip(this._btnMinimize, "Minimize");
            this._btnMinimize.UseVisualStyleBackColor = true;
            this._btnMinimize.Click += new System.EventHandler(this._btnMinimize_Click);
            // 
            // _btnRestoreDown
            // 
            this._btnRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRestoreDown.FlatAppearance.BorderSize = 0;
            this._btnRestoreDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this._btnRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRestoreDown.Image = global::IntelligentDiagramCreator.Properties.Resources.RestoreDown;
            this._btnRestoreDown.Location = new System.Drawing.Point(630, 10);
            this._btnRestoreDown.Name = "_btnRestoreDown";
            this._btnRestoreDown.Size = new System.Drawing.Size(25, 25);
            this._btnRestoreDown.TabIndex = 6;
            this._toolTip.SetToolTip(this._btnRestoreDown, "Restore Down");
            this._btnRestoreDown.UseVisualStyleBackColor = true;
            this._btnRestoreDown.Click += new System.EventHandler(this._btnRestoreDown_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.FlatAppearance.BorderSize = 0;
            this._btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnClose.Image = global::IntelligentDiagramCreator.Properties.Resources.Close;
            this._btnClose.Location = new System.Drawing.Point(665, 10);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(25, 25);
            this._btnClose.TabIndex = 5;
            this._toolTip.SetToolTip(this._btnClose, "Close");
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _pnlMain
            // 
            this._pnlMain.ColumnCount = 3;
            this._pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this._pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this._pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this._pnlMain.Controls.Add(this._btnGeneratePC, 1, 0);
            this._pnlMain.Controls.Add(this._pbFlowchart, 0, 0);
            this._pnlMain.Controls.Add(this._rtbPseudoCode, 2, 0);
            this._pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMain.Location = new System.Drawing.Point(0, 75);
            this._pnlMain.Name = "_pnlMain";
            this._pnlMain.Padding = new System.Windows.Forms.Padding(3);
            this._pnlMain.RowCount = 2;
            this._pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this._pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._pnlMain.Size = new System.Drawing.Size(700, 375);
            this._pnlMain.TabIndex = 3;
            // 
            // _btnGeneratePC
            // 
            this._btnGeneratePC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnGeneratePC.FlatAppearance.BorderSize = 0;
            this._btnGeneratePC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnGeneratePC.Image = global::IntelligentDiagramCreator.Properties.Resources.UnHovered_Convert;
            this._btnGeneratePC.Location = new System.Drawing.Point(403, 165);
            this._btnGeneratePC.Name = "_btnGeneratePC";
            this._btnGeneratePC.Size = new System.Drawing.Size(26, 27);
            this._btnGeneratePC.TabIndex = 10;
            this._toolTip.SetToolTip(this._btnGeneratePC, "Generate Pseudocode");
            this._btnGeneratePC.UseVisualStyleBackColor = true;
            this._btnGeneratePC.Click += new System.EventHandler(this._btnGeneratePC_Click);
            this._btnGeneratePC.MouseEnter += new System.EventHandler(this._btnGeneratePC_MouseEnter);
            this._btnGeneratePC.MouseLeave += new System.EventHandler(this._btnGeneratePC_MouseLeave);
            // 
            // _pbFlowchart
            // 
            this._pbFlowchart.BackColor = System.Drawing.SystemColors.Window;
            this._pbFlowchart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pbFlowchart.Location = new System.Drawing.Point(6, 6);
            this._pbFlowchart.Name = "_pbFlowchart";
            this._pbFlowchart.Size = new System.Drawing.Size(391, 345);
            this._pbFlowchart.TabIndex = 1;
            this._pbFlowchart.TabStop = false;
            // 
            // _rtbPseudoCode
            // 
            this._rtbPseudoCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbPseudoCode.Location = new System.Drawing.Point(435, 6);
            this._rtbPseudoCode.Name = "_rtbPseudoCode";
            this._rtbPseudoCode.Size = new System.Drawing.Size(259, 345);
            this._rtbPseudoCode.TabIndex = 2;
            this._rtbPseudoCode.Text = "";
            // 
            // _dragControler
            // 
            this._dragControler.Fixed = true;
            this._dragControler.Horizontal = true;
            this._dragControler.TargetControl = this._pnlTop;
            this._dragControler.Vertical = true;
            // 
            // _pnlNote
            // 
            this._pnlNote.Controls.Add(this._lblNote);
            this._pnlNote.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlNote.Location = new System.Drawing.Point(0, 50);
            this._pnlNote.Name = "_pnlNote";
            this._pnlNote.Size = new System.Drawing.Size(700, 25);
            this._pnlNote.TabIndex = 4;
            // 
            // _lblNote
            // 
            this._lblNote.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._lblNote.AutoSize = true;
            this._lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNote.ForeColor = System.Drawing.Color.Red;
            this._lblNote.Location = new System.Drawing.Point(2, 5);
            this._lblNote.Name = "_lblNote";
            this._lblNote.Padding = new System.Windows.Forms.Padding(1);
            this._lblNote.Size = new System.Drawing.Size(486, 15);
            this._lblNote.TabIndex = 12;
            this._lblNote.Text = "Note: To generate the pseudocode from the belown flowchart, click on generate pse" +
    "udocode button.";
            // 
            // Form_Pseudocode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this._pnlMain);
            this.Controls.Add(this._pnlNote);
            this.Controls.Add(this._pnlTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Form_Pseudocode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Intelligent Diagram Creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._pnlTop.ResumeLayout(false);
            this._pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbFlowchart)).EndInit();
            this._pnlNote.ResumeLayout(false);
            this._pnlNote.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel _pnlTop;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnBack;
        private System.Windows.Forms.Button _btnMinimize;
        private System.Windows.Forms.Button _btnRestoreDown;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.TableLayoutPanel _pnlMain;
        private System.Windows.Forms.PictureBox _pbFlowchart;
        private System.Windows.Forms.RichTextBox _rtbPseudoCode;
        private System.Windows.Forms.Button _btnGeneratePC;
        private Bunifu.Framework.UI.BunifuDragControl _dragControler;
        private System.Windows.Forms.Panel _pnlNote;
        private System.Windows.Forms.Label _lblNote;
        private System.Windows.Forms.ToolTip _toolTip;
    }
}