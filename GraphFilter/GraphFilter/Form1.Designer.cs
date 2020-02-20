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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textoOrigem = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textOutPath = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.param1Eq1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboInv1Eq1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.param2Eq1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboInv2Eq1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.param3Eq1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.relationEq1 = new System.Windows.Forms.TextBox();
            this.param1Eq2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboInv1Eq2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.param2Eq2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboInv2Eq2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.param3Eq2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.relationEq2 = new System.Windows.Forms.TextBox();
            this.enableEq1 = new System.Windows.Forms.CheckBox();
            this.enableEq2 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 30);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Input File";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(12, 50);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 30);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Output File";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // textoOrigem
            // 
            this.textoOrigem.Enabled = false;
            this.textoOrigem.Location = new System.Drawing.Point(157, 16);
            this.textoOrigem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textoOrigem.Name = "textoOrigem";
            this.textoOrigem.Size = new System.Drawing.Size(440, 22);
            this.textoOrigem.TabIndex = 2;
            this.textoOrigem.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(12, 232);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 30);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Run";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textOutPath
            // 
            this.textOutPath.Enabled = false;
            this.textOutPath.Location = new System.Drawing.Point(157, 55);
            this.textOutPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textOutPath.Name = "textOutPath";
            this.textOutPath.Size = new System.Drawing.Size(440, 22);
            this.textOutPath.TabIndex = 5;
            this.textOutPath.TextChanged += new System.EventHandler(this.TextDestino_TextChanged);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(157, 232);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(440, 30);
            this.progressBar.TabIndex = 6;
            // 
            // param1Eq1
            // 
            this.param1Eq1.Enabled = false;
            this.param1Eq1.Location = new System.Drawing.Point(46, 30);
            this.param1Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param1Eq1.Name = "param1Eq1";
            this.param1Eq1.Size = new System.Drawing.Size(32, 22);
            this.param1Eq1.TabIndex = 0;
            this.param1Eq1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged_1);
            this.param1Eq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
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
            // comboInv1Eq1
            // 
            this.comboInv1Eq1.Enabled = false;
            this.comboInv1Eq1.FormattingEnabled = true;
            this.comboInv1Eq1.Location = new System.Drawing.Point(110, 27);
            this.comboInv1Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv1Eq1.Name = "comboInv1Eq1";
            this.comboInv1Eq1.Size = new System.Drawing.Size(121, 24);
            this.comboInv1Eq1.TabIndex = 2;
            this.comboInv1Eq1.SelectedIndexChanged += new System.EventHandler(this.ComboInv1_SelectedIndexChanged);
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
            // param2Eq1
            // 
            this.param2Eq1.Enabled = false;
            this.param2Eq1.Location = new System.Drawing.Point(258, 30);
            this.param2Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param2Eq1.Name = "param2Eq1";
            this.param2Eq1.Size = new System.Drawing.Size(32, 22);
            this.param2Eq1.TabIndex = 4;
            this.param2Eq1.TextChanged += new System.EventHandler(this.param2Eq1_TextChanged);
            this.param2Eq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
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
            // comboInv2Eq1
            // 
            this.comboInv2Eq1.Enabled = false;
            this.comboInv2Eq1.FormattingEnabled = true;
            this.comboInv2Eq1.Location = new System.Drawing.Point(325, 27);
            this.comboInv2Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv2Eq1.Name = "comboInv2Eq1";
            this.comboInv2Eq1.Size = new System.Drawing.Size(121, 24);
            this.comboInv2Eq1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(452, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "+";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // param3Eq1
            // 
            this.param3Eq1.Enabled = false;
            this.param3Eq1.Location = new System.Drawing.Point(473, 30);
            this.param3Eq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param3Eq1.Name = "param3Eq1";
            this.param3Eq1.Size = new System.Drawing.Size(40, 22);
            this.param3Eq1.TabIndex = 8;
            this.param3Eq1.TextChanged += new System.EventHandler(this.Param3_TextChanged);
            this.param3Eq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox3_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // relationEq1
            // 
            this.relationEq1.Enabled = false;
            this.relationEq1.Location = new System.Drawing.Point(518, 30);
            this.relationEq1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relationEq1.Name = "relationEq1";
            this.relationEq1.Size = new System.Drawing.Size(37, 22);
            this.relationEq1.TabIndex = 11;
            this.relationEq1.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            this.relationEq1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox4_KeyPress);
            // 
            // param1Eq2
            // 
            this.param1Eq2.Enabled = false;
            this.param1Eq2.Location = new System.Drawing.Point(46, 64);
            this.param1Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param1Eq2.Name = "param1Eq2";
            this.param1Eq2.Size = new System.Drawing.Size(32, 22);
            this.param1Eq2.TabIndex = 12;
            this.param1Eq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Param1Eq2_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "x";
            // 
            // comboInv1Eq2
            // 
            this.comboInv1Eq2.Enabled = false;
            this.comboInv1Eq2.FormattingEnabled = true;
            this.comboInv1Eq2.Location = new System.Drawing.Point(110, 61);
            this.comboInv1Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv1Eq2.Name = "comboInv1Eq2";
            this.comboInv1Eq2.Size = new System.Drawing.Size(121, 24);
            this.comboInv1Eq2.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(237, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "+";
            // 
            // param2Eq2
            // 
            this.param2Eq2.Enabled = false;
            this.param2Eq2.Location = new System.Drawing.Point(258, 64);
            this.param2Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param2Eq2.Name = "param2Eq2";
            this.param2Eq2.Size = new System.Drawing.Size(32, 22);
            this.param2Eq2.TabIndex = 16;
            this.param2Eq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Param2Eq2_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(298, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "x";
            // 
            // comboInv2Eq2
            // 
            this.comboInv2Eq2.Enabled = false;
            this.comboInv2Eq2.FormattingEnabled = true;
            this.comboInv2Eq2.Location = new System.Drawing.Point(325, 61);
            this.comboInv2Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInv2Eq2.Name = "comboInv2Eq2";
            this.comboInv2Eq2.Size = new System.Drawing.Size(121, 24);
            this.comboInv2Eq2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(452, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "+";
            // 
            // param3Eq2
            // 
            this.param3Eq2.Enabled = false;
            this.param3Eq2.Location = new System.Drawing.Point(473, 64);
            this.param3Eq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.param3Eq2.Name = "param3Eq2";
            this.param3Eq2.Size = new System.Drawing.Size(40, 22);
            this.param3Eq2.TabIndex = 20;
            this.param3Eq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Param3Eq2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "0";
            // 
            // relationEq2
            // 
            this.relationEq2.Enabled = false;
            this.relationEq2.Location = new System.Drawing.Point(518, 64);
            this.relationEq2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.relationEq2.Name = "relationEq2";
            this.relationEq2.Size = new System.Drawing.Size(37, 22);
            this.relationEq2.TabIndex = 22;
            this.relationEq2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RelationEq2_KeyPress);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enableEq2);
            this.groupBox1.Controls.Add(this.enableEq1);
            this.groupBox1.Controls.Add(this.relationEq2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.param3Eq2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.comboInv2Eq2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.param2Eq2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboInv1Eq2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.param1Eq2);
            this.groupBox1.Controls.Add(this.relationEq1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.param3Eq1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboInv2Eq1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.param2Eq1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboInv1Eq1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.param1Eq1);
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(585, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.textOutPath);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textoOrigem);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textoOrigem;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textOutPath;
        private System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.TextBox param1Eq1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboInv1Eq1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox param2Eq1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboInv2Eq1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox param3Eq1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox relationEq1;
        public System.Windows.Forms.TextBox param1Eq2;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboInv1Eq2;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox param2Eq2;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox comboInv2Eq2;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox param3Eq2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox relationEq2;
        public System.Windows.Forms.CheckBox enableEq1;
        public System.Windows.Forms.CheckBox enableEq2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

