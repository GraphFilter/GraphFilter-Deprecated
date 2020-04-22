﻿using GraphFilter.GraphX_Utils;
using GraphX.Common.Enums;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.Logic.Algorithms.OverlapRemoval;
using GraphX.Logic.Models;
using QuickGraph;
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;


namespace GraphFilter
{
    public partial class Form1 : Form
    {
        #region Form1 properties
        Stream fileG6In;
        StreamWriter fileG6Out;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboInv1Eq1.Items.AddRange(BuildLogic.ComboBox());
            comboInv2Eq1.Items.AddRange(BuildLogic.ComboBox());
            comboInv1Eq2.Items.AddRange(BuildLogic.ComboBox());
            comboInv2Eq2.Items.AddRange(BuildLogic.ComboBox());
            comboInv1Eq3.Items.AddRange(BuildLogic.ComboBox());
            comboInv2Eq3.Items.AddRange(BuildLogic.ComboBox());
            progressBar.Minimum = 0;
            progressBar.Maximum = 1;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            textoOrigem.Width = this.Width - 145;
            textOutPath.Width = this.Width - 145;
            groupBox1.Width = this.Width - 37;
            groupBox2.Width = this.Width - 37;
            progressBar.Width = this.Width - 146;

            wpfHost.Width = this.Width - 185;
            wpfHost.Height = this.Height - 107;
            textOpenViz.Width = this.Width - 185;
            listOfG6.Height = this.Height - 100;
        }
        private void listOfG6_SelectedIndexChanged(object sender, EventArgs e)
        {
            wpfHost.Child = GenerateWpfVisuals(listOfG6.SelectedItem.ToString());
            _gArea.GenerateGraph(true);
            _gArea.ShowAllEdgesLabels(false);
            _gArea.SetVerticesDrag(true, true);
            _zoomctrl.ZoomToFill();
        }
        #endregion

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
                        while (reader.ReadLine() != null)
                        {
                            progressBar.Maximum++;
                        }
                        progressBar.Maximum--;
                        textoOrigem.Text = ofd.FileName;
                        buttonSave.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo, Erro: {0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    System.Windows.Forms.MessageBox.Show("Não foi possível salvar o seu arquivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                        string g6Line = reader.ReadLine();
                        while (g6Line != null)
                        {
                            listOfG6.Items.Add(g6Line);
                            g6Line = reader.ReadLine();
                        }
                        textOpenViz.Text = ofd.FileName;
                    }
                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo, Erro: {0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                        string g6Line = reader.ReadLine();
                        while (g6Line != null)
                        {
                            g6Line = reader.ReadLine();
                        }
                        textOpenExp.Text = ofd.FileName;
                    }
                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo, Erro: {0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Visual properties
        private ZoomControl _zoomctrl;
        private GraphAreaView _gArea;

        private UIElement GenerateWpfVisuals(string g6)
        {
            _zoomctrl = new ZoomControl();
            ZoomControl.SetViewFinderVisibility(_zoomctrl, Visibility.Hidden);
            var logic = new GXLogicCore<DataVertex, DataEdge, BidirectionalGraph<DataVertex, DataEdge>>();
            _gArea = new GraphAreaView
            {
                LogicCore = logic,
                EdgeLabelFactory = new DefaultEdgelabelFactory()
            };
            _gArea.ShowAllEdgesLabels(false);

            logic.DefaultLayoutAlgorithm = LayoutAlgorithmTypeEnum.LinLog;
            logic.DefaultLayoutAlgorithmParams = logic.AlgorithmFactory.CreateLayoutParameters(LayoutAlgorithmTypeEnum.LinLog);
            if (listOfG6.SelectedItem != null)
            {
                logic.Graph = Conversor.G6toQuickGraph(g6);
            }
            logic.DefaultOverlapRemovalAlgorithm = OverlapRemovalAlgorithmTypeEnum.FSA;
            logic.DefaultOverlapRemovalAlgorithmParams = logic.AlgorithmFactory.CreateOverlapRemovalParameters(OverlapRemovalAlgorithmTypeEnum.FSA);
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).HorizontalGap = 100;
            ((OverlapRemovalParameters)logic.DefaultOverlapRemovalAlgorithmParams).VerticalGap = 100;
            logic.DefaultEdgeRoutingAlgorithm = EdgeRoutingAlgorithmTypeEnum.None;
            logic.AsyncAlgorithmCompute = false;

            _zoomctrl.Content = _gArea;
            _gArea.RelayoutFinished += gArea_RelayoutFinished;

            //Edge visualization edit
            _gArea.SetEdgesDashStyle(EdgeDashStyle.Solid);
            _gArea.ShowAllEdgesArrows(false);

            var myResourceDictionary = new ResourceDictionary { Source = new Uri("GraphX_Utils\\template.xaml", UriKind.Relative) };
            _zoomctrl.Resources.MergedDictionaries.Add(myResourceDictionary);

            return _zoomctrl;
        }

        private void gArea_RelayoutFinished(object sender, EventArgs e)
        {
            _zoomctrl.ZoomToFill();
        }
        #endregion

        #region Button Search
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            FilesFilter filesFilter = new FilesFilter(fileG6In, textOutPath.Text, this);
            double[] retorno = filesFilter.Run();
            System.Windows.Forms.MessageBox.Show("Busca realizada com sucesso! \nO percentual de grafos escolhidos é: " + retorno[2] + " %" + "\nO número de grafos escolhidos foi de: " + retorno[1] + "\nO número total de grafos que foram lidos foi de: " + retorno[0] + ".");
            System.Windows.Forms.Application.Restart();
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

        private bool AllowNaturalNumber(string textBox, char ch1)
        {
            char ch = ch1;
            if (textBox.Length == 0)
            {
                if (!Char.IsDigit(ch) && ch != 8)
                {
                    return true;
                }
            }
            else
            {
                if (!Char.IsDigit(ch) && ch != 8)
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

        private void Param3Eq2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param2Eq2.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void param1Eq3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param1Eq3.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void param3Eq3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowNumber(param2Eq3.Text, e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void paramRegularWithDegree_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (AllowNaturalNumber(paramRegularWithDegree.Text, e.KeyChar))
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
            if (AllowRelation(relationEq1.Text, e.KeyChar))
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

        private void relationEq3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (AllowRelation(relationEq3.Text, e.KeyChar))
            {
                e.Handled = true;
            }
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
                comboInv2Eq2.Enabled = true;
                param2Eq2.Enabled = true;
                relationEq2.Enabled = true;
            }
            else
            {
                param1Eq2.Enabled = false;
                comboInv1Eq2.Enabled = false;
                comboInv2Eq2.Enabled = false;
                param2Eq2.Enabled = false;
                relationEq2.Enabled = false;
            }
        }

        private void enableEq3_CheckedChanged(object sender, EventArgs e)
        {
            if (enableEq3.Checked == true)
            {
                param1Eq3.Enabled = true;
                comboInv1Eq3.Enabled = true;
                comboInv2Eq3.Enabled = true;
                param2Eq3.Enabled = true;
                relationEq3.Enabled = true;
            }
            else
            {
                param1Eq3.Enabled = false;
                comboInv1Eq3.Enabled = false;
                comboInv2Eq3.Enabled = false;
                param2Eq3.Enabled = false;
                relationEq3.Enabled = false;
            }


        }

        private void enableRegularWithK_CheckedChanged(object sender, EventArgs e)
        {
            if (enableRegularWithK.Checked == true) paramRegularWithDegree.Enabled = true;
            else paramRegularWithDegree.Enabled = false;
        }

        private void enableIsConnected_CheckedChanged(object sender, EventArgs e)
        {

        }



        #endregion

        #region Don't delete

        private void visualization_Click(object sender, EventArgs e)
        {

        }
        private void filterGraphs_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void wpfHost_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        private void param2Eq1_TextChanged(object sender, EventArgs e)
        {

        }

        private void paramRegularWithDegree_TextChanged(object sender, EventArgs e)
        {

        }

        public void enableRegular_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void enableRegular_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
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
        
    }
}

