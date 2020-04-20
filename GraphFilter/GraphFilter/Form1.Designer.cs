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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.enableIsConnected = new System.Windows.Forms.CheckBox();
            this.enableRegular = new System.Windows.Forms.CheckBox();
            this.enableRegularWithK = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textoOrigem = new System.Windows.Forms.TextBox();
            this.paramRegularWithDegree = new System.Windows.Forms.TextBox();
            this.textOutPath = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.enableEq3 = new System.Windows.Forms.CheckBox();
            this.relationEq3 = new System.Windows.Forms.TextBox();
            this.param2Eq3 = new System.Windows.Forms.TextBox();
            this.comboInv2Eq3 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboInv1Eq3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.param1Eq3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enableEq2 = new System.Windows.Forms.CheckBox();
            this.enableEq1 = new System.Windows.Forms.CheckBox();
            this.relationEq2 = new System.Windows.Forms.TextBox();
            this.param2Eq2 = new System.Windows.Forms.TextBox();
            this.comboInv2Eq2 = new System.Windows.Forms.ComboBox();
            this.param3Eq1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboInv1Eq2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.param1Eq2 = new System.Windows.Forms.TextBox();
            this.relationEq1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboInv2Eq1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.param2Eq1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboInv1Eq1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.param1Eq1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.visualization = new System.Windows.Forms.TabPage();
            this.wpfHost = new System.Windows.Forms.Integration.ElementHost();
            this.textOpenViz = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listOfG6 = new System.Windows.Forms.ListBox();
            this.export = new System.Windows.Forms.TabPage();
            this.textExp = new System.Windows.Forms.TextBox();
            this.textOpenExp = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filterGraphs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.visualization.SuspendLayout();
            this.export.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterGraphs
            // 
            this.filterGraphs.Controls.Add(this.buttonOpen);
            this.filterGraphs.Controls.Add(this.groupBox2);
            this.filterGraphs.Controls.Add(this.buttonSave);
            this.filterGraphs.Controls.Add(this.progressBar);
            this.filterGraphs.Controls.Add(this.textoOrigem);
            this.filterGraphs.Controls.Add(this.paramRegularWithDegree);
            this.filterGraphs.Controls.Add(this.textOutPath);
            this.filterGraphs.Controls.Add(this.buttonSearch);
            this.filterGraphs.Controls.Add(this.groupBox1);
            this.filterGraphs.Location = new System.Drawing.Point(4, 25);
            this.filterGraphs.Name = "filterGraphs";
            this.filterGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.filterGraphs.Size = new System.Drawing.Size(910, 488);
            this.filterGraphs.TabIndex = 0;
            this.filterGraphs.Text = "Filter Graphs";
            this.filterGraphs.UseVisualStyleBackColor = true;
            this.filterGraphs.Click += new System.EventHandler(this.filterGraphs_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 254);
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
            this.progressBar.Location = new System.Drawing.Point(152, 383);
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
            // paramRegularWithDegree
            // 
            this.paramRegularWithDegree.Enabled = false;
            this.paramRegularWithDegree.Location = new System.Drawing.Point(166, 294);
            this.paramRegularWithDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paramRegularWithDegree.Name = "paramRegularWithDegree";
            this.paramRegularWithDegree.Size = new System.Drawing.Size(37, 22);
            this.paramRegularWithDegree.TabIndex = 49;
            this.paramRegularWithDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paramRegularWithDegree_KeyPress_1);
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
            this.buttonSearch.Location = new System.Drawing.Point(7, 383);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 40);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Run";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.enableEq3);
            this.groupBox1.Controls.Add(this.relationEq3);
            this.groupBox1.Controls.Add(this.param2Eq3);
            this.groupBox1.Controls.Add(this.comboInv2Eq3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboInv1Eq3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.param1Eq3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.enableEq2);
            this.groupBox1.Controls.Add(this.enableEq1);
            this.groupBox1.Controls.Add(this.relationEq2);
            this.groupBox1.Controls.Add(this.param2Eq2);
            this.groupBox1.Controls.Add(this.comboInv2Eq2);
            this.groupBox1.Controls.Add(this.param3Eq1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboInv1Eq2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.param1Eq2);
            this.groupBox1.Controls.Add(this.relationEq1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboInv2Eq1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.param2Eq1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboInv1Eq1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.param1Eq1);
            this.groupBox1.Location = new System.Drawing.Point(7, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(585, 152);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equations";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = ")";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 24);
            this.label8.TabIndex = 45;
            this.label8.Text = "(";
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
            // relationEq3
            // 
            this.relationEq3.Enabled = false;
            this.relationEq3.Location = new System.Drawing.Point(413, 101);
            this.relationEq3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relationEq3.Name = "relationEq3";
            this.relationEq3.Size = new System.Drawing.Size(37, 22);
            this.relationEq3.TabIndex = 43;
            this.relationEq3.Text = "=";
            this.relationEq3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.relationEq3_KeyPress);
            // 
            // param2Eq3
            // 
            this.param2Eq3.Enabled = false;
            this.param2Eq3.Location = new System.Drawing.Point(456, 101);
            this.param2Eq3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param2Eq3.Name = "param2Eq3";
            this.param2Eq3.Size = new System.Drawing.Size(40, 22);
            this.param2Eq3.TabIndex = 42;
            this.param2Eq3.Text = "0";
            this.param2Eq3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.param3Eq3_KeyPress);
            // 
            // comboInv2Eq3
            // 
            this.comboInv2Eq3.Enabled = false;
            this.comboInv2Eq3.FormattingEnabled = true;
            this.comboInv2Eq3.Location = new System.Drawing.Point(269, 100);
            this.comboInv2Eq3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv2Eq3.Name = "comboInv2Eq3";
            this.comboInv2Eq3.Size = new System.Drawing.Size(121, 24);
            this.comboInv2Eq3.TabIndex = 41;
            this.comboInv2Eq3.Text = "None";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "*";
            // 
            // comboInv1Eq3
            // 
            this.comboInv1Eq3.Enabled = false;
            this.comboInv1Eq3.FormattingEnabled = true;
            this.comboInv1Eq3.Location = new System.Drawing.Point(121, 100);
            this.comboInv1Eq3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv1Eq3.Name = "comboInv1Eq3";
            this.comboInv1Eq3.Size = new System.Drawing.Size(121, 24);
            this.comboInv1Eq3.TabIndex = 39;
            this.comboInv1Eq3.Text = "None";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(86, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "x";
            // 
            // param1Eq3
            // 
            this.param1Eq3.Enabled = false;
            this.param1Eq3.Location = new System.Drawing.Point(47, 100);
            this.param1Eq3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param1Eq3.Name = "param1Eq3";
            this.param1Eq3.Size = new System.Drawing.Size(32, 22);
            this.param1Eq3.TabIndex = 37;
            this.param1Eq3.Text = "0";
            this.param1Eq3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.param1Eq3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = ")";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "(";
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
            // relationEq2
            // 
            this.relationEq2.Enabled = false;
            this.relationEq2.Location = new System.Drawing.Point(412, 66);
            this.relationEq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relationEq2.Name = "relationEq2";
            this.relationEq2.Size = new System.Drawing.Size(37, 22);
            this.relationEq2.TabIndex = 22;
            this.relationEq2.Text = "=";
            this.relationEq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RelationEq2_KeyPress);
            // 
            // param2Eq2
            // 
            this.param2Eq2.Enabled = false;
            this.param2Eq2.Location = new System.Drawing.Point(455, 66);
            this.param2Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param2Eq2.Name = "param2Eq2";
            this.param2Eq2.Size = new System.Drawing.Size(40, 22);
            this.param2Eq2.TabIndex = 20;
            this.param2Eq2.Text = "0";
            this.param2Eq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Param3Eq2_KeyPress);
            // 
            // comboInv2Eq2
            // 
            this.comboInv2Eq2.Enabled = false;
            this.comboInv2Eq2.FormattingEnabled = true;
            this.comboInv2Eq2.Location = new System.Drawing.Point(268, 65);
            this.comboInv2Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv2Eq2.Name = "comboInv2Eq2";
            this.comboInv2Eq2.Size = new System.Drawing.Size(121, 24);
            this.comboInv2Eq2.TabIndex = 18;
            this.comboInv2Eq2.Text = "None";
            // 
            // param3Eq1
            // 
            this.param3Eq1.Enabled = false;
            this.param3Eq1.Location = new System.Drawing.Point(509, 30);
            this.param3Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param3Eq1.Name = "param3Eq1";
            this.param3Eq1.Size = new System.Drawing.Size(40, 22);
            this.param3Eq1.TabIndex = 8;
            this.param3Eq1.Text = "0";
            this.param3Eq1.TextChanged += new System.EventHandler(this.Param3_TextChanged);
            this.param3Eq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "/";
            // 
            // comboInv1Eq2
            // 
            this.comboInv1Eq2.Enabled = false;
            this.comboInv1Eq2.FormattingEnabled = true;
            this.comboInv1Eq2.Location = new System.Drawing.Point(120, 65);
            this.comboInv1Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv1Eq2.Name = "comboInv1Eq2";
            this.comboInv1Eq2.Size = new System.Drawing.Size(121, 24);
            this.comboInv1Eq2.TabIndex = 14;
            this.comboInv1Eq2.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "x";
            // 
            // param1Eq2
            // 
            this.param1Eq2.Enabled = false;
            this.param1Eq2.Location = new System.Drawing.Point(46, 64);
            this.param1Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param1Eq2.Name = "param1Eq2";
            this.param1Eq2.Size = new System.Drawing.Size(32, 22);
            this.param1Eq2.TabIndex = 12;
            this.param1Eq2.Text = "0";
            this.param1Eq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Param1Eq2_KeyPress);
            // 
            // relationEq1
            // 
            this.relationEq1.Enabled = false;
            this.relationEq1.Location = new System.Drawing.Point(459, 30);
            this.relationEq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relationEq1.Name = "relationEq1";
            this.relationEq1.Size = new System.Drawing.Size(37, 22);
            this.relationEq1.TabIndex = 11;
            this.relationEq1.Text = "=";
            this.relationEq1.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.relationEq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
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
            // comboInv2Eq1
            // 
            this.comboInv2Eq1.Enabled = false;
            this.comboInv2Eq1.FormattingEnabled = true;
            this.comboInv2Eq1.Location = new System.Drawing.Point(325, 28);
            this.comboInv2Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv2Eq1.Name = "comboInv2Eq1";
            this.comboInv2Eq1.Size = new System.Drawing.Size(121, 24);
            this.comboInv2Eq1.TabIndex = 6;
            this.comboInv2Eq1.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // param2Eq1
            // 
            this.param2Eq1.Enabled = false;
            this.param2Eq1.Location = new System.Drawing.Point(258, 30);
            this.param2Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param2Eq1.Name = "param2Eq1";
            this.param2Eq1.Size = new System.Drawing.Size(32, 22);
            this.param2Eq1.TabIndex = 4;
            this.param2Eq1.Text = "0";
            this.param2Eq1.TextChanged += new System.EventHandler(this.param2Eq1_TextChanged);
            this.param2Eq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // comboInv1Eq1
            // 
            this.comboInv1Eq1.Enabled = false;
            this.comboInv1Eq1.FormattingEnabled = true;
            this.comboInv1Eq1.Location = new System.Drawing.Point(110, 28);
            this.comboInv1Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv1Eq1.Name = "comboInv1Eq1";
            this.comboInv1Eq1.Size = new System.Drawing.Size(121, 24);
            this.comboInv1Eq1.TabIndex = 2;
            this.comboInv1Eq1.Text = "None";
            this.comboInv1Eq1.SelectedIndexChanged += new System.EventHandler(this.ComboInv1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // param1Eq1
            // 
            this.param1Eq1.Enabled = false;
            this.param1Eq1.Location = new System.Drawing.Point(46, 30);
            this.param1Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param1Eq1.Name = "param1Eq1";
            this.param1Eq1.Size = new System.Drawing.Size(32, 22);
            this.param1Eq1.TabIndex = 0;
            this.param1Eq1.Text = "0";
            this.param1Eq1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            this.param1Eq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
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
            this.tabControl1.Size = new System.Drawing.Size(918, 517);
            this.tabControl1.TabIndex = 51;
            // 
            // visualization
            // 
            this.visualization.Controls.Add(this.wpfHost);
            this.visualization.Controls.Add(this.textOpenViz);
            this.visualization.Controls.Add(this.button1);
            this.visualization.Controls.Add(this.listOfG6);
            this.visualization.Location = new System.Drawing.Point(4, 25);
            this.visualization.Name = "visualization";
            this.visualization.Padding = new System.Windows.Forms.Padding(3);
            this.visualization.Size = new System.Drawing.Size(910, 488);
            this.visualization.TabIndex = 1;
            this.visualization.Text = "Visualization";
            this.visualization.UseVisualStyleBackColor = true;
            this.visualization.Click += new System.EventHandler(this.visualization_Click);
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
            this.export.Controls.Add(this.textExp);
            this.export.Controls.Add(this.textOpenExp);
            this.export.Controls.Add(this.button3);
            this.export.Controls.Add(this.button2);
            this.export.Location = new System.Drawing.Point(4, 25);
            this.export.Name = "export";
            this.export.Padding = new System.Windows.Forms.Padding(3);
            this.export.Size = new System.Drawing.Size(910, 488);
            this.export.TabIndex = 2;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            // 
            // textExp
            // 
            this.textExp.Enabled = false;
            this.textExp.Location = new System.Drawing.Point(206, 43);
            this.textExp.Name = "textExp";
            this.textExp.Size = new System.Drawing.Size(643, 22);
            this.textExp.TabIndex = 5;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(918, 517);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.visualization.ResumeLayout(false);
            this.visualization.PerformLayout();
            this.export.ResumeLayout(false);
            this.export.PerformLayout();
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
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.CheckBox enableEq3;
        public System.Windows.Forms.TextBox relationEq3;
        public System.Windows.Forms.TextBox param2Eq3;
        public System.Windows.Forms.ComboBox comboInv2Eq3;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comboInv1Eq3;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox param1Eq3;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox enableEq2;
        public System.Windows.Forms.CheckBox enableEq1;
        public System.Windows.Forms.TextBox relationEq2;
        public System.Windows.Forms.TextBox param2Eq2;
        public System.Windows.Forms.ComboBox comboInv2Eq2;
        public System.Windows.Forms.TextBox param3Eq1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox comboInv1Eq2;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox param1Eq2;
        public System.Windows.Forms.TextBox relationEq1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboInv2Eq1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox param2Eq1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboInv1Eq1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox param1Eq1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage visualization;
        private System.Windows.Forms.TextBox textOpenViz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listOfG6;
        private System.Windows.Forms.TabPage export;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textOpenExp;
        private System.Windows.Forms.TextBox textExp;
        private System.Windows.Forms.Integration.ElementHost wpfHost;
    }
}

