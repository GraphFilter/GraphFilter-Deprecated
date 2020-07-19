using GraphFilter.GraphX_Utils;
using GraphFilter.Invariants;
using GraphX.Common.Enums;
using GraphX.Controls;
using GraphX.Controls.Models;
using GraphX.Logic.Algorithms.OverlapRemoval;
using GraphX.Logic.Models;
using MathNet.Numerics;
using QuickGraph;
using Squirrel;
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
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;
using SharpUpdate;
using System.Reflection;
using System.Net;
using System.IO;
using Flee.PublicTypes;

namespace GraphFilter
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        #region Form1 properties
        Stream fileG6In;
        StreamWriter fileG6Out;
        List<string> listg6In = new List<string>();

        private SharpUpdater updater;

        public Form1()
        {
            InitializeComponent();

            updater = new SharpUpdater(Assembly.GetExecutingAssembly(), this, new Uri("http://sistemas.jf.ifsudestemg.edu.br/graphfilter/update/update.xml"));

            this.lblVersion.Text = this.ApplicationAssembly.GetName().Version.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Minimum = 0;
            progressBar.Maximum = 1;

            foreach (IInvariant invariant in InvariantNum.List())
            {
                ListOfInvariants.Text += "\n" + invariant.getCode() + ": " + invariant.getName();   
            }
            ListOfInvariants.Text += "\n" + "\n" + "\n";
            ListOfInvariants.Text += "--- arguments --- \n Graph G \n Complement of graph: cG \n line graph: lG";
            buttonFill.Enabled = false;
            buttonZoomOriginal.Enabled = false;
            buttonZoomOut.Enabled = false;
            buttonZoomIn.Enabled = false;
            buttonPrint.Enabled = false;
            buttonExp2PNG.Enabled = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            groupBoxFiles.Width = this.Width - 330;

            textSource.Width = groupBoxFiles.Width - 120;
            textOutPath.Width = groupBoxFiles.Width - 120;

            groupBoxEq.Width = this.Width - 330;
            groupBoxCondition.Width = this.Width - 330;
            progressBar.Width = this.Width - 330;

            textEquation1.Width = groupBoxCondition.Width - 85;

            tabControl.Width = this.Width - 40;
            tabControl.Height = this.Height - 80;

            wpfHost.Width = this.Width - 185;
            wpfHost.Height = this.Height - 107;
            textOpenViz.Width = this.Width - openG6BtnViz.Width - 75;
            listOfG6.Height = this.Height - 230;

            insertG6ToView.Width = this.Width - viewG6Btn.Width - 75;

            lblVersion.Left = this.Width - 230;
            chkUpdBtn.Left = this.Width - 160;

            showInvariantsCheck.Left = this.Width - 300;
            showGraphInvariantLbl.Left = this.Width - 260;
        }
        private void listOfG6_SelectedIndexChanged(object sender, EventArgs e)
        {
            listInvResults.Rows.Clear();
            string g6Line = "";
            if (listOfG6.SelectedItem != null && listOfG6.SelectedItem.ToString().Length != 0 && listOfG6.SelectedItem.ToString() != " ")
            {
                g6Line = listOfG6.SelectedItem.ToString();
                wpfHost.Child = GenerateWpfVisuals(listOfG6.SelectedItem.ToString());
                _gArea.GenerateGraph(true);
                _gArea.ShowAllEdgesLabels(false);
                _gArea.SetVerticesDrag(true, true);
                _zoomctrl.ZoomToFill();
            }
        }
        #endregion

        #region File Input and Output
        private void ButtonInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivo g6 | *.g6";
            ofd.ShowDialog();
            //abre a janela de please wait!
            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                try
                {

                    listg6In = File.ReadAllLines(ofd.FileName).ToList();
                    progressBar.Maximum = listg6In.Count;
                    textSource.Text = ofd.FileName;
                    buttonSave.Enabled = true;
                    buttonCounterexample.Enabled = true;
                }
                //Fecha a janela de please wait
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

        private void viewG6Btn_Click(object sender, EventArgs e)
        {
            if (insertG6ToView.Text != null && insertG6ToView.Text.Length != 0 && insertG6ToView.Text != " ")
            {
                listOfG6.Items.Add((insertG6ToView.Text));
                listOfG6.SetSelected(0, true);
                wpfHost.Child = GenerateWpfVisuals(insertG6ToView.Text);
                _gArea.GenerateGraph(true);
                _gArea.ShowAllEdgesLabels(false);
                _gArea.SetVerticesDrag(true, true);
                _zoomctrl.ZoomToFill();
                buttonFill.Enabled = true;
                buttonZoomOriginal.Enabled = true;
                buttonZoomIn.Enabled = true;
                buttonZoomOut.Enabled = true;
                buttonExp2PNG.Enabled = true;
                buttonPrint.Enabled = true;
                buttonExportAll.Enabled = true;
                listOfG6.Visible = true;
            }   
        }
        #endregion

        #region SharpUpdate
        public string ApplicationName
        {
            get { return "GraphFilter"; }
        }

        public string ApplicationID
        {
            get { return "GraphFilter"; }
        }

        public Assembly ApplicationAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Icon ApplicationIcon
        {
            get { return this.Icon; }
        }

        public Uri UpdateXmlLocation
        {
            get { return new Uri("http://sistemas.jf.ifsudestemg.edu.br/graphfilter/update/update.xml"); }
        }
        public Form Context
        {
            get { return this; }
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
            if (listOfG6.SelectedItem != null || insertG6ToView.Text != null)
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
            if (textEquation1.Enabled == true) System.Windows.Forms.MessageBox.Show("Please, verify your equation!");
            if (textEquation1.Enabled == false)
            {
                buttonCounterexample.Enabled = false;
                FilesFilter filesFilter = new FilesFilter(listg6In, textOutPath.Text, this);
                double[] retorno = filesFilter.Run();
                System.Windows.Forms.MessageBox.Show("Busca realizada com sucesso! \nO percentual de grafos escolhidos é: " + retorno[2] + " %" + "\nO número de grafos escolhidos foi de: " + retorno[1] + "\nO número total de grafos que foram lidos foi de: " + retorno[0] + ".");
                progressBar.Value = 0;
            }
        }


        private void buttonCounterexample_Click(object sender, EventArgs e)
        {
            if (textEquation1.Enabled == true) System.Windows.Forms.MessageBox.Show("Please, verify your equation!");
            if (textEquation1.Enabled == false)
            {
                buttonSearch.Enabled = false;
                FilesFilter filesFilter = new FilesFilter(listg6In, this);
                string retorno = filesFilter.RunCounterexample();
                if (retorno == "XX") System.Windows.Forms.MessageBox.Show("No counterexamples found.");
                else
                {
                    insertG6ToView.Text = retorno;
                    System.Windows.Forms.MessageBox.Show("Counterexample found, see the Visualization tab");
                }
                buttonSearch.Enabled = true;
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
            /*textEquation2.Enabled = enableEq2.Checked;
            verifyEq2.Enabled = enableEq2.Checked;*/
        }

        private void enableEq3_CheckedChanged(object sender, EventArgs e)
        {
            /*textEquation3.Enabled = enableEq3.Checked;
            verifyEq3.Enabled = enableEq3.Checked;*/
        }

        private void enableRegularWithK_CheckedChanged(object sender, EventArgs e)
        {

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

        private void verifyEq1_Click(object sender, EventArgs e)
        {
            try
            {
                BuildLogic.ValidadeEquation(textEquation1.Text);
                textEquation1.Enabled = false;
            }
            catch (ExpressionCompileException ex)
            {
                System.Windows.Forms.MessageBox.Show("Invalid Equation!" + "\n\n" + ex.Message);
            }

        }

        private void buttonSearch_EnabledChanged(object sender, EventArgs e)
        {
        }

        private void listInvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void openG6BtnViz_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Arquivo g6 | *.g6";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                try
                {
                    List<string> listg6ToView = File.ReadAllLines(ofd.FileName).ToList();
                    fileG6In = ofd.OpenFile();
                    foreach (string item in listg6ToView) listOfG6.Items.Add(item);
                    textOpenViz.Text = ofd.FileName;
                    buttonFill.Enabled = true;
                    buttonZoomOriginal.Enabled = true;
                    buttonZoomIn.Enabled = true;
                    buttonZoomOut.Enabled = true;
                    buttonExp2PNG.Enabled = true;
                    buttonPrint.Enabled = true;
                    buttonExportAll.Enabled = true;

                }
                catch (Exception ex)
                {

                    System.Windows.Forms.MessageBox.Show(string.Format("Não foi possível abrir o seu arquivo, Erro: {0}", ex.Message), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                listOfG6.Visible = true;
            }
        }

        private void showInvariantsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showInvariantsCheck.Checked == true)
            {
                if (listOfG6.Visible == true)
                {
                    foreach (IInvariant invariant in InvariantNum.List())
                    {
                        listInvResults.Rows.Add(new string[]
                        {
                        invariant.getName(), invariant.Calculate(new Graph(listOfG6.SelectedItem.ToString())).ToString()
                        });
                    }
                    listInvResults.Columns[0].ReadOnly = true;
                    listInvResults.Columns[1].ReadOnly = true;
                    listInvResults.Visible = true;
                }
            }
            else
            {
                listInvResults.Visible = false;
            }
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void enableRegularWithK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (enableRegularWithK.Checked == true) paramRegularWithDegree.Enabled = true;
            else paramRegularWithDegree.Enabled = false;
        }

        private void paramRegularWithDegree_Click(object sender, EventArgs e)
        {

        }

        private void chkUpdBtn_Click(object sender, EventArgs e)
        {
            WebRequest wr = WebRequest.Create(new Uri("http://sistemas.jf.ifsudestemg.edu.br/graphfilter/update/version.txt"));
            WebResponse ws = wr.GetResponse();
            StreamReader sr = new StreamReader(ws.GetResponseStream());

            string currentVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string newVersion = sr.ReadToEnd();

            if (currentVersion.Contains(newVersion))
            {
                System.Windows.Forms.MessageBox.Show("This program is up to date!", "GraphFilter - Updated", MessageBoxButtons.OK);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("New update is available!" + "\nYou can download it by accessing our website.", "GraphFilter - Update Available", MessageBoxButtons.OK);
            }
        }

        private void ListOfInvariants_Click(object sender, EventArgs e)
        {

        }

        private void insertG6ToView_Click(object sender, EventArgs e)
        {

        }

        private void buttonExportAll_Click(object sender, EventArgs e)
        {
            int count = listOfG6.Items.Count;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select file to export all graphs";
            fbd.ShowDialog();
            var path = fbd.SelectedPath;
            if (path.Length != 0)
            {
                metroProgressSpinner.Value = 0;
                metroProgressSpinner.Visible = true;
                for (int i = 0; i < count; i++)
                {
                    if (metroProgressSpinner.Value == 100) metroProgressSpinner.Value = 0;
                    wpfHost.Child = GenerateWpfVisual2Export(listOfG6.Items[i].ToString());
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

