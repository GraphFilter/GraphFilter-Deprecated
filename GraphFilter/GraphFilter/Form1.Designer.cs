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
            this.filterGraphs = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listOfInvariants = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enableIsConnected = new System.Windows.Forms.CheckBox();
            this.enableRegular = new System.Windows.Forms.CheckBox();
            this.enableRegularWithK = new System.Windows.Forms.CheckBox();
            this.paramRegularWithDegree = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textoOrigem = new System.Windows.Forms.TextBox();
            this.textOutPath = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.verifyEq3 = new System.Windows.Forms.Button();
            this.verifyEq2 = new System.Windows.Forms.Button();
            this.verifyEq1 = new System.Windows.Forms.Button();
            this.textEquation3 = new System.Windows.Forms.TextBox();
            this.textEquation2 = new System.Windows.Forms.TextBox();
            this.textEquation1 = new System.Windows.Forms.TextBox();
            this.enableEq3 = new System.Windows.Forms.CheckBox();
            this.enableEq2 = new System.Windows.Forms.CheckBox();
            this.enableEq1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.visualization = new System.Windows.Forms.TabPage();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExp2PNG = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonZoomOriginal = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.textOpenViz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listOfG6 = new System.Windows.Forms.ListBox();
            this.export = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.elementHost = new System.Windows.Forms.Integration.ElementHost();
            this.listOfG6Exp = new System.Windows.Forms.ListBox();
            this.textOpenExp = new System.Windows.Forms.TextBox();
            this.buttonSavePNG = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filterGraphs.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.visualization.SuspendLayout();
            this.export.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterGraphs
            // 
            this.filterGraphs.Controls.Add(this.groupBox3);
            this.filterGraphs.Controls.Add(this.buttonOpen);
            this.filterGraphs.Controls.Add(this.groupBox2);
            this.filterGraphs.Controls.Add(this.buttonSave);
            this.filterGraphs.Controls.Add(this.progressBar);
            this.filterGraphs.Controls.Add(this.textoOrigem);
            this.filterGraphs.Controls.Add(this.textOutPath);
            this.filterGraphs.Controls.Add(this.buttonSearch);
            this.filterGraphs.Controls.Add(this.groupBox1);
            this.filterGraphs.Location = new System.Drawing.Point(4, 25);
            this.filterGraphs.Name = "filterGraphs";
            this.filterGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.filterGraphs.Size = new System.Drawing.Size(951, 451);
            this.filterGraphs.TabIndex = 0;
            this.filterGraphs.Text = "Filter Graphs";
            this.filterGraphs.UseVisualStyleBackColor = true;
            this.filterGraphs.Click += new System.EventHandler(this.filterGraphs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.listOfInvariants);
            this.groupBox3.Location = new System.Drawing.Point(598, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 401);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List of Invariants";
            // 
            // listOfInvariants
            // 
            this.listOfInvariants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfInvariants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfInvariants.FormattingEnabled = true;
            this.listOfInvariants.ItemHeight = 20;
            this.listOfInvariants.Location = new System.Drawing.Point(6, 21);
            this.listOfInvariants.Name = "listOfInvariants";
            this.listOfInvariants.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listOfInvariants.Size = new System.Drawing.Size(335, 364);
            this.listOfInvariants.TabIndex = 0;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(7, 8);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 30);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Input File";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enableIsConnected);
            this.groupBox2.Controls.Add(this.enableRegular);
            this.groupBox2.Controls.Add(this.enableRegularWithK);
            this.groupBox2.Controls.Add(this.paramRegularWithDegree);
            this.groupBox2.Location = new System.Drawing.Point(7, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 124);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condition";
            // 
            // enableIsConnected
            // 
            this.enableIsConnected.AutoSize = true;
            this.enableIsConnected.Location = new System.Drawing.Point(10, 94);
            this.enableIsConnected.Name = "enableIsConnected";
            this.enableIsConnected.Size = new System.Drawing.Size(112, 21);
            this.enableIsConnected.TabIndex = 49;
            this.enableIsConnected.Text = "Is Connected";
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
            this.enableRegularWithK.Location = new System.Drawing.Point(10, 63);
            this.enableRegularWithK.Name = "enableRegularWithK";
            this.enableRegularWithK.Size = new System.Drawing.Size(153, 21);
            this.enableRegularWithK.TabIndex = 48;
            this.enableRegularWithK.Text = "Regular with Order:";
            this.enableRegularWithK.UseVisualStyleBackColor = true;
            this.enableRegularWithK.CheckedChanged += new System.EventHandler(this.enableRegularWithK_CheckedChanged);
            // 
            // paramRegularWithDegree
            // 
            this.paramRegularWithDegree.Enabled = false;
            this.paramRegularWithDegree.Location = new System.Drawing.Point(224, 61);
            this.paramRegularWithDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paramRegularWithDegree.Name = "paramRegularWithDegree";
            this.paramRegularWithDegree.Size = new System.Drawing.Size(37, 22);
            this.paramRegularWithDegree.TabIndex = 49;
            this.paramRegularWithDegree.TextChanged += new System.EventHandler(this.paramRegularWithDegree_TextChanged_1);
            this.paramRegularWithDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paramRegularWithDegree_KeyPress_1);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(7, 46);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 30);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Output File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(152, 364);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(440, 40);
            this.progressBar.TabIndex = 50;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // textoOrigem
            // 
            this.textoOrigem.Enabled = false;
            this.textoOrigem.Location = new System.Drawing.Point(152, 12);
            this.textoOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoOrigem.Name = "textoOrigem";
            this.textoOrigem.Size = new System.Drawing.Size(440, 22);
            this.textoOrigem.TabIndex = 2;
            this.textoOrigem.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textOutPath
            // 
            this.textOutPath.Enabled = false;
            this.textOutPath.Location = new System.Drawing.Point(152, 51);
            this.textOutPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textOutPath.Name = "textOutPath";
            this.textOutPath.Size = new System.Drawing.Size(440, 22);
            this.textOutPath.TabIndex = 5;
            this.textOutPath.TextChanged += new System.EventHandler(this.TextDestino_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(7, 364);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 40);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Run";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.EnabledChanged += new System.EventHandler(this.buttonSearch_EnabledChanged);
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.verifyEq3);
            this.groupBox1.Controls.Add(this.verifyEq2);
            this.groupBox1.Controls.Add(this.verifyEq1);
            this.groupBox1.Controls.Add(this.textEquation3);
            this.groupBox1.Controls.Add(this.textEquation2);
            this.groupBox1.Controls.Add(this.textEquation1);
            this.groupBox1.Controls.Add(this.enableEq3);
            this.groupBox1.Controls.Add(this.enableEq2);
            this.groupBox1.Controls.Add(this.enableEq1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(7, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(585, 132);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equations";
            // 
            // verifyEq3
            // 
            this.verifyEq3.Enabled = false;
            this.verifyEq3.FlatAppearance.BorderSize = 0;
            this.verifyEq3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyEq3.Image = global::GraphFilter.Properties.Resources.icons8_checked_checkbox;
            this.verifyEq3.Location = new System.Drawing.Point(548, 95);
            this.verifyEq3.Margin = new System.Windows.Forms.Padding(0);
            this.verifyEq3.MaximumSize = new System.Drawing.Size(30, 30);
            this.verifyEq3.MinimumSize = new System.Drawing.Size(30, 30);
            this.verifyEq3.Name = "verifyEq3";
            this.verifyEq3.Size = new System.Drawing.Size(30, 30);
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
            this.verifyEq2.Location = new System.Drawing.Point(548, 60);
            this.verifyEq2.Margin = new System.Windows.Forms.Padding(0);
            this.verifyEq2.MaximumSize = new System.Drawing.Size(30, 30);
            this.verifyEq2.MinimumSize = new System.Drawing.Size(30, 30);
            this.verifyEq2.Name = "verifyEq2";
            this.verifyEq2.Size = new System.Drawing.Size(30, 30);
            this.verifyEq2.TabIndex = 56;
            this.verifyEq2.UseVisualStyleBackColor = true;
            this.verifyEq2.Click += new System.EventHandler(this.verifyEq2_Click);
            // 
            // verifyEq1
            // 
            this.verifyEq1.CausesValidation = false;
            this.verifyEq1.Enabled = false;
            this.verifyEq1.FlatAppearance.BorderSize = 0;
            this.verifyEq1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyEq1.Image = global::GraphFilter.Properties.Resources.icons8_checked_checkbox;
            this.verifyEq1.Location = new System.Drawing.Point(548, 29);
            this.verifyEq1.Margin = new System.Windows.Forms.Padding(0);
            this.verifyEq1.MaximumSize = new System.Drawing.Size(30, 30);
            this.verifyEq1.MinimumSize = new System.Drawing.Size(30, 30);
            this.verifyEq1.Name = "verifyEq1";
            this.verifyEq1.Size = new System.Drawing.Size(30, 30);
            this.verifyEq1.TabIndex = 0;
            this.verifyEq1.UseVisualStyleBackColor = true;
            this.verifyEq1.Click += new System.EventHandler(this.verifyEq1_Click);
            // 
            // textEquation3
            // 
            this.textEquation3.Enabled = false;
            this.textEquation3.Location = new System.Drawing.Point(46, 99);
            this.textEquation3.Name = "textEquation3";
            this.textEquation3.Size = new System.Drawing.Size(499, 22);
            this.textEquation3.TabIndex = 55;
            // 
            // textEquation2
            // 
            this.textEquation2.Enabled = false;
            this.textEquation2.Location = new System.Drawing.Point(46, 64);
            this.textEquation2.Name = "textEquation2";
            this.textEquation2.Size = new System.Drawing.Size(499, 22);
            this.textEquation2.TabIndex = 54;
            // 
            // textEquation1
            // 
            this.textEquation1.Enabled = false;
            this.textEquation1.Location = new System.Drawing.Point(46, 32);
            this.textEquation1.Name = "textEquation1";
            this.textEquation1.Size = new System.Drawing.Size(499, 22);
            this.textEquation1.TabIndex = 53;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.filterGraphs);
            this.tabControl1.Controls.Add(this.visualization);
            this.tabControl1.Controls.Add(this.export);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MinimumSize = new System.Drawing.Size(720, 480);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 480);
            this.tabControl1.TabIndex = 51;
            // 
            // visualization
            // 
            this.visualization.Controls.Add(this.buttonPrint);
            this.visualization.Controls.Add(this.buttonExp2PNG);
            this.visualization.Controls.Add(this.buttonZoomIn);
            this.visualization.Controls.Add(this.buttonZoomOriginal);
            this.visualization.Controls.Add(this.buttonZoomOut);
            this.visualization.Controls.Add(this.buttonFill);
            this.visualization.Controls.Add(this.wpfHost);
            this.visualization.Controls.Add(this.textOpenViz);
            this.visualization.Controls.Add(this.button1);
            this.visualization.Controls.Add(this.listOfG6);
            this.visualization.Location = new System.Drawing.Point(4, 25);
            this.visualization.Name = "visualization";
            this.visualization.Padding = new System.Windows.Forms.Padding(3);
            this.visualization.Size = new System.Drawing.Size(951, 451);
            this.visualization.TabIndex = 1;
            this.visualization.Text = "Visualization";
            this.visualization.UseVisualStyleBackColor = true;
            this.visualization.Click += new System.EventHandler(this.visualization_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Image = global::GraphFilter.Properties.Resources.icons8_png;
            this.buttonPrint.Location = new System.Drawing.Point(456, 38);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPrint.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonPrint.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(50, 50);
            this.buttonPrint.TabIndex = 45;
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonExp2PNG
            // 
            this.buttonExp2PNG.FlatAppearance.BorderSize = 0;
            this.buttonExp2PNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExp2PNG.Image = global::GraphFilter.Properties.Resources.icons8_export_pdf;
            this.buttonExp2PNG.Location = new System.Drawing.Point(406, 38);
            this.buttonExp2PNG.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExp2PNG.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonExp2PNG.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonExp2PNG.Name = "buttonExp2PNG";
            this.buttonExp2PNG.Size = new System.Drawing.Size(50, 50);
            this.buttonExp2PNG.TabIndex = 45;
            this.buttonExp2PNG.UseVisualStyleBackColor = true;
            this.buttonExp2PNG.Click += new System.EventHandler(this.buttonExp2PNG_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.FlatAppearance.BorderSize = 0;
            this.buttonZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomIn.Image = global::GraphFilter.Properties.Resources.icons8_zoom_in;
            this.buttonZoomIn.Location = new System.Drawing.Point(356, 38);
            this.buttonZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomIn.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomIn.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(50, 50);
            this.buttonZoomIn.TabIndex = 45;
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // buttonZoomOriginal
            // 
            this.buttonZoomOriginal.FlatAppearance.BorderSize = 0;
            this.buttonZoomOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOriginal.Image = global::GraphFilter.Properties.Resources.icons8_zoom_to_actual_size;
            this.buttonZoomOriginal.Location = new System.Drawing.Point(256, 38);
            this.buttonZoomOriginal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOriginal.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOriginal.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOriginal.Name = "buttonZoomOriginal";
            this.buttonZoomOriginal.Size = new System.Drawing.Size(50, 50);
            this.buttonZoomOriginal.TabIndex = 55;
            this.buttonZoomOriginal.UseVisualStyleBackColor = true;
            this.buttonZoomOriginal.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.FlatAppearance.BorderSize = 0;
            this.buttonZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZoomOut.Image = global::GraphFilter.Properties.Resources.icons8_zoom_out;
            this.buttonZoomOut.Location = new System.Drawing.Point(306, 38);
            this.buttonZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZoomOut.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOut.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(50, 50);
            this.buttonZoomOut.TabIndex = 54;
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click_1);
            // 
            // buttonFill
            // 
            this.buttonFill.FlatAppearance.BorderSize = 0;
            this.buttonFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFill.Image = global::GraphFilter.Properties.Resources.icons8_zoom_to_extents_2;
            this.buttonFill.Location = new System.Drawing.Point(206, 38);
            this.buttonFill.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFill.MaximumSize = new System.Drawing.Size(50, 50);
            this.buttonFill.MinimumSize = new System.Drawing.Size(50, 50);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(50, 50);
            this.buttonFill.TabIndex = 53;
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // wpfHost
            // 
            this.wpfHost.BackColor = System.Drawing.Color.White;
            this.wpfHost.Location = new System.Drawing.Point(206, 38);
            this.wpfHost.Name = "wpfHost";
            this.wpfHost.Size = new System.Drawing.Size(643, 388);
            this.wpfHost.TabIndex = 52;
            this.wpfHost.Text = "elementHost1";
            this.wpfHost.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.wpfHost_ChildChanged);
            this.wpfHost.Child = null;
            // 
            // textOpenViz
            // 
            this.textOpenViz.Enabled = false;
            this.textOpenViz.Location = new System.Drawing.Point(206, 9);
            this.textOpenViz.Name = "textOpenViz";
            this.textOpenViz.Size = new System.Drawing.Size(643, 22);
            this.textOpenViz.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listOfG6
            // 
            this.listOfG6.FormattingEnabled = true;
            this.listOfG6.HorizontalScrollbar = true;
            this.listOfG6.ItemHeight = 16;
            this.listOfG6.Location = new System.Drawing.Point(6, 38);
            this.listOfG6.Name = "listOfG6";
            this.listOfG6.Size = new System.Drawing.Size(194, 388);
            this.listOfG6.TabIndex = 0;
            this.listOfG6.SelectedIndexChanged += new System.EventHandler(this.listOfG6_SelectedIndexChanged);
            // 
            // export
            // 
            this.export.Controls.Add(this.pictureBox1);
            this.export.Controls.Add(this.elementHost);
            this.export.Controls.Add(this.listOfG6Exp);
            this.export.Controls.Add(this.textOpenExp);
            this.export.Controls.Add(this.buttonSavePNG);
            this.export.Controls.Add(this.button2);
            this.export.Location = new System.Drawing.Point(4, 25);
            this.export.Name = "export";
            this.export.Padding = new System.Windows.Forms.Padding(3);
            this.export.Size = new System.Drawing.Size(951, 451);
            this.export.TabIndex = 2;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(643, 372);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // elementHost
            // 
            this.elementHost.BackColor = System.Drawing.Color.White;
            this.elementHost.Enabled = false;
            this.elementHost.Location = new System.Drawing.Point(206, 74);
            this.elementHost.Name = "elementHost";
            this.elementHost.Size = new System.Drawing.Size(643, 372);
            this.elementHost.TabIndex = 7;
            this.elementHost.Text = "elementHost1";
            this.elementHost.Child = null;
            // 
            // listOfG6Exp
            // 
            this.listOfG6Exp.Enabled = false;
            this.listOfG6Exp.FormattingEnabled = true;
            this.listOfG6Exp.ItemHeight = 16;
            this.listOfG6Exp.Location = new System.Drawing.Point(8, 74);
            this.listOfG6Exp.Name = "listOfG6Exp";
            this.listOfG6Exp.Size = new System.Drawing.Size(192, 372);
            this.listOfG6Exp.TabIndex = 6;
            this.listOfG6Exp.SelectedIndexChanged += new System.EventHandler(this.listOfG6Exp_SelectedIndexChanged);
            // 
            // textOpenExp
            // 
            this.textOpenExp.Enabled = false;
            this.textOpenExp.Location = new System.Drawing.Point(206, 9);
            this.textOpenExp.Name = "textOpenExp";
            this.textOpenExp.Size = new System.Drawing.Size(643, 22);
            this.textOpenExp.TabIndex = 4;
            this.textOpenExp.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // buttonSavePNG
            // 
            this.buttonSavePNG.Location = new System.Drawing.Point(6, 39);
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
            this.button2.Location = new System.Drawing.Point(6, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 453);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Filter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.filterGraphs.ResumeLayout(false);
            this.filterGraphs.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.visualization.ResumeLayout(false);
            this.visualization.PerformLayout();
            this.export.ResumeLayout(false);
            this.export.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage filterGraphs;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox enableIsConnected;
        public System.Windows.Forms.CheckBox enableRegular;
        public System.Windows.Forms.CheckBox enableRegularWithK;
        private System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox textoOrigem;
        public System.Windows.Forms.TextBox paramRegularWithDegree;
        private System.Windows.Forms.TextBox textOutPath;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox enableEq3;
        public System.Windows.Forms.CheckBox enableEq2;
        public System.Windows.Forms.CheckBox enableEq1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage visualization;
        private System.Windows.Forms.TextBox textOpenViz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listOfG6;
        private System.Windows.Forms.TabPage export;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSavePNG;
        private System.Windows.Forms.TextBox textOpenExp;
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
        public System.Windows.Forms.TextBox textEquation1;
        public System.Windows.Forms.TextBox textEquation3;
        public System.Windows.Forms.TextBox textEquation2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listOfInvariants;
        private System.Windows.Forms.Button verifyEq1;
        private System.Windows.Forms.Button verifyEq3;
        private System.Windows.Forms.Button verifyEq2;
    }
}

