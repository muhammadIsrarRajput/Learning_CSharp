namespace IntelligentDiagramCreator
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this._pannelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this._pnlMenu = new System.Windows.Forms.Panel();
            this._btnMenu = new System.Windows.Forms.Button();
            this._pnlFlowchart = new System.Windows.Forms.Panel();
            this._btnFlowchart = new System.Windows.Forms.Button();
            this._pnlUsecase = new System.Windows.Forms.Panel();
            this._btnUsecase = new System.Windows.Forms.Button();
            this._pnlActivity = new System.Windows.Forms.Panel();
            this._btnActivity = new System.Windows.Forms.Button();
            this.pnlSequence = new System.Windows.Forms.Panel();
            this._btnSequence = new System.Windows.Forms.Button();
            this._pnlClass = new System.Windows.Forms.Panel();
            this._btnClass = new System.Windows.Forms.Button();
            this._pnlComponent = new System.Windows.Forms.Panel();
            this._btnComponent = new System.Windows.Forms.Button();
            this._pannelLeftTimer = new System.Windows.Forms.Timer(this.components);
            this._pnlMain = new System.Windows.Forms.Panel();
            this._pnlDescription = new System.Windows.Forms.TableLayoutPanel();
            this._rtbDescription = new System.Windows.Forms.RichTextBox();
            this._pnlLogoImage = new System.Windows.Forms.Panel();
            this._btnCreateNew = new System.Windows.Forms.Button();
            this._pbLogo = new System.Windows.Forms.PictureBox();
            this._btnMinimize = new System.Windows.Forms.Button();
            this._btnRestoreDown = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this._dragControler = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._pannelLeft.SuspendLayout();
            this._pnlMenu.SuspendLayout();
            this._pnlFlowchart.SuspendLayout();
            this._pnlUsecase.SuspendLayout();
            this._pnlActivity.SuspendLayout();
            this.pnlSequence.SuspendLayout();
            this._pnlClass.SuspendLayout();
            this._pnlComponent.SuspendLayout();
            this._pnlMain.SuspendLayout();
            this._pnlDescription.SuspendLayout();
            this._pnlLogoImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // _pannelLeft
            // 
            this._pannelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._pannelLeft.Controls.Add(this._pnlMenu);
            this._pannelLeft.Controls.Add(this._pnlFlowchart);
            this._pannelLeft.Controls.Add(this._pnlUsecase);
            this._pannelLeft.Controls.Add(this._pnlActivity);
            this._pannelLeft.Controls.Add(this.pnlSequence);
            this._pannelLeft.Controls.Add(this._pnlClass);
            this._pannelLeft.Controls.Add(this._pnlComponent);
            this._pannelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._pannelLeft.Location = new System.Drawing.Point(0, 0);
            this._pannelLeft.MaximumSize = new System.Drawing.Size(235, 0);
            this._pannelLeft.MinimumSize = new System.Drawing.Size(65, 0);
            this._pannelLeft.Name = "_pannelLeft";
            this._pannelLeft.Size = new System.Drawing.Size(235, 450);
            this._pannelLeft.TabIndex = 0;
            // 
            // _pnlMenu
            // 
            this._pnlMenu.Controls.Add(this._btnMenu);
            this._pnlMenu.Location = new System.Drawing.Point(3, 3);
            this._pnlMenu.Name = "_pnlMenu";
            this._pnlMenu.Size = new System.Drawing.Size(232, 50);
            this._pnlMenu.TabIndex = 1;
            // 
            // _btnMenu
            // 
            this._btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btnMenu.FlatAppearance.BorderSize = 0;
            this._btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnMenu.ForeColor = System.Drawing.Color.Black;
            this._btnMenu.Image = global::IntelligentDiagramCreator.Properties.Resources.FullMenu;
            this._btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMenu.Location = new System.Drawing.Point(0, 3);
            this._btnMenu.Name = "_btnMenu";
            this._btnMenu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnMenu.Size = new System.Drawing.Size(232, 44);
            this._btnMenu.TabIndex = 0;
            this._btnMenu.Text = "            Menu";
            this._btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnMenu.UseVisualStyleBackColor = false;
            this._btnMenu.Click += new System.EventHandler(this._btnMenu_Click);
            // 
            // _pnlFlowchart
            // 
            this._pnlFlowchart.Controls.Add(this._btnFlowchart);
            this._pnlFlowchart.Location = new System.Drawing.Point(3, 59);
            this._pnlFlowchart.Name = "_pnlFlowchart";
            this._pnlFlowchart.Size = new System.Drawing.Size(232, 50);
            this._pnlFlowchart.TabIndex = 2;
            // 
            // _btnFlowchart
            // 
            this._btnFlowchart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnFlowchart.FlatAppearance.BorderSize = 0;
            this._btnFlowchart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnFlowchart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnFlowchart.ForeColor = System.Drawing.Color.Black;
            this._btnFlowchart.Image = ((System.Drawing.Image)(resources.GetObject("_btnFlowchart.Image")));
            this._btnFlowchart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFlowchart.Location = new System.Drawing.Point(0, 3);
            this._btnFlowchart.Name = "_btnFlowchart";
            this._btnFlowchart.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnFlowchart.Size = new System.Drawing.Size(232, 44);
            this._btnFlowchart.TabIndex = 0;
            this._btnFlowchart.Text = "            Flowchart";
            this._btnFlowchart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnFlowchart.UseVisualStyleBackColor = false;
            this._btnFlowchart.Click += new System.EventHandler(this._btnFlowchart_Click);
            // 
            // _pnlUsecase
            // 
            this._pnlUsecase.Controls.Add(this._btnUsecase);
            this._pnlUsecase.Location = new System.Drawing.Point(3, 115);
            this._pnlUsecase.Name = "_pnlUsecase";
            this._pnlUsecase.Size = new System.Drawing.Size(232, 50);
            this._pnlUsecase.TabIndex = 3;
            // 
            // _btnUsecase
            // 
            this._btnUsecase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnUsecase.FlatAppearance.BorderSize = 0;
            this._btnUsecase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnUsecase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnUsecase.ForeColor = System.Drawing.Color.Black;
            this._btnUsecase.Image = ((System.Drawing.Image)(resources.GetObject("_btnUsecase.Image")));
            this._btnUsecase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnUsecase.Location = new System.Drawing.Point(0, 3);
            this._btnUsecase.Name = "_btnUsecase";
            this._btnUsecase.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnUsecase.Size = new System.Drawing.Size(232, 44);
            this._btnUsecase.TabIndex = 0;
            this._btnUsecase.Text = "            Usecase Diagram";
            this._btnUsecase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnUsecase.UseVisualStyleBackColor = false;
            this._btnUsecase.Click += new System.EventHandler(this._btnUsecase_Click);
            // 
            // _pnlActivity
            // 
            this._pnlActivity.Controls.Add(this._btnActivity);
            this._pnlActivity.Location = new System.Drawing.Point(3, 171);
            this._pnlActivity.Name = "_pnlActivity";
            this._pnlActivity.Size = new System.Drawing.Size(232, 50);
            this._pnlActivity.TabIndex = 4;
            // 
            // _btnActivity
            // 
            this._btnActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnActivity.FlatAppearance.BorderSize = 0;
            this._btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnActivity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnActivity.ForeColor = System.Drawing.Color.Black;
            this._btnActivity.Image = ((System.Drawing.Image)(resources.GetObject("_btnActivity.Image")));
            this._btnActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnActivity.Location = new System.Drawing.Point(0, 3);
            this._btnActivity.Name = "_btnActivity";
            this._btnActivity.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnActivity.Size = new System.Drawing.Size(232, 44);
            this._btnActivity.TabIndex = 0;
            this._btnActivity.Text = "            Activity Diagram";
            this._btnActivity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnActivity.UseVisualStyleBackColor = false;
            this._btnActivity.Click += new System.EventHandler(this._btnActivity_Click);
            // 
            // pnlSequence
            // 
            this.pnlSequence.Controls.Add(this._btnSequence);
            this.pnlSequence.Location = new System.Drawing.Point(3, 227);
            this.pnlSequence.Name = "pnlSequence";
            this.pnlSequence.Size = new System.Drawing.Size(232, 50);
            this.pnlSequence.TabIndex = 5;
            // 
            // _btnSequence
            // 
            this._btnSequence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnSequence.FlatAppearance.BorderSize = 0;
            this._btnSequence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSequence.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSequence.ForeColor = System.Drawing.Color.Black;
            this._btnSequence.Image = ((System.Drawing.Image)(resources.GetObject("_btnSequence.Image")));
            this._btnSequence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSequence.Location = new System.Drawing.Point(0, 3);
            this._btnSequence.Name = "_btnSequence";
            this._btnSequence.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnSequence.Size = new System.Drawing.Size(232, 44);
            this._btnSequence.TabIndex = 0;
            this._btnSequence.Text = "            Sequence Diagram";
            this._btnSequence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnSequence.UseVisualStyleBackColor = false;
            this._btnSequence.Click += new System.EventHandler(this._btnSequence_Click);
            // 
            // _pnlClass
            // 
            this._pnlClass.Controls.Add(this._btnClass);
            this._pnlClass.Location = new System.Drawing.Point(3, 283);
            this._pnlClass.Name = "_pnlClass";
            this._pnlClass.Size = new System.Drawing.Size(232, 50);
            this._pnlClass.TabIndex = 6;
            // 
            // _btnClass
            // 
            this._btnClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnClass.FlatAppearance.BorderSize = 0;
            this._btnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnClass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnClass.ForeColor = System.Drawing.Color.Black;
            this._btnClass.Image = ((System.Drawing.Image)(resources.GetObject("_btnClass.Image")));
            this._btnClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnClass.Location = new System.Drawing.Point(0, 3);
            this._btnClass.Name = "_btnClass";
            this._btnClass.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnClass.Size = new System.Drawing.Size(232, 44);
            this._btnClass.TabIndex = 0;
            this._btnClass.Text = "            Class Diagram";
            this._btnClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnClass.UseVisualStyleBackColor = false;
            this._btnClass.Click += new System.EventHandler(this._btnClass_Click);
            // 
            // _pnlComponent
            // 
            this._pnlComponent.Controls.Add(this._btnComponent);
            this._pnlComponent.Location = new System.Drawing.Point(3, 339);
            this._pnlComponent.Name = "_pnlComponent";
            this._pnlComponent.Size = new System.Drawing.Size(232, 50);
            this._pnlComponent.TabIndex = 7;
            // 
            // _btnComponent
            // 
            this._btnComponent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnComponent.FlatAppearance.BorderSize = 0;
            this._btnComponent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnComponent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnComponent.ForeColor = System.Drawing.Color.Black;
            this._btnComponent.Image = ((System.Drawing.Image)(resources.GetObject("_btnComponent.Image")));
            this._btnComponent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnComponent.Location = new System.Drawing.Point(0, 3);
            this._btnComponent.Name = "_btnComponent";
            this._btnComponent.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this._btnComponent.Size = new System.Drawing.Size(232, 44);
            this._btnComponent.TabIndex = 0;
            this._btnComponent.Text = "            Component Diagram";
            this._btnComponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnComponent.UseVisualStyleBackColor = false;
            this._btnComponent.Click += new System.EventHandler(this._btnComponent_Click);
            // 
            // _pannelLeftTimer
            // 
            this._pannelLeftTimer.Interval = 10;
            this._pannelLeftTimer.Tick += new System.EventHandler(this._pannelLeftTimer_Tick);
            // 
            // _pnlMain
            // 
            this._pnlMain.Controls.Add(this._pnlDescription);
            this._pnlMain.Controls.Add(this._btnMinimize);
            this._pnlMain.Controls.Add(this._btnRestoreDown);
            this._pnlMain.Controls.Add(this._btnClose);
            this._pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMain.Location = new System.Drawing.Point(235, 0);
            this._pnlMain.Name = "_pnlMain";
            this._pnlMain.Padding = new System.Windows.Forms.Padding(10);
            this._pnlMain.Size = new System.Drawing.Size(465, 450);
            this._pnlMain.TabIndex = 1;
            // 
            // _pnlDescription
            // 
            this._pnlDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlDescription.ColumnCount = 2;
            this._pnlDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this._pnlDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this._pnlDescription.Controls.Add(this._rtbDescription, 1, 0);
            this._pnlDescription.Controls.Add(this._pnlLogoImage, 0, 0);
            this._pnlDescription.Location = new System.Drawing.Point(13, 115);
            this._pnlDescription.Name = "_pnlDescription";
            this._pnlDescription.RowCount = 2;
            this._pnlDescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._pnlDescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._pnlDescription.Size = new System.Drawing.Size(439, 322);
            this._pnlDescription.TabIndex = 5;
            // 
            // _rtbDescription
            // 
            this._rtbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this._rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rtbDescription.Location = new System.Drawing.Point(156, 3);
            this._rtbDescription.Name = "_rtbDescription";
            this._rtbDescription.Size = new System.Drawing.Size(280, 296);
            this._rtbDescription.TabIndex = 3;
            this._rtbDescription.Text = "";
            // 
            // _pnlLogoImage
            // 
            this._pnlLogoImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._pnlLogoImage.Controls.Add(this._btnCreateNew);
            this._pnlLogoImage.Controls.Add(this._pbLogo);
            this._pnlLogoImage.Location = new System.Drawing.Point(8, 53);
            this._pnlLogoImage.Name = "_pnlLogoImage";
            this._pnlLogoImage.Size = new System.Drawing.Size(137, 196);
            this._pnlLogoImage.TabIndex = 0;
            // 
            // _btnCreateNew
            // 
            this._btnCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCreateNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this._btnCreateNew.FlatAppearance.BorderSize = 0;
            this._btnCreateNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCreateNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCreateNew.Location = new System.Drawing.Point(0, 166);
            this._btnCreateNew.Name = "_btnCreateNew";
            this._btnCreateNew.Size = new System.Drawing.Size(137, 23);
            this._btnCreateNew.TabIndex = 3;
            this._btnCreateNew.Text = "+     Create New";
            this._btnCreateNew.UseVisualStyleBackColor = false;
            this._btnCreateNew.Click += new System.EventHandler(this._btnCreateNew_Click);
            // 
            // _pbLogo
            // 
            this._pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._pbLogo.Location = new System.Drawing.Point(0, 0);
            this._pbLogo.Name = "_pbLogo";
            this._pbLogo.Size = new System.Drawing.Size(137, 160);
            this._pbLogo.TabIndex = 2;
            this._pbLogo.TabStop = false;
            // 
            // _btnMinimize
            // 
            this._btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnMinimize.FlatAppearance.BorderSize = 0;
            this._btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnMinimize.Image = global::IntelligentDiagramCreator.Properties.Resources.Minimize;
            this._btnMinimize.Location = new System.Drawing.Point(360, 10);
            this._btnMinimize.Name = "_btnMinimize";
            this._btnMinimize.Size = new System.Drawing.Size(25, 25);
            this._btnMinimize.TabIndex = 4;
            this._toolTip.SetToolTip(this._btnMinimize, "Minimize");
            this._btnMinimize.UseVisualStyleBackColor = true;
            this._btnMinimize.Click += new System.EventHandler(this._btnMinimize_Click);
            // 
            // _btnRestoreDown
            // 
            this._btnRestoreDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRestoreDown.FlatAppearance.BorderSize = 0;
            this._btnRestoreDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnRestoreDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRestoreDown.Image = global::IntelligentDiagramCreator.Properties.Resources.RestoreDown;
            this._btnRestoreDown.Location = new System.Drawing.Point(395, 10);
            this._btnRestoreDown.Name = "_btnRestoreDown";
            this._btnRestoreDown.Size = new System.Drawing.Size(25, 25);
            this._btnRestoreDown.TabIndex = 3;
            this._toolTip.SetToolTip(this._btnRestoreDown, "Restore Down");
            this._btnRestoreDown.UseVisualStyleBackColor = true;
            this._btnRestoreDown.Click += new System.EventHandler(this._btnRestoreDown_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.FlatAppearance.BorderSize = 0;
            this._btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnClose.Image = global::IntelligentDiagramCreator.Properties.Resources.Close;
            this._btnClose.Location = new System.Drawing.Point(430, 10);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(25, 25);
            this._btnClose.TabIndex = 2;
            this._toolTip.SetToolTip(this._btnClose, "Close");
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _dragControler
            // 
            this._dragControler.Fixed = true;
            this._dragControler.Horizontal = true;
            this._dragControler.TargetControl = this._pnlMain;
            this._dragControler.Vertical = true;
            // 
            // Form_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this._pnlMain);
            this.Controls.Add(this._pannelLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intelligent Diagram Creator";
            this._pannelLeft.ResumeLayout(false);
            this._pnlMenu.ResumeLayout(false);
            this._pnlFlowchart.ResumeLayout(false);
            this._pnlUsecase.ResumeLayout(false);
            this._pnlActivity.ResumeLayout(false);
            this.pnlSequence.ResumeLayout(false);
            this._pnlClass.ResumeLayout(false);
            this._pnlComponent.ResumeLayout(false);
            this._pnlMain.ResumeLayout(false);
            this._pnlDescription.ResumeLayout(false);
            this._pnlLogoImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel _pannelLeft;
        private System.Windows.Forms.Panel _pnlMenu;
        private System.Windows.Forms.Button _btnMenu;
        private System.Windows.Forms.Panel _pnlFlowchart;
        private System.Windows.Forms.Button _btnFlowchart;
        private System.Windows.Forms.Panel _pnlUsecase;
        private System.Windows.Forms.Button _btnUsecase;
        private System.Windows.Forms.Panel _pnlActivity;
        private System.Windows.Forms.Button _btnActivity;
        private System.Windows.Forms.Panel pnlSequence;
        private System.Windows.Forms.Button _btnSequence;
        private System.Windows.Forms.Panel _pnlClass;
        private System.Windows.Forms.Button _btnClass;
        private System.Windows.Forms.Panel _pnlComponent;
        private System.Windows.Forms.Button _btnComponent;
        private System.Windows.Forms.Timer _pannelLeftTimer;
        private System.Windows.Forms.Panel _pnlMain;
        private System.Windows.Forms.Button _btnMinimize;
        private System.Windows.Forms.Button _btnRestoreDown;
        private System.Windows.Forms.Button _btnClose;
        private Bunifu.Framework.UI.BunifuDragControl _dragControler;
        private System.Windows.Forms.TableLayoutPanel _pnlDescription;
        private System.Windows.Forms.RichTextBox _rtbDescription;
        private System.Windows.Forms.Panel _pnlLogoImage;
        private System.Windows.Forms.Button _btnCreateNew;
        private System.Windows.Forms.PictureBox _pbLogo;
        private System.Windows.Forms.ToolTip _toolTip;
    }
}

