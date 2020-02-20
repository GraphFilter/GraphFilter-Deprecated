using GraphFilter.Invariants;
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
        StreamWriter fileG6Out;
        int qtdLinhasIn;

        public Form1()
        {
            InitializeComponent();
        }
        #region File Input and Output
        private void ButtonInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivo g6 | *.g6";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
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

        private void ButtonOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo g6 | *.g6";
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName) == false)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(textoOrigem.Text);
                        writer.Flush();
                        textOutPath.Text = sfd.FileName;
                        buttonSearch.Enabled = true;
                        this.fileG6Out = writer;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível salvar o seu arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            comboInv1Eq1.Items.AddRange(Build.ComboBox());
            comboInv2Eq1.Items.AddRange(Build.ComboBox());
            comboInv1Eq2.Items.AddRange(Build.ComboBox());
            comboInv2Eq2.Items.AddRange(Build.ComboBox());

        }

        #region Button Search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            FilesFilter filesFilter = new FilesFilter(fileG6In, textOutPath.Text,this);
            double[] retorno = filesFilter.Run();
            MessageBox.Show("Busca realizada com sucesso! \nO percentual de grafos escolhidos é: " + retorno[2] + " %" + "\nO número de grafos escolhidos foi de: " + retorno[1] + "\nO número total de grafos que foram lidos foi de: " + retorno[0] + ".");
/*
            string condition1 = "R????A?O@?A?A?@??OCA?[??L?AC?_";
            double numberOfGraphsIn = 0;
            double numberOfGraphsOut = 0;
            int indiceProgressBar = 1;
            using (StreamReader stReaderIn = new StreamReader(fileG6In))
            {
                using (StreamWriter stWriterOut = new StreamWriter(textOutPath.Text))
                {
                    String g6Line = stReaderIn.ReadLine();
                    while (g6Line != null)
                    {
                        progressBar.Value = indiceProgressBar;
                        if (Build.Condition(param1Eq1.Text, comboInv1Eq1.SelectedIndex, param2Eq1.Text, comboInv2Eq1.SelectedIndex, param3Eq1.Text, relationEq1.Text, new Graph(g6Line)))
                        {
                            numberOfGraphsOut++;
                            stWriterOut.WriteLine(g6Line);
                        }
                        numberOfGraphsIn++;
                        g6Line = stReaderIn.ReadLine();
                        indiceProgressBar++;
                    }
                }
            }
            double percentual = Math.Round((numberOfGraphsOut / numberOfGraphsIn) * 100, 2);
            MessageBox.Show("Busca realizada com sucesso! \nO percentual de grafos escolhidos é: " + percentual + " %" + "\nO número de grafos escolhidos foi de: " + numberOfGraphsOut + "\nO número total de grafos que foram lidos foi de: " + numberOfGraphsIn + ".");
     */
        }
        #endregion

        #region TextBox Parameters
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private bool AllowNumber(string textBox, char ch1)
        {
            char ch = ch1;
            if (textBox.Length == 0)
            {
                if (ch == 45 && textBox.IndexOf('-') != -1)
                {
                    return true;
                }
                if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
                {
                    return true;
                }
            }
            else
            {
                if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
                {
                    return true;
                }
                if (ch == 46 && textBox.IndexOf('.') != -1)
                {
                    return true;
                }
            }
            return false;
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (AllowNumber(param1Eq1.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param2Eq1.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param3Eq1.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Param1Eq2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param1Eq2.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Param2Eq2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param2Eq2.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Param3Eq2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param3Eq2.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            relationEq1.MaxLength = 2;
        }

        private bool AllowRelation(string textBox, char ch1)
        {
            char ch = ch1;
            if (textBox.Length != 0)
            {
                if (textBox.Contains('<'))
                {
                    if (!char.IsControl(ch) && ch != '=')
                    {
                        return true;
                    }
                }
                if (textBox.Contains('='))
                {
                    if (!char.IsControl(ch))
                    {
                        return true;
                    }
                }

                if (textBox.Contains('>'))
                {
                    if (!char.IsControl(ch) && ch != '=')
                    {
                        return true;
                    }
                }
            }
            if (!char.IsControl(ch) && ch != '<' && ch != '=' && ch != '>')
            {
                return true;
            }
            return false;
        }
        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(AllowRelation(relationEq1.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void RelationEq2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowRelation(relationEq2.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Don't delete

        private void TextDestino_TextChanged(object sender, EventArgs e)
        {
        }

        private void ComboInv1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Label5_Click(object sender, EventArgs e)
        {
        }

        private void Label5_Click_1(object sender, EventArgs e)
        {
        }

        private void Label6_Click(object sender, EventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void Label3_Click(object sender, EventArgs e)
        {
        }

        private void Label4_Click(object sender, EventArgs e)
        {
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void Param3_TextChanged(object sender, EventArgs e)
        {
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        #region Enable Check boxes
        private void EnableEq1_CheckedChanged(object sender, EventArgs e)
        {
            if (enableEq1.Checked == true)
            {
                param1Eq1.Enabled = true;
                comboInv1Eq1.Enabled = true;
                param2Eq1.Enabled = true;
                comboInv2Eq1.Enabled = true;
                param3Eq1.Enabled = true;
                relationEq1.Enabled = true;
            }
            else
            {
                param1Eq1.Enabled = false;
                comboInv1Eq1.Enabled = false;
                param2Eq1.Enabled = false;
                comboInv2Eq1.Enabled = false;
                param3Eq1.Enabled = false;
                relationEq1.Enabled = false;
            }
        }

        private void EnableEq2_CheckedChanged(object sender, EventArgs e)
        {
            if (enableEq2.Checked == true)
            {
                param1Eq2.Enabled = true;
                comboInv1Eq2.Enabled = true;
                param2Eq2.Enabled = true;
                comboInv2Eq2.Enabled = true;
                param3Eq2.Enabled = true;
                relationEq2.Enabled = true;
            }
            else
            {
                param1Eq2.Enabled = false;
                comboInv1Eq2.Enabled = false;
                param2Eq2.Enabled = false;
                comboInv2Eq2.Enabled = false;
                param3Eq2.Enabled = false;
                relationEq2.Enabled = false;
            }
        }
        #endregion

        private void param2Eq1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

