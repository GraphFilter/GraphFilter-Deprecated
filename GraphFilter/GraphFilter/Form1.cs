using GraphFilter.GraphX_Utils;
using GraphFilter.Invariants;
using GraphX.Common.Enums;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.Logic.Algorithms.OverlapRemoval;
using GraphX.Logic.Models;
using MathNet.Numerics;
using NCalc;
using QuickGraph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Xml;

namespace GraphFilter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
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
            progressBar.Minimum = 0;
            progressBar.Maximum = 1;

            ListOfInvariants.Text = InvariantNum.AllNames();

            buttonFill.Enabled = false;
            buttonZoomOriginal.Enabled = false;
            buttonZoomOut.Enabled = false;
            buttonZoomIn.Enabled = false;
            buttonPrint.Enabled = false;
            buttonExp2PNG.Enabled = false;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBoxFiles.Width = this.Width - 320;

            textSource.Width = groupBoxFiles.Width - 120;
            textOutPath.Width = groupBoxFiles.Width - 120;

            groupBoxEq.Width = this.Width - 320;
            groupBoxCondition.Width = this.Width - 320;
            progressBar.Width = groupBoxCondition.Width - 115;

            textEquation1.Width = groupBoxCondition.Width - 67;
            textEquation2.Width = groupBoxCondition.Width - 67;
            textEquation3.Width = groupBoxCondition.Width - 67;

            tabControl.Width = this.Width - 40;
            tabControl.Height = this.Height - 80;

            wpfHost.Width = this.Width - 185;
            wpfHost.Height = this.Height - 107;
            textOpenViz.Width = this.Width - 200;
            listOfG6.Height = this.Height - 180;
            listOfG6Exp.Height = this.Height - 200;

            textOpenExp.Width = this.Width - 200;

            metroProgressSpinner.Top = listOfG6Exp.Height / 2;
            metroProgressSpinner.Left = textOpenExp.Width / 2;

            version.Left = this.Width - 120;
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
                        textSource.Text = ofd.FileName;
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
                        writer.Write(textSource.Text);
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
                        buttonFill.Enabled = true;
                        buttonZoomOriginal.Enabled = true;
                        buttonZoomIn.Enabled = true;
                        buttonZoomOut.Enabled = true;
                        buttonExp2PNG.Enabled = true;
                        buttonPrint.Enabled = true;
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
                            listOfG6Exp.Items.Add(g6Line);
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

        private UIElement GenerateWpfVisual2Export(string g6)
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
            /*if (listOfG6Exp.Items[i].ToString().Length != 0)
            {
                
            }*/
            logic.Graph = Conversor.G6toQuickGraph(g6);
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
            if (textEquation1.Enabled == true) System.Windows.Forms.MessageBox.Show("Please, verify your equation 1!");
            if (textEquation2.Enabled == true) System.Windows.Forms.MessageBox.Show("Please, verify your equation 2!");
            if (textEquation3.Enabled == true) System.Windows.Forms.MessageBox.Show("Please, verify your equation 3!");
            if (textEquation1.Enabled == false && textEquation2.Enabled == false && textEquation3.Enabled == false)
            {
                FilesFilter filesFilter = new FilesFilter(fileG6In, textOutPath.Text, this);
                double[] retorno = filesFilter.Run();
                System.Windows.Forms.MessageBox.Show("Busca realizada com sucesso! \nO percentual de grafos escolhidos é: " + retorno[2] + " %" + "\nO número de grafos escolhidos foi de: " + retorno[1] + "\nO número total de grafos que foram lidos foi de: " + retorno[0] + ".");
                System.Windows.Forms.Application.Restart();
            }
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

        private void paramRegularWithDegree_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (AllowNaturalNumber(paramRegularWithDegree.Text, e.KeyChar))
            {
                e.Handled = true;
            }
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


        #endregion

        #region Enable Check boxes
        private void EnableEq1_CheckedChanged(object sender, EventArgs e)
        {
            textEquation1.Enabled = enableEq1.Checked;
            verifyEq1.Enabled = enableEq1.Checked;
        }

        private void EnableEq2_CheckedChanged(object sender, EventArgs e)
        {
            textEquation2.Enabled = enableEq2.Checked;
            verifyEq2.Enabled = enableEq2.Checked;
        }

        private void enableEq3_CheckedChanged(object sender, EventArgs e)
        {
            textEquation3.Enabled = enableEq3.Checked;
            verifyEq3.Enabled = enableEq3.Checked;
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

        #region Control buttons
        private void buttonFill_Click(object sender, EventArgs e)
        {
            _zoomctrl.ZoomToFill();
        }
        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            _zoomctrl.ZoomToOriginal();
        }

        private void buttonZoomOut_Click_1(object sender, EventArgs e)
        {
            if (_zoomctrl.Zoom >= 0.5)
            {
                _zoomctrl.Zoom -= 0.25;
            }
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            if (_zoomctrl.Zoom <= 4)
            {
                _zoomctrl.Zoom += 0.25;
            }

        }

        private void buttonSavePNG_Click(object sender, EventArgs e)
        {
            int count = listOfG6Exp.Items.Count;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select file to export all graphs";
            fbd.ShowDialog();
            var path = fbd.SelectedPath;
            metroProgressSpinner.Value = 0;
            metroProgressSpinner.Visible = true;

            for (int i = 0; i < count; i++)
            {
                if (metroProgressSpinner.Value == 100) metroProgressSpinner.Value = 0;
                elementHost.Child = GenerateWpfVisual2Export(listOfG6Exp.Items[i].ToString());
                _gArea.GenerateGraph(true);
                _gArea.ShowAllEdgesLabels(false);
                _gArea.SetVerticesDrag(true, true);
                _gArea.ExportAsImage(fbd.SelectedPath + "\\" + i + ".png", ImageType.PNG, false, 96, 100);
                metroProgressSpinner.Value++;
            }
            metroProgressSpinner.Visible = false;
            metroProgressSpinner.Enabled = false;
            System.Windows.Forms.MessageBox.Show("Export finished!");
        }

        private void buttonExp2PNG_Click(object sender, EventArgs e)
        {
            if (listOfG6.SelectedItem != null)
            {
                _gArea.ExportAsImageDialog(ImageType.PNG, true, 96D, 100);
            }
        }
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (listOfG6.SelectedItem != null)
            {
                _gArea.PrintDialog();
            }
        }

        #endregion

        #region Don't delete

        private void listOfG6Exp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //buttonFill.Enabled = true;
        }
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

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void circularProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void loadingIndicatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void paramRegularWithDegree_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void verifyEq2_Click(object sender, EventArgs e)
        {
            try
            {
                BuildLogic.Text2BoolNCalc(textEquation2.Text, new Graph(new int[0, 0]));
                textEquation2.Enabled = false;
            }
            catch
            {

                System.Windows.Forms.MessageBox.Show("Invalid Equation!");
            }
        }

        private void verifyEq1_Click(object sender, EventArgs e)
        {
            try
            {
                BuildLogic.Text2BoolNCalc(textEquation1.Text, new Graph(new int[0, 0]));
                textEquation1.Enabled = false;
            }
            catch
            {

                System.Windows.Forms.MessageBox.Show("Invalid Equation!");
            }

        }

        private void buttonSearch_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void verifyEq3_Click(object sender, EventArgs e)
        {
            try
            {
                BuildLogic.Text2BoolNCalc(textEquation3.Text, new Graph(new int[0, 0]));
                textEquation3.Enabled = false;
            }
            catch
            {

                System.Windows.Forms.MessageBox.Show("Invalid Equation!");
            }
        }

        private void listOfInvariants_MouseHover(object sender, EventArgs e)
        {
            //listOfInvariants.Items[0].BackColor = Color.Black;
        }

        private void listOfInvariants_MouseClick(object sender, MouseEventArgs e)
        {
            //ListViewVisualItemEventArgs 
        }

        private void listOfInvariants_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //listOfInvariants.FocusedItem.BackColor = Color.White;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkUpdatesBtn_Click(object sender, EventArgs e)
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                try
                {
                    info = ad.CheckForDetailedUpdate();
                }
                catch (DeploymentDownloadException dde)
                {
                    System.Windows.Forms.MessageBox.Show("The new version of the application cannot be downloaded at this time. \nPlease check your network connection, or try again later. Error: " + dde.Message);
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    System.Windows.Forms.MessageBox.Show("Cannot check for a new version of the application. The ClickOnce deployment is corrupt. Please redeploy the application and try again. Error: " + ide.Message);
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    System.Windows.Forms.MessageBox.Show("This application cannot be updated. It is likely not a ClickOnce application. Error: " + ioe.Message);
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        DialogResult dr = System.Windows.Forms.MessageBox.Show("An update is available. Would you like to update the application now?", "Update Available", MessageBoxButtons.OKCancel);
                        if (!(DialogResult.OK == dr))
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        //Display a message that the app must be reboot. Display the minimum required version.
                        System.Windows.Forms.MessageBox.Show("This application has detected a mandatory update from your current " + ". The application will now install the update and restart.", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            System.Windows.Forms.MessageBox.Show("The application has been upgraded, and will now restart.");
                            System.Windows.Forms.Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            System.Windows.Forms.MessageBox.Show("Cannot install the latest version of the application. \nPlease check your network connection, or try again later. Error: " + dde);
                        }
                    }
                }
            }
        }

        private void CheckUpdateButton_Click(object sender, EventArgs e)
        {
            
        }
    }

    #endregion



    /*[DllImport("BoostLib.dll", EntryPoint = "mixed_mode_multiply", CallingConvention = CallingConvention.StdCall)]
    public static extern int Multiply(int x, int y);
    private void button3_Click(object sender, EventArgs e)
    {
        int result = Multiply(7, 7);
        //Console.WriteLine("The answer is {0}", result);
        System.Windows.Forms.MessageBox.Show(result.ToString());
    }*/
}

