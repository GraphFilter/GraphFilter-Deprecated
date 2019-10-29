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
            this.checkedListProperties = new System.Windows.Forms.CheckedListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textDestino = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(139, 30);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Abrir Arquivo";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(12, 51);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(139, 30);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Salvar Como";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textoOrigem
            // 
            this.textoOrigem.Enabled = false;
            this.textoOrigem.Location = new System.Drawing.Point(157, 16);
            this.textoOrigem.Name = "textoOrigem";
            this.textoOrigem.Size = new System.Drawing.Size(440, 22);
            this.textoOrigem.TabIndex = 2;
            this.textoOrigem.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // checkedListProperties
            // 
            this.checkedListProperties.CheckOnClick = true;
            this.checkedListProperties.ColumnWidth = 200;
            this.checkedListProperties.FormattingEnabled = true;
            this.checkedListProperties.Location = new System.Drawing.Point(12, 110);
            this.checkedListProperties.MultiColumn = true;
            this.checkedListProperties.Name = "checkedListProperties";
            this.checkedListProperties.Size = new System.Drawing.Size(776, 174);
            this.checkedListProperties.Sorted = true;
            this.checkedListProperties.TabIndex = 3;
            this.checkedListProperties.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(12, 290);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(139, 30);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textDestino
            // 
            this.textDestino.Enabled = false;
            this.textDestino.Location = new System.Drawing.Point(157, 55);
            this.textDestino.Name = "textDestino";
            this.textDestino.Size = new System.Drawing.Size(440, 22);
            this.textDestino.TabIndex = 5;
            this.textDestino.TextChanged += new System.EventHandler(this.TextDestino_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textDestino);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkedListProperties);
            this.Controls.Add(this.textoOrigem);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textoOrigem;
        private System.Windows.Forms.CheckedListBox checkedListProperties;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textDestino;
    }
}

