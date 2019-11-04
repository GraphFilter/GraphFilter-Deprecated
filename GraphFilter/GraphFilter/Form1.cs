using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphFilter
{
    public partial class Form1 : Form
    {
        Stream fileG6In;
        int qtdLinhasIn;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            ofd.Filter = "Arquivo texto | *.txt";
            ofd.ShowDialog();
            if(string.IsNullOrEmpty(ofd.FileName) == false) {
                try
                {
                    using (StreamReader reader = new StreamReader(ofd.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-br").TextInfo.ANSICodePage)))
                    {
                        fileG6In = ofd.OpenFile();
                        qtdLinhasIn = File.ReadLines(ofd.FileName).Count();
                        progressBar.Maximum = qtdLinhasIn;
                        progressBar.Minimum = 0;
                        textoOrigem.Text = ofd.FileName;
                        buttonSave.Enabled = true;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo, Erro: {0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo texto | *.txt";
            sfd.ShowDialog();

            if(string.IsNullOrEmpty(sfd.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(textoOrigem.Text);
                        writer.Flush();
                        textDestino.Text = sfd.FileName;
                        buttonSearch.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível salvar o seu arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string condicao1 = "R????A?O@?A?A?@??OCA?[??L?AC?_";
            double numberOfGraphsIn = 0;
            double numberOfGraphsOut = 0;
            int indiceProgressBar = 1;
            using (StreamReader leitor = new StreamReader(fileG6In))
            {
                using (StreamWriter gravador = new StreamWriter(textDestino.Text))
                {
                    String g6Atual = leitor.ReadLine();
                    while (g6Atual != null)
                    {
                        progressBar.Value = indiceProgressBar;
                        if (g6Atual.Contains(condicao1))
                        {
                            numberOfGraphsOut++;
                            gravador.WriteLine(g6Atual);
                        }
                        numberOfGraphsIn++;
                        g6Atual = leitor.ReadLine();
                        indiceProgressBar++;
                    }
                }
            }
            double percentual = Math.Round((numberOfGraphsOut / numberOfGraphsIn) * 100, 2);
            MessageBox.Show("Busca realizada com sucesso! \nO percentual de grafos escolhidos é: " + percentual + " %" + "\nO número de grafos escolhidos foi de: " + numberOfGraphsOut +  "\nO número total de grafos que foram lidos foi de: " + numberOfGraphsIn + ".");
        }

        private void TextDestino_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
