using MindFusion.Diagramming;

namespace IntelligentDiagramCreator
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this._lblDiagramID = new System.Windows.Forms.Label();
            this._dragControler = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this._pnlTop = new System.Windows.Forms.Panel();
            this._btnGeneratePseudoCode = new System.Windows.Forms.Button();
            this._btnRedo = new System.Windows.Forms.Button();
            this._btnUndo = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnHome = new System.Windows.Forms.Button();
            this._btnPrint = new System.Windows.Forms.Button();
            this._btnMinimize = new System.Windows.Forms.Button();
            this._btnRestoreDown = new System.Windows.Forms.Button();
            this._btnPrintPreview = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this._pnlLeft = new System.Windows.Forms.TableLayoutPanel();
            this._descriptionTextbox = new System.Windows.Forms.RichTextBox();
            this._mainTab = new System.Windows.Forms.TabControl();
            this._mainNodesTab = new System.Windows.Forms.TabPage();
            this._nodesListBox = new System.Windows.Forms.ListBox();
            this._mainConnectionsTab = new System.Windows.Forms.TabPage();
            this._connectionsListbox = new System.Windows.Forms.ListBox();
            this._connectionsTypeCombobox = new System.Windows.Forms.ComboBox();
            this._mainPropertiesTab = new System.Windows.Forms.TabPage();
            this._propertiesGridbox = new System.Windows.Forms.PropertyGrid();
            this._lblDescription = new System.Windows.Forms.Label();
            this._pnlMain = new System.Windows.Forms.Panel();
            this._pnlZoomControl = new System.Windows.Forms.Panel();
            this._btnZoomIn = new System.Windows.Forms.Button();
            this._btnZoomOut = new System.Windows.Forms.Button();
            this._diagramView = new MindFusion.Diagramming.WinForms.DiagramView();
            this._diagram = new MindFusion.Diagramming.Diagram();
            this._hidden = new MindFusion.Diagramming.Diagram();
            this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this._toolTip = new System.Windows.Forms.ToolTip(this.components);
            this._pnlTop.SuspendLayout();
            this._pnlLeft.SuspendLayout();
            this._mainTab.SuspendLayout();
            this._mainNodesTab.SuspendLayout();
            this._mainConnectionsTab.SuspendLayout();
            this._mainPropertiesTab.SuspendLayout();
            this._pnlMain.SuspendLayout();
            this._pnlZoomControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblDiagramID
            // 
            this._lblDiagramID.AutoSize = true;
            this._lblDiagramID.Location = new System.Drawing.Point(367, 209);
            this._lblDiagramID.Name = "_lblDiagramID";
            this._lblDiagramID.Size = new System.Drawing.Size(0, 13);
            this._lblDiagramID.TabIndex = 0;
            // 
            // _dragControler
            // 
            this._dragControler.Fixed = true;
            this._dragControler.Horizontal = true;
            this._dragControler.TargetControl = this._pnlTop;
            this._dragControler.Vertical = true;
            // 
            // _pnlTop
            // 
            this._pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(57)))));
            this._pnlTop.Controls.Add(this._btnGeneratePseudoCode);
            this._pnlTop.Controls.Add(this._btnRedo);
            this._pnlTop.Controls.Add(this._btnUndo);
            this._pnlTop.Controls.Add(this._btnSave);
            this._pnlTop.Controls.Add(this._btnHome);
            this._pnlTop.Controls.Add(this._btnPrint);
            this._pnlTop.Controls.Add(this._btnMinimize);
            this._pnlTop.Controls.Add(this._btnRestoreDown);
            this._pnlTop.Controls.Add(this._btnPrintPreview);
            this._pnlTop.Controls.Add(this._btnClose);
            this._pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlTop.Location = new System.Drawing.Point(0, 0);
            this._pnlTop.Name = "_pnlTop";
            this._pnlTop.Size = new System.Drawing.Size(700, 50);
            this._pnlTop.TabIndex = 1;
            // 
            // _btnGeneratePseudoCode
            // 
            this._btnGeneratePseudoCode.FlatAppearance.BorderSize = 0;
            this._btnGeneratePseudoCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnGeneratePseudoCode.Image = global::IntelligentDiagramCreator.Properties.Resources.UnHovered_GeneratePseudoCode;
            this._btnGeneratePseudoCode.Location = new System.Drawing.Point(310, 10);
            this._btnGeneratePseudoCode.Name = "_btnGeneratePseudoCode";
            this._btnGeneratePseudoCode.Size = new System.Drawing.Size(27, 27);
            this._btnGeneratePseudoCode.TabIndex = 14;
            this._toolTip.SetToolTip(this._btnGeneratePseudoCode, "Pseudocode");
            this._btnGeneratePseudoCode.UseVisualStyleBackColor = true;
            this._btnGeneratePseudoCode.Click += new System.EventHandler(this._btnGeneratePseudoCode_Click);
            this._btnGeneratePseudoCode.MouseEnter += new System.EventHandler(this._btnGeneratePseudoCode_MouseEnter);
            this._btnGeneratePseudoCode.MouseLeave += new System.EventHandler(this._btnGeneratePseudoCode_MouseLeave);
            // 
            // _btnRedo
            // 
            this._btnRedo.FlatAppearance.BorderSize = 0;
            this._btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnRedo.Image = global::IntelligentDiagramCreator.Properties.Resources.UnClicked_Redo;
            this._btnRedo.Location = new System.Drawing.Point(260, 10);
            this._btnRedo.Name = "_btnRedo";
            this._btnRedo.Size = new System.Drawing.Size(27, 27);
            this._btnRedo.TabIndex = 13;
            this._toolTip.SetToolTip(this._btnRedo, "Redo");
            this._btnRedo.UseVisualStyleBackColor = true;
            this._btnRedo.Click += new System.EventHandler(this._btnRedo_Click);
            this._btnRedo.MouseEnter += new System.EventHandler(this._btnRedo_MouseEnter);
            this._btnRedo.MouseLeave += new System.EventHandler(this._btnRedo_MouseLeave);
            // 
            // _btnUndo
            // 
            this._btnUndo.FlatAppearance.BorderSize = 0;
            this._btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnUndo.Image = global::IntelligentDiagramCreator.Properties.Resources.UnClicked_Undo;
            this._btnUndo.Location = new System.Drawing.Point(210, 10);
            this._btnUndo.Name = "_btnUndo";
            this._btnUndo.Size = new System.Drawing.Size(27, 27);
            this._btnUndo.TabIndex = 12;
            this._toolTip.SetToolTip(this._btnUndo, "Undo");
            this._btnUndo.UseVisualStyleBackColor = true;
            this._btnUndo.Click += new System.EventHandler(this._btnUndo_Click);
            this._btnUndo.MouseEnter += new System.EventHandler(this._btnUndo_MouseEnter);
            this._btnUndo.MouseLeave += new System.EventHandler(this._btnUndo_MouseLeave);
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
            this._toolTip.SetToolTip(this._btnSave, "Save As");
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            this._btnSave.MouseEnter += new System.EventHandler(this._btnSave_MouseEnter);
            this._btnSave.MouseLeave += new System.EventHandler(this._btnSave_MouseLeave);
            // 
            // _btnHome
            // 
            this._btnHome.FlatAppearance.BorderSize = 0;
            this._btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHome.Image = global::IntelligentDiagramCreator.Properties.Resources.Home;
            this._btnHome.Location = new System.Drawing.Point(10, 10);
            this._btnHome.Name = "_btnHome";
            this._btnHome.Size = new System.Drawing.Size(27, 27);
            this._btnHome.TabIndex = 8;
            this._toolTip.SetToolTip(this._btnHome, "Home");
            this._btnHome.UseVisualStyleBackColor = true;
            this._btnHome.Click += new System.EventHandler(this._btnHome_Click);
            // 
            // _btnPrint
            // 
            this._btnPrint.FlatAppearance.BorderSize = 0;
            this._btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPrint.Image = global::IntelligentDiagramCreator.Properties.Resources.UnHovered_Print;
            this._btnPrint.Location = new System.Drawing.Point(160, 10);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(27, 27);
            this._btnPrint.TabIndex = 11;
            this._toolTip.SetToolTip(this._btnPrint, "Print");
            this._btnPrint.UseVisualStyleBackColor = true;
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            this._btnPrint.MouseEnter += new System.EventHandler(this._btnPrint_MouseEnter);
            this._btnPrint.MouseLeave += new System.EventHandler(this._btnPrint_MouseLeave);
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
            // _btnPrintPreview
            // 
            this._btnPrintPreview.FlatAppearance.BorderSize = 0;
            this._btnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnPrintPreview.Image = global::IntelligentDiagramCreator.Properties.Resources.UnHovered_Print_Preview;
            this._btnPrintPreview.Location = new System.Drawing.Point(110, 10);
            this._btnPrintPreview.Name = "_btnPrintPreview";
            this._btnPrintPreview.Size = new System.Drawing.Size(27, 27);
            this._btnPrintPreview.TabIndex = 10;
            this._toolTip.SetToolTip(this._btnPrintPreview, "Print Preview");
            this._btnPrintPreview.UseVisualStyleBackColor = true;
            this._btnPrintPreview.Click += new System.EventHandler(this._btnPrintPreview_Click);
            this._btnPrintPreview.MouseEnter += new System.EventHandler(this._btnPrintPreview_MouseEnter);
            this._btnPrintPreview.MouseLeave += new System.EventHandler(this._btnPrintPreview_MouseLeave);
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
            // _pnlLeft
            // 
            this._pnlLeft.ColumnCount = 1;
            this._pnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._pnlLeft.Controls.Add(this._descriptionTextbox, 0, 2);
            this._pnlLeft.Controls.Add(this._mainTab, 0, 0);
            this._pnlLeft.Controls.Add(this._lblDescription, 0, 1);
            this._pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlLeft.Location = new System.Drawing.Point(0, 50);
            this._pnlLeft.Name = "_pnlLeft";
            this._pnlLeft.Padding = new System.Windows.Forms.Padding(4);
            this._pnlLeft.RowCount = 3;
            this._pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this._pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._pnlLeft.Size = new System.Drawing.Size(237, 400);
            this._pnlLeft.TabIndex = 2;
            // 
            // _descriptionTextbox
            // 
            this._descriptionTextbox.BackColor = System.Drawing.Color.White;
            this._descriptionTextbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._descriptionTextbox.Location = new System.Drawing.Point(7, 212);
            this._descriptionTextbox.Name = "_descriptionTextbox";
            this._descriptionTextbox.ReadOnly = true;
            this._descriptionTextbox.Size = new System.Drawing.Size(223, 181);
            this._descriptionTextbox.TabIndex = 3;
            this._descriptionTextbox.Text = "";
            // 
            // _mainTab
            // 
            this._mainTab.Controls.Add(this._mainNodesTab);
            this._mainTab.Controls.Add(this._mainConnectionsTab);
            this._mainTab.Controls.Add(this._mainPropertiesTab);
            this._mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainTab.HotTrack = true;
            this._mainTab.Location = new System.Drawing.Point(7, 7);
            this._mainTab.Name = "_mainTab";
            this._mainTab.SelectedIndex = 0;
            this._mainTab.Size = new System.Drawing.Size(223, 181);
            this._mainTab.TabIndex = 1;
            // 
            // _mainNodesTab
            // 
            this._mainNodesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this._mainNodesTab.Controls.Add(this._nodesListBox);
            this._mainNodesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainNodesTab.Location = new System.Drawing.Point(4, 25);
            this._mainNodesTab.Name = "_mainNodesTab";
            this._mainNodesTab.Size = new System.Drawing.Size(215, 152);
            this._mainNodesTab.TabIndex = 0;
            this._mainNodesTab.Text = "Nodes";
            // 
            // _nodesListBox
            // 
            this._nodesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._nodesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nodesListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._nodesListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this._nodesListBox.Location = new System.Drawing.Point(0, 0);
            this._nodesListBox.Name = "_nodesListBox";
            this._nodesListBox.Size = new System.Drawing.Size(215, 152);
            this._nodesListBox.TabIndex = 2;
            this._nodesListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._nodesListBox_DrawItem);
            this._nodesListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this._nodesListBox_MeasureItem);
            this._nodesListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this._nodesListBox_MouseDown);
            // 
            // _mainConnectionsTab
            // 
            this._mainConnectionsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this._mainConnectionsTab.Controls.Add(this._connectionsListbox);
            this._mainConnectionsTab.Controls.Add(this._connectionsTypeCombobox);
            this._mainConnectionsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainConnectionsTab.Location = new System.Drawing.Point(4, 25);
            this._mainConnectionsTab.Name = "_mainConnectionsTab";
            this._mainConnectionsTab.Size = new System.Drawing.Size(178, 152);
            this._mainConnectionsTab.TabIndex = 1;
            this._mainConnectionsTab.Text = "Connectors";
            // 
            // _connectionsListbox
            // 
            this._connectionsListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._connectionsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._connectionsListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._connectionsListbox.Location = new System.Drawing.Point(0, 0);
            this._connectionsListbox.Name = "_connectionsListbox";
            this._connectionsListbox.Size = new System.Drawing.Size(178, 128);
            this._connectionsListbox.TabIndex = 2;
            this._connectionsListbox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._connectionsListbox_DrawItem);
            this._connectionsListbox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this._connectionsListbox_MeasureItem);
            this._connectionsListbox.SelectedIndexChanged += new System.EventHandler(this._connectionsListbox_SelectedIndexChanged);
            // 
            // _connectionsTypeCombobox
            // 
            this._connectionsTypeCombobox.BackColor = System.Drawing.SystemColors.Window;
            this._connectionsTypeCombobox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._connectionsTypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._connectionsTypeCombobox.Items.AddRange(new object[] {
            "Bezier",
            "Polyline"});
            this._connectionsTypeCombobox.Location = new System.Drawing.Point(0, 128);
            this._connectionsTypeCombobox.Name = "_connectionsTypeCombobox";
            this._connectionsTypeCombobox.Size = new System.Drawing.Size(178, 24);
            this._connectionsTypeCombobox.TabIndex = 1;
            this._connectionsTypeCombobox.SelectedValueChanged += new System.EventHandler(this._connectionsTypeCombobox_SelectedValueChanged);
            // 
            // _mainPropertiesTab
            // 
            this._mainPropertiesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this._mainPropertiesTab.Controls.Add(this._propertiesGridbox);
            this._mainPropertiesTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._mainPropertiesTab.Location = new System.Drawing.Point(4, 25);
            this._mainPropertiesTab.Name = "_mainPropertiesTab";
            this._mainPropertiesTab.Padding = new System.Windows.Forms.Padding(3);
            this._mainPropertiesTab.Size = new System.Drawing.Size(178, 152);
            this._mainPropertiesTab.TabIndex = 2;
            this._mainPropertiesTab.Text = "Properties";
            // 
            // _propertiesGridbox
            // 
            this._propertiesGridbox.BackColor = System.Drawing.SystemColors.Window;
            this._propertiesGridbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._propertiesGridbox.HelpVisible = false;
            this._propertiesGridbox.LineColor = System.Drawing.SystemColors.ScrollBar;
            this._propertiesGridbox.Location = new System.Drawing.Point(3, 3);
            this._propertiesGridbox.Name = "_propertiesGridbox";
            this._propertiesGridbox.SelectedItemWithFocusBackColor = System.Drawing.Color.White;
            this._propertiesGridbox.Size = new System.Drawing.Size(172, 146);
            this._propertiesGridbox.TabIndex = 2;
            this._propertiesGridbox.Tag = "";
            this._propertiesGridbox.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this._propertiesGridbox_PropertyValueChanged);
            // 
            // _lblDescription
            // 
            this._lblDescription.AutoSize = true;
            this._lblDescription.Location = new System.Drawing.Point(7, 194);
            this._lblDescription.Margin = new System.Windows.Forms.Padding(3);
            this._lblDescription.Name = "_lblDescription";
            this._lblDescription.Size = new System.Drawing.Size(63, 12);
            this._lblDescription.TabIndex = 0;
            this._lblDescription.Text = "Description:";
            this._lblDescription.Click += new System.EventHandler(this._lblDescription_Click);
            // 
            // _pnlMain
            // 
            this._pnlMain.Controls.Add(this._pnlZoomControl);
            this._pnlMain.Controls.Add(this._diagramView);
            this._pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMain.Location = new System.Drawing.Point(237, 50);
            this._pnlMain.Name = "_pnlMain";
            this._pnlMain.Size = new System.Drawing.Size(463, 400);
            this._pnlMain.TabIndex = 3;
            // 
            // _pnlZoomControl
            // 
            this._pnlZoomControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._pnlZoomControl.Controls.Add(this._btnZoomIn);
            this._pnlZoomControl.Controls.Add(this._btnZoomOut);
            this._pnlZoomControl.Location = new System.Drawing.Point(383, 373);
            this._pnlZoomControl.Name = "_pnlZoomControl";
            this._pnlZoomControl.Size = new System.Drawing.Size(80, 27);
            this._pnlZoomControl.TabIndex = 8;
            // 
            // _btnZoomIn
            // 
            this._btnZoomIn.FlatAppearance.BorderSize = 0;
            this._btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnZoomIn.Image = global::IntelligentDiagramCreator.Properties.Resources.ZoomOut;
            this._btnZoomIn.Location = new System.Drawing.Point(1, 0);
            this._btnZoomIn.Name = "_btnZoomIn";
            this._btnZoomIn.Size = new System.Drawing.Size(27, 27);
            this._btnZoomIn.TabIndex = 1;
            this._toolTip.SetToolTip(this._btnZoomIn, "Zoom In");
            this._btnZoomIn.UseVisualStyleBackColor = true;
            this._btnZoomIn.Click += new System.EventHandler(this._btnZoomIn_Click);
            // 
            // _btnZoomOut
            // 
            this._btnZoomOut.FlatAppearance.BorderSize = 0;
            this._btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnZoomOut.Image = global::IntelligentDiagramCreator.Properties.Resources.ZoomIn;
            this._btnZoomOut.Location = new System.Drawing.Point(53, 0);
            this._btnZoomOut.Name = "_btnZoomOut";
            this._btnZoomOut.Size = new System.Drawing.Size(27, 27);
            this._btnZoomOut.TabIndex = 0;
            this._toolTip.SetToolTip(this._btnZoomOut, "Zoom Out");
            this._btnZoomOut.UseVisualStyleBackColor = true;
            this._btnZoomOut.Click += new System.EventHandler(this._btnZoomOut_Click);
            // 
            // _diagramView
            // 
            this._diagramView.AllowDrop = true;
            this._diagramView.AutoScroll = false;
            this._diagramView.BackColor = System.Drawing.Color.White;
            this._diagramView.Behavior = MindFusion.Diagramming.Behavior.DrawLinks;
            this._diagramView.Diagram = this._diagram;
            this._diagramView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._diagramView.LicenseKey = null;
            this._diagramView.Location = new System.Drawing.Point(0, 0);
            this._diagramView.Name = "_diagramView";
            this._diagramView.ScrollZoneSize = 0;
            this._diagramView.ShowScrollbars = false;
            this._diagramView.Size = new System.Drawing.Size(463, 400);
            this._diagramView.TabIndex = 7;
            this._diagramView.Text = "diagramView";
            this._diagramView.DragDrop += new System.Windows.Forms.DragEventHandler(this._diagramView_DragDrop);
            this._diagramView.DragOver += new System.Windows.Forms.DragEventHandler(this._diagramView_DragOver);
            // 
            // _diagram
            // 
            this._diagram.AlignmentGuidePen = null;
            this._diagram.BackBrush = new MindFusion.Drawing.SolidBrush("#FFFFFFFF");
            this._diagram.DiagramLinkStyle.Brush = new MindFusion.Drawing.SolidBrush("#FFFFFFFF");
            this._diagram.DiagramStyle.ShadowBrush = new MindFusion.Drawing.SolidBrush("#64000000");
            this._diagram.GridColor = System.Drawing.Color.Black;
            this._diagram.LinkBaseShapeSize = 3F;
            this._diagram.LinkCrossings = MindFusion.Diagramming.LinkCrossings.Arcs;
            this._diagram.LinkHeadShapeSize = 3F;
            this._diagram.LinkIntermediateShapeSize = 3F;
            this._diagram.LinkTextStyle = MindFusion.Diagramming.LinkTextStyle.MiddleSegment;
            this._diagram.ShapeNodeStyle.Brush = new MindFusion.Drawing.SolidBrush("#FF00BFFF");
            this._diagram.SnapToAnchor = MindFusion.Diagramming.SnapToAnchor.OnCreateOrModify;
            this._diagram.TouchThreshold = 0F;
            this._diagram.NodeActivated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this._diagram_NodeActivated);
            this._diagram.NodeDeactivated += new System.EventHandler<MindFusion.Diagramming.NodeEventArgs>(this._diagram_NodeDeactivated);
            // 
            // _hidden
            // 
            this._hidden.BackBrush = new MindFusion.Drawing.SolidBrush("#FFFFFFFF");
            this._hidden.LinkBaseShapeSize = 12F;
            this._hidden.LinkHeadShapeSize = 12F;
            this._hidden.LinkIntermediateShapeSize = 12F;
            this._hidden.MeasureUnit = MindFusion.Diagramming.MeasureUnit.Pixel;
            this._hidden.RoutingOptions.GridSize = 16F;
            this._hidden.RoutingOptions.NodeVicinitySize = 48F;
            this._hidden.SelectAfterCreate = false;
            this._hidden.ShapeNodeStyle.Brush = new MindFusion.Drawing.SolidBrush("#FF00BFFF");
            this._hidden.TouchThreshold = 0F;
            // 
            // _saveFileDialog
            // 
            this._saveFileDialog.DefaultExt = "fcs";
            this._saveFileDialog.FileName = "Flowchart";
            this._saveFileDialog.Filter = "FlowCharter documents|*.fcs|All files|*.*";
            this._saveFileDialog.Title = "Save document";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(251)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this._pnlMain);
            this.Controls.Add(this._pnlLeft);
            this.Controls.Add(this._pnlTop);
            this.Controls.Add(this._lblDiagramID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Intelligent Diagram Creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this._pnlTop.ResumeLayout(false);
            this._pnlLeft.ResumeLayout(false);
            this._pnlLeft.PerformLayout();
            this._mainTab.ResumeLayout(false);
            this._mainNodesTab.ResumeLayout(false);
            this._mainConnectionsTab.ResumeLayout(false);
            this._mainPropertiesTab.ResumeLayout(false);
            this._pnlMain.ResumeLayout(false);
            this._pnlZoomControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblDiagramID;
        private Bunifu.Framework.UI.BunifuDragControl _dragControler;
        private System.Windows.Forms.Panel _pnlTop;
        private System.Windows.Forms.Button _btnMinimize;
        private System.Windows.Forms.Button _btnRestoreDown;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnHome;
        private System.Windows.Forms.Button _btnRedo;
        private System.Windows.Forms.Button _btnUndo;
        private System.Windows.Forms.Button _btnPrint;
        private System.Windows.Forms.Button _btnPrintPreview;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnGeneratePseudoCode;
        private System.Windows.Forms.TableLayoutPanel _pnlLeft;
        private System.Windows.Forms.Label _lblDescription;
        private System.Windows.Forms.RichTextBox _descriptionTextbox;
        private System.Windows.Forms.TabControl _mainTab;
        private System.Windows.Forms.TabPage _mainNodesTab;
        private System.Windows.Forms.ListBox _nodesListBox;
        private System.Windows.Forms.TabPage _mainConnectionsTab;
        private System.Windows.Forms.ListBox _connectionsListbox;
        private System.Windows.Forms.ComboBox _connectionsTypeCombobox;
        private System.Windows.Forms.TabPage _mainPropertiesTab;
        private System.Windows.Forms.PropertyGrid _propertiesGridbox;
        private System.Windows.Forms.Panel _pnlMain;
        private Diagram _diagram;
        private MindFusion.Diagramming.WinForms.DiagramView _diagramView;
        private MindFusion.Diagramming.Diagram _hidden;
        private System.Windows.Forms.SaveFileDialog _saveFileDialog;
        private System.Windows.Forms.Panel _pnlZoomControl;
        private System.Windows.Forms.Button _btnZoomIn;
        private System.Windows.Forms.Button _btnZoomOut;
        private System.Windows.Forms.ToolTip _toolTip;
    }
}