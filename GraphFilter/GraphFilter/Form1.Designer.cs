namespace GraphFilter
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listOfInvariants = new System.Windows.Forms.ListView();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.listOfG6 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.listOfG6Exp = new System.Windows.Forms.ListBox();
            this.buttonSavePNG = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.invariant1 = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.groupBoxFiles = new System.Windows.Forms.GroupBox();
            this.textOutPath = new MetroFramework.Controls.MetroTextBox();
            this.textSource = new MetroFramework.Controls.MetroTextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.textOpenViz = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroProgress = new MetroFramework.Controls.MetroProgressSpinner();
            this.textOpenExp = new MetroFramework.Controls.MetroTextBox();
            this.checkUpdatesBtn = new MetroFramework.Controls.MetroButton();
            this.groupBox3.SuspendLayout();
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.listOfInvariants);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(591, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 540);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Invariants";
            // 
            // listOfInvariants
            // 
            this.listOfInvariants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listOfInvariants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfInvariants.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listOfInvariants.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listOfInvariants.HideSelection = false;
            this.listOfInvariants.Location = new System.Drawing.Point(3, 18);
            this.listOfInvariants.MultiSelect = false;
            this.listOfInvariants.Name = "listOfInvariants";
            this.listOfInvariants.Size = new System.Drawing.Size(353, 519);
            this.listOfInvariants.TabIndex = 1;
            this.listOfInvariants.UseCompatibleStateImageBehavior = false;
            this.listOfInvariants.View = System.Windows.Forms.View.List;
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxCondition.Controls.Add(this.enableIsPlanar);
            this.groupBoxCondition.Controls.Add(this.paramRegularWithDegree);
            this.groupBoxCondition.Controls.Add(this.enableIsConnected);
            this.groupBoxCondition.Controls.Add(this.enableRegular);
            this.groupBoxCondition.Controls.Add(this.enableRegularWithK);
            this.groupBoxCondition.Location = new System.Drawing.Point(0, 103);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(585, 157);
            this.groupBoxCondition.TabIndex = 8;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Condition";
            // 
            // enableIsPlanar
            // 
            this.enableIsPlanar.AutoSize = true;
            this.enableIsPlanar.Location = new System.Drawing.Point(10, 112);
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
            this.enableIsConnected.Location = new System.Drawing.Point(10, 85);
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
            this.enableRegular.Location = new System.Drawing.Point(10, 31);
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
            this.enableRegularWithK.Location = new System.Drawing.Point(10, 58);
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
            this.buttonSave.Location = new System.Drawing.Point(6, 58);
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
            this.buttonSearch.Location = new System.Drawing.Point(6, 414);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 40);
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
            this.verifyEq3.Location = new System.Drawing.Point(38, 92);
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
            this.verifyEq2.Location = new System.Drawing.Point(38, 56);
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
            this.verifyEq1.Location = new System.Drawing.Point(38, 22);
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
            this.textEquation2.CustomButton.Name = "";
            this.textEquation2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textEquation2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textEquation2.CustomButton.TabIndex = 1;
            this.textEquation2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textEquation2.CustomButton.UseSelectable = true;
            this.textEquation2.CustomButton.Visible = false;
            this.textEquation2.Enabled = false;
            this.textEquation2.Lines = new string[0];
            this.textEquation2.Location = new System.Drawing.Point(79, 67);
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
            this.enableEq3.Name = "enableEq3";
            this.enableEq3.Size = new System.Drawing.Size(18, 17);
            this.enableEq3.TabIndex = 44;
            this.enableEq3.UseVisualStyleBackColor = true;
            this.enableEq3.CheckedChanged += new System.EventHandler(this.enableEq3_CheckedChanged);
            // 
            // enableEq2
            // 
            this.enableEq2.AutoSize = true;
            this.enableEq2.Location = new System.Drawing.Point(10, 68);
            this.enableEq2.Name = "enableEq2";
            this.enableEq2.Size = new System.Drawing.Size(18, 17);
            this.enableEq2.TabIndex = 34;
            this.enableEq2.UseVisualStyleBackColor = true;
            this.enableEq2.CheckedChanged += new System.EventHandler(this.EnableEq2_CheckedChanged);
            // 
            // enableEq1
            // 
            this.enableEq1.AutoSize = true;
            this.enableEq1.Location = new System.Drawing.Point(10, 34);
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
            this.label6.Location = new System.Drawing.Point(562, 30);
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
            this.buttonPrint.Location = new System.Drawing.Point(453, 39);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrint.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonPrint.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(50, 50);
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
            this.buttonExp2PNG.Location = new System.Drawing.Point(403, 39);
            this.buttonExp2PNG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExp2PNG.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonExp2PNG.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonExp2PNG.Name = "buttonExp2PNG";
            this.buttonExp2PNG.Size = new System.Drawing.Size(50, 50);
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
            this.buttonZoomIn.Location = new System.Drawing.Point(353, 39);
            this.buttonZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomIn.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomIn.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(50, 50);
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
            this.buttonZoomOriginal.Location = new System.Drawing.Point(253, 39);
            this.buttonZoomOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOriginal.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOriginal.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOriginal.Name = "buttonZoomOriginal";
            this.buttonZoomOriginal.Size = new System.Drawing.Size(50, 50);
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
            this.buttonZoomOut.Location = new System.Drawing.Point(303, 39);
            this.buttonZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOut.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOut.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(50, 50);
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
            this.buttonFill.Location = new System.Drawing.Point(203, 39);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFill.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonFill.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(50, 50);
            this.buttonFill.TabIndex = 53;
            this.buttonFill.UseVisualStyleBackColor = false;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // wpfHost
            // 
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(203, 40);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(643, 388);
            this.wpfHost.TabIndex = 52;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.wpfHost_ChildChanged);
            this.wpfHost.Child = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open .g6 File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfG6
            // 
            this.listOfG6.FormattingEnabled = true;
            this.listOfG6.HorizontalScrollbar = true;
            this.listOfG6.ItemHeight = 16;
            this.listOfG6.Location = new System.Drawing.Point(3, 39);
            this.listOfG6.Name = "listOfG6";
            this.listOfG6.Size = new System.Drawing.Size(194, 388);
            this.listOfG6.TabIndex = 0;
            this.listOfG6.SelectedIndexChanged += new System.EventHandler(this.listOfG6_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(231, 71);
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
            this.listOfG6Exp.Location = new System.Drawing.Point(2, 75);
            this.listOfG6Exp.Name = "listOfG6Exp";
            this.listOfG6Exp.Size = new System.Drawing.Size(192, 372);
            this.listOfG6Exp.TabIndex = 6;
            this.listOfG6Exp.SelectedIndexChanged += new System.EventHandler(this.listOfG6Exp_SelectedIndexChanged);
            // 
            // buttonSavePNG
            // 
            this.buttonSavePNG.Location = new System.Drawing.Point(0, 40);
            this.buttonSavePNG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSavePNG.Name = "buttonSavePNG";
            this.buttonSavePNG.Size = new System.Drawing.Size(194, 30);
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
            this.button2.Size = new System.Drawing.Size(194, 30);
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
            this.tabControl.Location = new System.Drawing.Point(23, 72);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(958, 581);
            this.tabControl.TabIndex = 52;
            this.tabControl.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.invariant1);
            this.metroTabPage1.Controls.Add(this.progressBar);
            this.metroTabPage1.Controls.Add(this.groupBoxFiles);
            this.metroTabPage1.Controls.Add(this.groupBox3);
            this.metroTabPage1.Controls.Add(this.groupBoxCondition);
            this.metroTabPage1.Controls.Add(this.buttonSearch);
            this.metroTabPage1.Controls.Add(this.groupBoxEq);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(950, 540);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Filter Graphs";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // invariant1
            // 
            this.invariant1.AutoSize = true;
            this.invariant1.Location = new System.Drawing.Point(6, 456);
            this.invariant1.Name = "invariant1";
            this.invariant1.Size = new System.Drawing.Size(61, 20);
            this.invariant1.TabIndex = 2;
            this.invariant1.Text = "Invariant";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(151, 414);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(434, 40);
            this.progressBar.TabIndex = 52;
            // 
            // groupBoxFiles
            // 
            this.groupBoxFiles.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxFiles.Controls.Add(this.textOutPath);
            this.groupBoxFiles.Controls.Add(this.textSource);
            this.groupBoxFiles.Controls.Add(this.buttonOpen);
            this.groupBoxFiles.Controls.Add(this.buttonSave);
            this.groupBoxFiles.Location = new System.Drawing.Point(0, 3);
            this.groupBoxFiles.Name = "groupBoxFiles";
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
            this.textOutPath.CustomButton.Name = "";
            this.textOutPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textOutPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textOutPath.CustomButton.TabIndex = 1;
            this.textOutPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textOutPath.CustomButton.UseSelectable = true;
            this.textOutPath.CustomButton.Visible = false;
            this.textOutPath.Enabled = false;
            this.textOutPath.Lines = new string[0];
            this.textOutPath.Location = new System.Drawing.Point(151, 61);
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
            this.buttonOpen.Location = new System.Drawing.Point(6, 20);
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
            this.metroTabPage2.Controls.Add(this.textOpenViz);
            this.metroTabPage2.Controls.Add(this.buttonFill);
            this.metroTabPage2.Controls.Add(this.buttonZoomOriginal);
            this.metroTabPage2.Controls.Add(this.buttonZoomOut);
            this.metroTabPage2.Controls.Add(this.buttonZoomIn);
            this.metroTabPage2.Controls.Add(this.buttonExp2PNG);
            this.metroTabPage2.Controls.Add(this.buttonPrint);
            this.metroTabPage2.Controls.Add(this.wpfHost);
            this.metroTabPage2.Controls.Add(this.listOfG6);
            this.metroTabPage2.Controls.Add(this.button1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 37);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(950, 540);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Visualization";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // textOpenViz
            // 
            // 
            // 
            // 
            this.textOpenViz.CustomButton.Image = null;
            this.textOpenViz.CustomButton.Location = new System.Drawing.Point(725, 1);
            this.textOpenViz.CustomButton.Name = "";
            this.textOpenViz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textOpenViz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textOpenViz.CustomButton.TabIndex = 1;
            this.textOpenViz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textOpenViz.CustomButton.UseSelectable = true;
            this.textOpenViz.CustomButton.Visible = false;
            this.textOpenViz.Enabled = false;
            this.textOpenViz.Lines = new string[0];
            this.textOpenViz.Location = new System.Drawing.Point(203, 11);
            this.textOpenViz.MaxLength = 32767;
            this.textOpenViz.Name = "textOpenViz";
            this.textOpenViz.PasswordChar = '\0';
            this.textOpenViz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textOpenViz.SelectedText = "";
            this.textOpenViz.SelectionLength = 0;
            this.textOpenViz.SelectionStart = 0;
            this.textOpenViz.ShortcutsEnabled = true;
            this.textOpenViz.Size = new System.Drawing.Size(747, 23);
            this.textOpenViz.TabIndex = 56;
            this.textOpenViz.UseSelectable = true;
            this.textOpenViz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textOpenViz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage3
            // 
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
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(950, 540);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Export";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroProgress
            // 
            this.metroProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.metroProgress.Location = new System.Drawing.Point(444, 163);
            this.metroProgress.Margin = new System.Windows.Forms.Padding(0);
            this.metroProgress.Maximum = 100;
            this.metroProgress.MaximumSize = new System.Drawing.Size(200, 200);
            this.metroProgress.MinimumSize = new System.Drawing.Size(200, 200);
            this.metroProgress.Name = "metroProgress";
            this.metroProgress.Size = new System.Drawing.Size(200, 200);
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
            this.textOpenExp.CustomButton.Location = new System.Drawing.Point(728, 1);
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
            this.textOpenExp.MaxLength = 32767;
            this.textOpenExp.Name = "textOpenExp";
            this.textOpenExp.PasswordChar = '\0';
            this.textOpenExp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textOpenExp.SelectedText = "";
            this.textOpenExp.SelectionLength = 0;
            this.textOpenExp.SelectionStart = 0;
            this.textOpenExp.ShortcutsEnabled = true;
            this.textOpenExp.Size = new System.Drawing.Size(750, 23);
            this.textOpenExp.TabIndex = 9;
            this.textOpenExp.UseSelectable = true;
            this.textOpenExp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textOpenExp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // checkUpdatesBtn
            // 
            this.checkUpdatesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkUpdatesBtn.BackColor = System.Drawing.Color.Transparent;
            this.checkUpdatesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkUpdatesBtn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.checkUpdatesBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.checkUpdatesBtn.Location = new System.Drawing.Point(839, 63);
            this.checkUpdatesBtn.Name = "checkUpdatesBtn";
            this.checkUpdatesBtn.Size = new System.Drawing.Size(142, 23);
            this.checkUpdatesBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.checkUpdatesBtn.TabIndex = 53;
            this.checkUpdatesBtn.Text = "Check Updates";
            this.checkUpdatesBtn.UseCustomBackColor = true;
            this.checkUpdatesBtn.UseCustomForeColor = true;
            this.checkUpdatesBtn.UseSelectable = true;
            this.checkUpdatesBtn.UseStyleColors = true;
            this.checkUpdatesBtn.Click += new System.EventHandler(this.checkUpdatesBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 851);
            this.Controls.Add(this.checkUpdatesBtn);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "Form1";
            this.Text = "Graph Filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox3.ResumeLayout(false);
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
            this.metroTabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.ListView listOfInvariants;
        private MetroFramework.Controls.MetroLabel invariant1;
        public System.Windows.Forms.CheckBox enableIsPlanar;
        private MetroFramework.Controls.MetroButton checkUpdatesBtn;
    }
}

