﻿namespace GraphFilter
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listInvResults = new System.Windows.Forms.DataGridView();
            this.ColunaInvariant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.enableIsAcyclic = new System.Windows.Forms.CheckBox();
            this.enableIsHamiltonian = new System.Windows.Forms.CheckBox();
            this.enableIsPlanar = new System.Windows.Forms.CheckBox();
            this.paramRegularWithDegree = new MetroFramework.Controls.MetroTextBox();
            this.enableIsConnected = new System.Windows.Forms.CheckBox();
            this.enableRegular = new System.Windows.Forms.CheckBox();
            this.enableRegularWithK = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxEq = new System.Windows.Forms.GroupBox();
            this.verifyEq3 = new System.Windows.Forms.Button();
            this.verifyEq2 = new System.Windows.Forms.Button();
            this.verifyEq1 = new System.Windows.Forms.Button();
            this.textEquation3 = new MetroFramework.Controls.MetroTextBox();
            this.textEquation2 = new MetroFramework.Controls.MetroTextBox();
            this.textEquation1 = new MetroFramework.Controls.MetroTextBox();
            this.enableEq3 = new System.Windows.Forms.CheckBox();
            this.enableEq2 = new System.Windows.Forms.CheckBox();
            this.enableEq1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExp2PNG = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonZoomOriginal = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.listOfG6 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.listOfG6Exp = new System.Windows.Forms.ListBox();
            this.buttonSavePNG = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ListOfInvariants = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.textOutPath = new MetroFramework.Controls.MetroTextBox();
            this.textSource = new MetroFramework.Controls.MetroTextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.openG6BtnViz = new MetroFramework.Controls.MetroButton();
            this.viewG6Btn = new MetroFramework.Controls.MetroButton();
            this.insertG6ToView = new MetroFramework.Controls.MetroTextBox();
            this.showInvariantsCheck = new MetroFramework.Controls.MetroCheckBox();
            this.textOpenViz = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.textOpenExp = new MetroFramework.Controls.MetroTextBox();
            this.version = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listInvResults)).BeginInit();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxEq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBoxFiles.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listInvResults
            // 
            this.listInvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listInvResults.BackgroundColor = System.Drawing.Color.White;
            this.listInvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listInvResults.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listInvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listInvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaInvariant,
            this.ColunaResultado});
            this.listInvResults.Location = new System.Drawing.Point(204, 307);
            this.listInvResults.MinimumSize = new System.Drawing.Size(430, 200);
            this.listInvResults.MultiSelect = false;
            this.listInvResults.Name = "listInvResults";
            this.listInvResults.RowHeadersWidth = 51;
            this.listInvResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.listInvResults.RowTemplate.Height = 24;
            this.listInvResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listInvResults.ShowRowErrors = false;
            this.listInvResults.Size = new System.Drawing.Size(430, 340);
            this.listInvResults.TabIndex = 0;
            this.listInvResults.Visible = false;
            this.listInvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listInvResults_CellContentClick);
            // 
            // ColunaInvariant
            // 
            this.ColunaInvariant.HeaderText = "Invariant";
            this.ColunaInvariant.MinimumWidth = 6;
            this.ColunaInvariant.Name = "ColunaInvariant";
            this.ColunaInvariant.Width = 125;
            // 
            // ColunaResultado
            // 
            this.ColunaResultado.HeaderText = "Result";
            this.ColunaResultado.MinimumWidth = 6;
            this.ColunaResultado.Name = "ColunaResultado";
            this.ColunaResultado.Width = 125;
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxCondition.Controls.Add(this.enableIsAcyclic);
            this.groupBoxCondition.Controls.Add(this.enableIsHamiltonian);
            this.groupBoxCondition.Controls.Add(this.enableIsPlanar);
            this.groupBoxCondition.Controls.Add(this.paramRegularWithDegree);
            this.groupBoxCondition.Controls.Add(this.enableIsConnected);
            this.groupBoxCondition.Controls.Add(this.enableRegular);
            this.groupBoxCondition.Controls.Add(this.enableRegularWithK);
            this.groupBoxCondition.Location = new System.Drawing.Point(0, 103);
            this.groupBoxCondition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCondition.Size = new System.Drawing.Size(585, 158);
            this.groupBoxCondition.TabIndex = 8;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Condition";
            // 
            // enableIsAcyclic
            // 
            this.enableIsAcyclic.AutoSize = true;
            this.enableIsAcyclic.Location = new System.Drawing.Point(356, 85);
            this.enableIsAcyclic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableIsAcyclic.Name = "enableIsAcyclic";
            this.enableIsAcyclic.Size = new System.Drawing.Size(73, 21);
            this.enableIsAcyclic.TabIndex = 53;
            this.enableIsAcyclic.Text = "Acyclic";
            this.enableIsAcyclic.UseVisualStyleBackColor = true;
            this.enableIsAcyclic.CheckedChanged += new System.EventHandler(this.enableIsAcyclic_CheckedChanged);
            // 
            // enableIsHamiltonian
            // 
            this.enableIsHamiltonian.AutoSize = true;
            this.enableIsHamiltonian.Location = new System.Drawing.Point(356, 31);
            this.enableIsHamiltonian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableIsHamiltonian.Name = "enableIsHamiltonian";
            this.enableIsHamiltonian.Size = new System.Drawing.Size(104, 21);
            this.enableIsHamiltonian.TabIndex = 52;
            this.enableIsHamiltonian.Text = "Hamiltonian";
            this.enableIsHamiltonian.UseVisualStyleBackColor = true;
            // 
            // enableIsPlanar
            // 
            this.enableIsPlanar.AutoSize = true;
            this.enableIsPlanar.Location = new System.Drawing.Point(356, 58);
            this.enableIsPlanar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableIsPlanar.Name = "enableIsPlanar";
            this.enableIsPlanar.Size = new System.Drawing.Size(71, 21);
            this.enableIsPlanar.TabIndex = 51;
            this.enableIsPlanar.Text = "Planar";
            this.enableIsPlanar.UseVisualStyleBackColor = true;
            this.enableIsPlanar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // paramRegularWithDegree
            // 
            // 
            // 
            // 
            this.paramRegularWithDegree.CustomButton.Image = null;
            this.paramRegularWithDegree.CustomButton.Location = new System.Drawing.Point(15, 1);
            this.paramRegularWithDegree.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.paramRegularWithDegree.CustomButton.Name = "";
            this.paramRegularWithDegree.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.paramRegularWithDegree.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.paramRegularWithDegree.CustomButton.TabIndex = 1;
            this.paramRegularWithDegree.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.paramRegularWithDegree.CustomButton.UseSelectable = true;
            this.paramRegularWithDegree.CustomButton.Visible = false;
            this.paramRegularWithDegree.Enabled = false;
            this.paramRegularWithDegree.Lines = new string[0];
            this.paramRegularWithDegree.Location = new System.Drawing.Point(205, 58);
            this.paramRegularWithDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paramRegularWithDegree.MaxLength = 32767;
            this.paramRegularWithDegree.Name = "paramRegularWithDegree";
            this.paramRegularWithDegree.PasswordChar = '\0';
            this.paramRegularWithDegree.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.paramRegularWithDegree.SelectedText = "";
            this.paramRegularWithDegree.SelectionLength = 0;
            this.paramRegularWithDegree.SelectionStart = 0;
            this.paramRegularWithDegree.ShortcutsEnabled = true;
            this.paramRegularWithDegree.Size = new System.Drawing.Size(37, 23);
            this.paramRegularWithDegree.TabIndex = 50;
            this.paramRegularWithDegree.UseSelectable = true;
            this.paramRegularWithDegree.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.paramRegularWithDegree.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // enableIsConnected
            // 
            this.enableIsConnected.AutoSize = true;
            this.enableIsConnected.Location = new System.Drawing.Point(11, 85);
            this.enableIsConnected.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableIsConnected.Name = "enableIsConnected";
            this.enableIsConnected.Size = new System.Drawing.Size(98, 21);
            this.enableIsConnected.TabIndex = 49;
            this.enableIsConnected.Text = "Connected";
            this.enableIsConnected.UseVisualStyleBackColor = true;
            this.enableIsConnected.CheckedChanged += new System.EventHandler(this.enableIsConnected_CheckedChanged);
            // 
            // enableRegular
            // 
            this.enableRegular.AutoSize = true;
            this.enableRegular.Location = new System.Drawing.Point(11, 31);
            this.enableRegular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableRegular.Name = "enableRegular";
            this.enableRegular.Size = new System.Drawing.Size(80, 21);
            this.enableRegular.TabIndex = 47;
            this.enableRegular.Text = "Regular";
            this.enableRegular.UseVisualStyleBackColor = true;
            this.enableRegular.CheckedChanged += new System.EventHandler(this.enableRegular_CheckedChanged_1);
            // 
            // enableRegularWithK
            // 
            this.enableRegularWithK.AutoSize = true;
            this.enableRegularWithK.Location = new System.Drawing.Point(11, 58);
            this.enableRegularWithK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableRegularWithK.Name = "enableRegularWithK";
            this.enableRegularWithK.Size = new System.Drawing.Size(153, 21);
            this.enableRegularWithK.TabIndex = 48;
            this.enableRegularWithK.Text = "Regular with Order:";
            this.enableRegularWithK.UseVisualStyleBackColor = true;
            this.enableRegularWithK.CheckedChanged += new System.EventHandler(this.enableRegularWithK_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(5, 58);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 30);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Output .g6 File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(5, 414);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 39);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Run";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.EnabledChanged += new System.EventHandler(this.buttonSearch_EnabledChanged);
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // groupBoxEq
            // 
            this.groupBoxEq.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxEq.Controls.Add(this.verifyEq3);
            this.groupBoxEq.Controls.Add(this.verifyEq2);
            this.groupBoxEq.Controls.Add(this.verifyEq1);
            this.groupBoxEq.Controls.Add(this.textEquation3);
            this.groupBoxEq.Controls.Add(this.textEquation2);
            this.groupBoxEq.Controls.Add(this.textEquation1);
            this.groupBoxEq.Controls.Add(this.enableEq3);
            this.groupBoxEq.Controls.Add(this.enableEq2);
            this.groupBoxEq.Controls.Add(this.enableEq1);
            this.groupBoxEq.Controls.Add(this.label6);
            this.groupBoxEq.Location = new System.Drawing.Point(0, 277);
            this.groupBoxEq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEq.Name = "groupBoxEq";
            this.groupBoxEq.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxEq.Size = new System.Drawing.Size(585, 132);
            this.groupBoxEq.TabIndex = 7;
            this.groupBoxEq.TabStop = false;
            this.groupBoxEq.Text = "Equations";
            // 
            // verifyEq3
            // 
            this.verifyEq3.Enabled = false;
            this.verifyEq3.FlatAppearance.BorderSize = 0;
            this.verifyEq3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyEq3.Image = global::GraphFilter.Properties.Resources.icons8_checked_checkbox;
            this.verifyEq3.Location = new System.Drawing.Point(37, 92);
            this.verifyEq3.Margin = new System.Windows.Forms.Padding(0);
            this.verifyEq3.MaximumSize = new System.Drawing.Size(36, 36);
            this.verifyEq3.MinimumSize = new System.Drawing.Size(36, 36);
            this.verifyEq3.Name = "verifyEq3";
            this.verifyEq3.Size = new System.Drawing.Size(36, 36);
            this.verifyEq3.TabIndex = 57;
            this.verifyEq3.UseVisualStyleBackColor = true;
            this.verifyEq3.Click += new System.EventHandler(this.verifyEq3_Click);
            // 
            // verifyEq2
            // 
            this.verifyEq2.Enabled = false;
            this.verifyEq2.FlatAppearance.BorderSize = 0;
            this.verifyEq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyEq2.Image = global::GraphFilter.Properties.Resources.icons8_checked_checkbox;
            this.verifyEq2.Location = new System.Drawing.Point(37, 57);
            this.verifyEq2.Margin = new System.Windows.Forms.Padding(0);
            this.verifyEq2.MaximumSize = new System.Drawing.Size(36, 36);
            this.verifyEq2.MinimumSize = new System.Drawing.Size(36, 36);
            this.verifyEq2.Name = "verifyEq2";
            this.verifyEq2.Size = new System.Drawing.Size(36, 36);
            this.verifyEq2.TabIndex = 56;
            this.verifyEq2.UseVisualStyleBackColor = true;
            this.verifyEq2.Click += new System.EventHandler(this.verifyEq2_Click);
            // 
            // verifyEq1
            // 
            this.verifyEq1.Enabled = false;
            this.verifyEq1.FlatAppearance.BorderSize = 0;
            this.verifyEq1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyEq1.Image = global::GraphFilter.Properties.Resources.icons8_checked_checkbox;
            this.verifyEq1.Location = new System.Drawing.Point(37, 22);
            this.verifyEq1.Margin = new System.Windows.Forms.Padding(0);
            this.verifyEq1.MaximumSize = new System.Drawing.Size(36, 36);
            this.verifyEq1.MinimumSize = new System.Drawing.Size(36, 36);
            this.verifyEq1.Name = "verifyEq1";
            this.verifyEq1.Size = new System.Drawing.Size(36, 36);
            this.verifyEq1.TabIndex = 0;
            this.verifyEq1.UseVisualStyleBackColor = true;
            this.verifyEq1.Click += new System.EventHandler(this.verifyEq1_Click);
            // 
            // textEquation3
            // 
            // 
            // 
            // 
            this.textEquation3.CustomButton.Image = null;
            this.textEquation3.CustomButton.Location = new System.Drawing.Point(477, 1);
            this.textEquation3.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEquation3.CustomButton.Name = "";
            this.textEquation3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textEquation3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEquation3.CustomButton.TabIndex = 1;
            this.textEquation3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEquation3.CustomButton.UseSelectable = true;
            this.textEquation3.CustomButton.Visible = false;
            this.textEquation3.Enabled = false;
            this.textEquation3.Lines = new string[0];
            this.textEquation3.Location = new System.Drawing.Point(79, 97);
            this.textEquation3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEquation3.MaxLength = 32767;
            this.textEquation3.Name = "textEquation3";
            this.textEquation3.PasswordChar = '\0';
            this.textEquation3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEquation3.SelectedText = "";
            this.textEquation3.SelectionLength = 0;
            this.textEquation3.SelectionStart = 0;
            this.textEquation3.ShortcutsEnabled = true;
            this.textEquation3.Size = new System.Drawing.Size(499, 23);
            this.textEquation3.TabIndex = 59;
            this.textEquation3.UseSelectable = true;
            this.textEquation3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEquation3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textEquation2
            // 
            // 
            // 
            // 
            this.textEquation2.CustomButton.Image = null;
            this.textEquation2.CustomButton.Location = new System.Drawing.Point(477, 1);
            this.textEquation2.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEquation2.CustomButton.Name = "";
            this.textEquation2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textEquation2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEquation2.CustomButton.TabIndex = 1;
            this.textEquation2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEquation2.CustomButton.UseSelectable = true;
            this.textEquation2.CustomButton.Visible = false;
            this.textEquation2.Enabled = false;
            this.textEquation2.Lines = new string[0];
            this.textEquation2.Location = new System.Drawing.Point(79, 66);
            this.textEquation2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEquation2.MaxLength = 32767;
            this.textEquation2.Name = "textEquation2";
            this.textEquation2.PasswordChar = '\0';
            this.textEquation2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEquation2.SelectedText = "";
            this.textEquation2.SelectionLength = 0;
            this.textEquation2.SelectionStart = 0;
            this.textEquation2.ShortcutsEnabled = true;
            this.textEquation2.Size = new System.Drawing.Size(499, 23);
            this.textEquation2.TabIndex = 58;
            this.textEquation2.UseSelectable = true;
            this.textEquation2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEquation2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textEquation1
            // 
            // 
            // 
            // 
            this.textEquation1.CustomButton.Image = null;
            this.textEquation1.CustomButton.Location = new System.Drawing.Point(477, 1);
            this.textEquation1.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textEquation1.CustomButton.Name = "";
            this.textEquation1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textEquation1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEquation1.CustomButton.TabIndex = 1;
            this.textEquation1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEquation1.CustomButton.UseSelectable = true;
            this.textEquation1.CustomButton.Visible = false;
            this.textEquation1.Enabled = false;
            this.textEquation1.Lines = new string[0];
            this.textEquation1.Location = new System.Drawing.Point(79, 31);
            this.textEquation1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEquation1.MaxLength = 32767;
            this.textEquation1.Name = "textEquation1";
            this.textEquation1.PasswordChar = '\0';
            this.textEquation1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textEquation1.SelectedText = "";
            this.textEquation1.SelectionLength = 0;
            this.textEquation1.SelectionStart = 0;
            this.textEquation1.ShortcutsEnabled = true;
            this.textEquation1.Size = new System.Drawing.Size(499, 23);
            this.textEquation1.TabIndex = 1;
            this.textEquation1.UseSelectable = true;
            this.textEquation1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textEquation1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // enableEq3
            // 
            this.enableEq3.AutoSize = true;
            this.enableEq3.Location = new System.Drawing.Point(11, 103);
            this.enableEq3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableEq3.Name = "enableEq3";
            this.enableEq3.Size = new System.Drawing.Size(18, 17);
            this.enableEq3.TabIndex = 44;
            this.enableEq3.UseVisualStyleBackColor = true;
            this.enableEq3.CheckedChanged += new System.EventHandler(this.enableEq3_CheckedChanged);
            // 
            // enableEq2
            // 
            this.enableEq2.AutoSize = true;
            this.enableEq2.Location = new System.Drawing.Point(11, 68);
            this.enableEq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableEq2.Name = "enableEq2";
            this.enableEq2.Size = new System.Drawing.Size(18, 17);
            this.enableEq2.TabIndex = 34;
            this.enableEq2.UseVisualStyleBackColor = true;
            this.enableEq2.CheckedChanged += new System.EventHandler(this.EnableEq2_CheckedChanged);
            // 
            // enableEq1
            // 
            this.enableEq1.AutoSize = true;
            this.enableEq1.Location = new System.Drawing.Point(11, 34);
            this.enableEq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enableEq1.Name = "enableEq1";
            this.enableEq1.Size = new System.Drawing.Size(18, 17);
            this.enableEq1.TabIndex = 8;
            this.enableEq1.UseVisualStyleBackColor = true;
            this.enableEq1.CheckedChanged += new System.EventHandler(this.EnableEq1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 10;
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.White;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Image = global::GraphFilter.Properties.Resources.icons8_export_pdf;
            this.buttonPrint.Location = new System.Drawing.Point(255, 75);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrint.MaximumSize = new System.Drawing.Size(51, 50);
            this.buttonPrint.MinimumSize = new System.Drawing.Size(51, 50);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(51, 50);
            this.buttonPrint.TabIndex = 45;
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonExp2PNG
            // 
            this.buttonExp2PNG.BackColor = System.Drawing.Color.White;
            this.buttonExp2PNG.FlatAppearance.BorderSize = 0;
            this.buttonExp2PNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExp2PNG.Image = global::GraphFilter.Properties.Resources.icons8_png;
            this.buttonExp2PNG.Location = new System.Drawing.Point(205, 75);
            this.buttonExp2PNG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExp2PNG.MaximumSize = new System.Drawing.Size(51, 50);
            this.buttonExp2PNG.MinimumSize = new System.Drawing.Size(51, 50);
            this.buttonExp2PNG.Name = "buttonExp2PNG";
            this.buttonExp2PNG.Size = new System.Drawing.Size(51, 50);
            this.buttonExp2PNG.TabIndex = 45;
            this.buttonExp2PNG.UseVisualStyleBackColor = false;
            this.buttonExp2PNG.Click += new System.EventHandler(this.buttonExp2PNG_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.BackColor = System.Drawing.Color.White;
            this.buttonZoomIn.FlatAppearance.BorderSize = 0;
            this.buttonZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomIn.Image = global::GraphFilter.Properties.Resources.icons8_zoom_in;
            this.buttonZoomIn.Location = new System.Drawing.Point(155, 75);
            this.buttonZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomIn.MaximumSize = new System.Drawing.Size(51, 50);
            this.buttonZoomIn.MinimumSize = new System.Drawing.Size(51, 50);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(51, 50);
            this.buttonZoomIn.TabIndex = 45;
            this.buttonZoomIn.UseVisualStyleBackColor = false;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOriginal
            // 
            this.buttonZoomOriginal.BackColor = System.Drawing.Color.White;
            this.buttonZoomOriginal.FlatAppearance.BorderSize = 0;
            this.buttonZoomOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOriginal.Image = global::GraphFilter.Properties.Resources.icons8_zoom_to_actual_size;
            this.buttonZoomOriginal.Location = new System.Drawing.Point(55, 75);
            this.buttonZoomOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOriginal.MaximumSize = new System.Drawing.Size(51, 50);
            this.buttonZoomOriginal.MinimumSize = new System.Drawing.Size(51, 50);
            this.buttonZoomOriginal.Name = "buttonZoomOriginal";
            this.buttonZoomOriginal.Size = new System.Drawing.Size(51, 50);
            this.buttonZoomOriginal.TabIndex = 55;
            this.buttonZoomOriginal.UseVisualStyleBackColor = false;
            this.buttonZoomOriginal.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.BackColor = System.Drawing.Color.White;
            this.buttonZoomOut.FlatAppearance.BorderSize = 0;
            this.buttonZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOut.Image = global::GraphFilter.Properties.Resources.icons8_zoom_out;
            this.buttonZoomOut.Location = new System.Drawing.Point(105, 75);
            this.buttonZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOut.MaximumSize = new System.Drawing.Size(51, 50);
            this.buttonZoomOut.MinimumSize = new System.Drawing.Size(51, 50);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(51, 50);
            this.buttonZoomOut.TabIndex = 54;
            this.buttonZoomOut.UseVisualStyleBackColor = false;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click_1);
            // 
            // buttonFill
            // 
            this.buttonFill.BackColor = System.Drawing.Color.White;
            this.buttonFill.FlatAppearance.BorderSize = 0;
            this.buttonFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFill.Image = global::GraphFilter.Properties.Resources.icons8_zoom_to_extents_2;
            this.buttonFill.Location = new System.Drawing.Point(5, 75);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFill.MaximumSize = new System.Drawing.Size(51, 50);
            this.buttonFill.MinimumSize = new System.Drawing.Size(51, 50);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(51, 50);
            this.buttonFill.TabIndex = 53;
            this.buttonFill.UseVisualStyleBackColor = false;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // wpfHost
            // 
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(205, 86);
            this.wpfHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(643, 388);
            this.wpfHost.TabIndex = 52;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.wpfHost_ChildChanged);
            this.wpfHost.Child = null;
            // 
            // listOfG6
            // 
            this.listOfG6.FormattingEnabled = true;
            this.listOfG6.HorizontalScrollbar = true;
            this.listOfG6.ItemHeight = 16;
            this.listOfG6.Location = new System.Drawing.Point(5, 134);
            this.listOfG6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOfG6.Name = "listOfG6";
            this.listOfG6.Size = new System.Drawing.Size(193, 340);
            this.listOfG6.TabIndex = 0;
            this.listOfG6.Visible = false;
            this.listOfG6.SelectedIndexChanged += new System.EventHandler(this.listOfG6_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(231, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 369);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // elementHost
            // 
            this.elementHost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost.BackColor = System.Drawing.Color.White;
            this.elementHost.Enabled = false;
            this.elementHost.Location = new System.Drawing.Point(231, 71);
            this.elementHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.elementHost.Name = "elementHost";
            this.elementHost.Size = new System.Drawing.Size(643, 369);
            this.elementHost.TabIndex = 7;
            this.elementHost.Text = "elementHost1";
            this.elementHost.Child = null;
            // 
            // listOfG6Exp
            // 
            this.listOfG6Exp.Enabled = false;
            this.listOfG6Exp.FormattingEnabled = true;
            this.listOfG6Exp.ItemHeight = 16;
            this.listOfG6Exp.Location = new System.Drawing.Point(3, 75);
            this.listOfG6Exp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOfG6Exp.Name = "listOfG6Exp";
            this.listOfG6Exp.Size = new System.Drawing.Size(192, 372);
            this.listOfG6Exp.TabIndex = 6;
            this.listOfG6Exp.SelectedIndexChanged += new System.EventHandler(this.listOfG6Exp_SelectedIndexChanged);
            // 
            // buttonSavePNG
            // 
            this.buttonSavePNG.Location = new System.Drawing.Point(0, 39);
            this.buttonSavePNG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSavePNG.Name = "buttonSavePNG";
            this.buttonSavePNG.Size = new System.Drawing.Size(195, 30);
            this.buttonSavePNG.TabIndex = 3;
            this.buttonSavePNG.Text = "Export to PNG";
            this.buttonSavePNG.UseVisualStyleBackColor = true;
            this.buttonSavePNG.Click += new System.EventHandler(this.buttonSavePNG_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open .g6 File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.Controls.Add(this.metroTabPage3);
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabControl.Location = new System.Drawing.Point(23, 71);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.Size = new System.Drawing.Size(1277, 715);
            this.tabControl.TabIndex = 52;
            this.tabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ListOfInvariants);
            this.metroTabPage1.Controls.Add(this.progressBar);
            this.metroTabPage1.Controls.Add(this.groupBoxFiles);
            this.metroTabPage1.Controls.Add(this.groupBoxCondition);
            this.metroTabPage1.Controls.Add(this.buttonSearch);
            this.metroTabPage1.Controls.Add(this.groupBoxEq);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1269, 674);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Filter Graphs";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 11;
            // 
            // ListOfInvariants
            // 
            this.ListOfInvariants.AutoSize = true;
            this.ListOfInvariants.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListOfInvariants.Location = new System.Drawing.Point(1208, 0);
            this.ListOfInvariants.Name = "ListOfInvariants";
            this.ListOfInvariants.Size = new System.Drawing.Size(61, 20);
            this.ListOfInvariants.TabIndex = 2;
            this.ListOfInvariants.Text = "Invariant";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(151, 414);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(435, 39);
            this.progressBar.TabIndex = 52;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFiles.Controls.Add(this.textOutPath);
            this.groupBoxFiles.Controls.Add(this.textSource);
            this.groupBoxFiles.Controls.Add(this.buttonOpen);
            this.groupBoxFiles.Controls.Add(this.buttonSave);
            this.groupBoxFiles.Location = new System.Drawing.Point(0, 2);
            this.groupBoxFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFiles.Name = "groupBoxFiles";
            this.groupBoxFiles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFiles.Size = new System.Drawing.Size(585, 100);
            this.groupBoxFiles.TabIndex = 1;
            this.groupBoxFiles.TabStop = false;
            this.groupBoxFiles.Text = "Files";
            // 
            // textOutPath
            // 
            // 
            // 
            // 
            this.textOutPath.CustomButton.Image = null;
            this.textOutPath.CustomButton.Location = new System.Drawing.Point(405, 1);
            this.textOutPath.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textOutPath.CustomButton.Name = "";
            this.textOutPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textOutPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textOutPath.CustomButton.TabIndex = 1;
            this.textOutPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textOutPath.CustomButton.UseSelectable = true;
            this.textOutPath.CustomButton.Visible = false;
            this.textOutPath.Enabled = false;
            this.textOutPath.Lines = new string[0];
            this.textOutPath.Location = new System.Drawing.Point(151, 62);
            this.textOutPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textOutPath.MaxLength = 32767;
            this.textOutPath.Name = "textOutPath";
            this.textOutPath.PasswordChar = '\0';
            this.textOutPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textOutPath.SelectedText = "";
            this.textOutPath.SelectionLength = 0;
            this.textOutPath.SelectionStart = 0;
            this.textOutPath.ShortcutsEnabled = true;
            this.textOutPath.Size = new System.Drawing.Size(427, 23);
            this.textOutPath.TabIndex = 53;
            this.textOutPath.UseSelectable = true;
            this.textOutPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textOutPath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textSource
            // 
            // 
            // 
            // 
            this.textSource.CustomButton.Image = null;
            this.textSource.CustomButton.Location = new System.Drawing.Point(405, 1);
            this.textSource.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textSource.CustomButton.Name = "";
            this.textSource.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textSource.CustomButton.TabIndex = 1;
            this.textSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textSource.CustomButton.UseSelectable = true;
            this.textSource.CustomButton.Visible = false;
            this.textSource.Enabled = false;
            this.textSource.Lines = new string[0];
            this.textSource.Location = new System.Drawing.Point(151, 27);
            this.textSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textSource.MaxLength = 32767;
            this.textSource.Name = "textSource";
            this.textSource.PasswordChar = '\0';
            this.textSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textSource.SelectedText = "";
            this.textSource.SelectionLength = 0;
            this.textSource.SelectionStart = 0;
            this.textSource.ShortcutsEnabled = true;
            this.textSource.Size = new System.Drawing.Size(427, 23);
            this.textSource.TabIndex = 52;
            this.textSource.UseSelectable = true;
            this.textSource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textSource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(5, 20);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 30);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open .g6 File";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.openG6BtnViz);
            this.metroTabPage2.Controls.Add(this.viewG6Btn);
            this.metroTabPage2.Controls.Add(this.insertG6ToView);
            this.metroTabPage2.Controls.Add(this.showInvariantsCheck);
            this.metroTabPage2.Controls.Add(this.listInvResults);
            this.metroTabPage2.Controls.Add(this.textOpenViz);
            this.metroTabPage2.Controls.Add(this.buttonFill);
            this.metroTabPage2.Controls.Add(this.buttonZoomOriginal);
            this.metroTabPage2.Controls.Add(this.buttonZoomOut);
            this.metroTabPage2.Controls.Add(this.buttonZoomIn);
            this.metroTabPage2.Controls.Add(this.buttonExp2PNG);
            this.metroTabPage2.Controls.Add(this.buttonPrint);
            this.metroTabPage2.Controls.Add(this.wpfHost);
            this.metroTabPage2.Controls.Add(this.listOfG6);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1269, 674);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Visualization";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 11;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // openG6BtnViz
            // 
            this.openG6BtnViz.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.openG6BtnViz.Location = new System.Drawing.Point(5, 45);
            this.openG6BtnViz.MaximumSize = new System.Drawing.Size(150, 25);
            this.openG6BtnViz.MinimumSize = new System.Drawing.Size(150, 25);
            this.openG6BtnViz.Name = "openG6BtnViz";
            this.openG6BtnViz.Size = new System.Drawing.Size(150, 25);
            this.openG6BtnViz.TabIndex = 60;
            this.openG6BtnViz.Text = "Open .g6 File";
            this.openG6BtnViz.UseSelectable = true;
            this.openG6BtnViz.Click += new System.EventHandler(this.openG6BtnViz_Click);
            // 
            // viewG6Btn
            // 
            this.viewG6Btn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.viewG6Btn.Location = new System.Drawing.Point(5, 17);
            this.viewG6Btn.MaximumSize = new System.Drawing.Size(150, 25);
            this.viewG6Btn.MinimumSize = new System.Drawing.Size(150, 25);
            this.viewG6Btn.Name = "viewG6Btn";
            this.viewG6Btn.Size = new System.Drawing.Size(150, 25);
            this.viewG6Btn.TabIndex = 59;
            this.viewG6Btn.Text = "View Graph";
            this.viewG6Btn.UseSelectable = true;
            this.viewG6Btn.Click += new System.EventHandler(this.viewG6Btn_Click);
            // 
            // insertG6ToView
            // 
            // 
            // 
            // 
            this.insertG6ToView.CustomButton.Image = null;
            this.insertG6ToView.CustomButton.Location = new System.Drawing.Point(1081, 1);
            this.insertG6ToView.CustomButton.Name = "";
            this.insertG6ToView.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.insertG6ToView.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.insertG6ToView.CustomButton.TabIndex = 1;
            this.insertG6ToView.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.insertG6ToView.CustomButton.UseSelectable = true;
            this.insertG6ToView.CustomButton.Visible = false;
            this.insertG6ToView.Lines = new string[0];
            this.insertG6ToView.Location = new System.Drawing.Point(161, 17);
            this.insertG6ToView.MaxLength = 32767;
            this.insertG6ToView.Name = "insertG6ToView";
            this.insertG6ToView.PasswordChar = '\0';
            this.insertG6ToView.PromptText = "Type a g6 code here!";
            this.insertG6ToView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.insertG6ToView.SelectedText = "";
            this.insertG6ToView.SelectionLength = 0;
            this.insertG6ToView.SelectionStart = 0;
            this.insertG6ToView.ShortcutsEnabled = true;
            this.insertG6ToView.Size = new System.Drawing.Size(1105, 25);
            this.insertG6ToView.TabIndex = 58;
            this.insertG6ToView.UseSelectable = true;
            this.insertG6ToView.WaterMark = "Type a g6 code here!";
            this.insertG6ToView.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.insertG6ToView.WaterMarkFont = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // showInvariantsCheck
            // 
            this.showInvariantsCheck.AutoSize = true;
            this.showInvariantsCheck.Location = new System.Drawing.Point(1112, 75);
            this.showInvariantsCheck.Name = "showInvariantsCheck";
            this.showInvariantsCheck.Size = new System.Drawing.Size(154, 17);
            this.showInvariantsCheck.TabIndex = 57;
            this.showInvariantsCheck.Text = "Show Graph Invariants";
            this.showInvariantsCheck.UseSelectable = true;
            this.showInvariantsCheck.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // textOpenViz
            // 
            // 
            // 
            // 
            this.textOpenViz.CustomButton.Image = null;
            this.textOpenViz.CustomButton.Location = new System.Drawing.Point(1082, 1);
            this.textOpenViz.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textOpenViz.CustomButton.Name = "";
            this.textOpenViz.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textOpenViz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textOpenViz.CustomButton.TabIndex = 1;
            this.textOpenViz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textOpenViz.CustomButton.UseSelectable = true;
            this.textOpenViz.CustomButton.Visible = false;
            this.textOpenViz.Enabled = false;
            this.textOpenViz.Lines = new string[0];
            this.textOpenViz.Location = new System.Drawing.Point(161, 45);
            this.textOpenViz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textOpenViz.MaxLength = 32767;
            this.textOpenViz.Name = "textOpenViz";
            this.textOpenViz.PasswordChar = '\0';
            this.textOpenViz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textOpenViz.SelectedText = "";
            this.textOpenViz.SelectionLength = 0;
            this.textOpenViz.SelectionStart = 0;
            this.textOpenViz.ShortcutsEnabled = true;
            this.textOpenViz.Size = new System.Drawing.Size(1106, 25);
            this.textOpenViz.TabIndex = 56;
            this.textOpenViz.UseSelectable = true;
            this.textOpenViz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textOpenViz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroProgressSpinner);
            this.metroTabPage3.Controls.Add(this.pictureBox1);
            this.metroTabPage3.Controls.Add(this.elementHost);
            this.metroTabPage3.Controls.Add(this.metroProgress);
            this.metroTabPage3.Controls.Add(this.textOpenExp);
            this.metroTabPage3.Controls.Add(this.listOfG6Exp);
            this.metroTabPage3.Controls.Add(this.button2);
            this.metroTabPage3.Controls.Add(this.buttonSavePNG);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1269, 674);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Export";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 11;
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressSpinner.Location = new System.Drawing.Point(645, 220);
            this.metroProgressSpinner.Margin = new System.Windows.Forms.Padding(0);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.MaximumSize = new System.Drawing.Size(293, 271);
            this.metroProgressSpinner.MinimumSize = new System.Drawing.Size(293, 271);
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(293, 271);
            this.metroProgressSpinner.Speed = 3F;
            this.metroProgressSpinner.TabIndex = 11;
            this.metroProgressSpinner.UseSelectable = true;
            this.metroProgressSpinner.Visible = false;
            // 
            // metroProgress
            // 
            this.metroProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroProgress.Location = new System.Drawing.Point(444, 162);
            this.metroProgress.Margin = new System.Windows.Forms.Padding(0);
            this.metroProgress.Maximum = 100;
            this.metroProgress.MaximumSize = new System.Drawing.Size(200, 199);
            this.metroProgress.MinimumSize = new System.Drawing.Size(200, 199);
            this.metroProgress.Name = "metroProgress";
            this.metroProgress.Size = new System.Drawing.Size(200, 199);
            this.metroProgress.TabIndex = 10;
            this.metroProgress.UseSelectable = true;
            this.metroProgress.Visible = false;
            // 
            // textOpenExp
            // 
            // 
            // 
            // 
            this.textOpenExp.CustomButton.Image = null;
            this.textOpenExp.CustomButton.Location = new System.Drawing.Point(727, 1);
            this.textOpenExp.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textOpenExp.CustomButton.Name = "";
            this.textOpenExp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textOpenExp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textOpenExp.CustomButton.TabIndex = 1;
            this.textOpenExp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textOpenExp.CustomButton.UseSelectable = true;
            this.textOpenExp.CustomButton.Visible = false;
            this.textOpenExp.Enabled = false;
            this.textOpenExp.Lines = new string[0];
            this.textOpenExp.Location = new System.Drawing.Point(200, 10);
            this.textOpenExp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textOpenExp.MaxLength = 32767;
            this.textOpenExp.Name = "textOpenExp";
            this.textOpenExp.PasswordChar = '\0';
            this.textOpenExp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textOpenExp.SelectedText = "";
            this.textOpenExp.SelectionLength = 0;
            this.textOpenExp.SelectionStart = 0;
            this.textOpenExp.ShortcutsEnabled = true;
            this.textOpenExp.Size = new System.Drawing.Size(749, 23);
            this.textOpenExp.TabIndex = 9;
            this.textOpenExp.UseSelectable = true;
            this.textOpenExp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textOpenExp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // version
            // 
            this.version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(1088, 57);
            this.version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(89, 20);
            this.version.TabIndex = 53;
            this.version.Text = "Version: 1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1696, 1047);
            this.Controls.Add(this.version);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Text = "Graph Filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.listInvResults)).EndInit();
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxEq.ResumeLayout(false);
            this.groupBoxEq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.groupBoxFiles.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCondition;
        public System.Windows.Forms.CheckBox enableIsConnected;
        public System.Windows.Forms.CheckBox enableRegular;
        public System.Windows.Forms.CheckBox enableRegularWithK;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxEq;
        public System.Windows.Forms.CheckBox enableEq3;
        public System.Windows.Forms.CheckBox enableEq2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listOfG6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSavePNG;
        private System.Windows.Forms.Integration.ElementHost wpfHost;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonZoomOriginal;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.ListBox listOfG6Exp;
        private System.Windows.Forms.Button buttonExp2PNG;
        private System.Windows.Forms.Integration.ElementHost elementHost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button verifyEq1;
        private System.Windows.Forms.Button verifyEq3;
        private System.Windows.Forms.Button verifyEq2;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.GroupBox groupBoxFiles;
        private MetroFramework.Controls.MetroTextBox textSource;
        private MetroFramework.Controls.MetroTextBox textOutPath;
        private System.Windows.Forms.Button buttonOpen;
        public MetroFramework.Controls.MetroTextBox paramRegularWithDegree;
        public MetroFramework.Controls.MetroTextBox textEquation3;
        public MetroFramework.Controls.MetroTextBox textEquation2;
        public MetroFramework.Controls.MetroTextBox textEquation1;
        public System.Windows.Forms.CheckBox enableEq1;
        public MetroFramework.Controls.MetroProgressBar progressBar;
        public MetroFramework.Controls.MetroTextBox textOpenViz;
        private MetroFramework.Controls.MetroTextBox textOpenExp;
        private MetroFramework.Controls.MetroProgressSpinner metroProgress;
        private MetroFramework.Controls.MetroLabel ListOfInvariants;
        public System.Windows.Forms.CheckBox enableIsPlanar;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
        private MetroFramework.Controls.MetroLabel version;
        public System.Windows.Forms.CheckBox enableIsHamiltonian;
        private System.Windows.Forms.DataGridView listInvResults;
        private MetroFramework.Controls.MetroCheckBox showInvariantsCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaInvariant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaResultado;
        public System.Windows.Forms.CheckBox enableIsAcyclic;
        private MetroFramework.Controls.MetroTextBox insertG6ToView;
        private MetroFramework.Controls.MetroButton viewG6Btn;
        private MetroFramework.Controls.MetroButton openG6BtnViz;
    }
}

