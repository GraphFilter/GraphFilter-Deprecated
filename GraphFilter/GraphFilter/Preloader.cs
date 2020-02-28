using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphFilter
{
    public partial class Preloader : Form
    {
        public Preloader()
        {
            InitializeComponent();
        }

        public void Preloader_Load(object sender, EventArgs e)
        {
            runningProgress.Value = 0;
            runningProgress.Minimum = 0;
            runningProgress.Maximum = 100;
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                runningProgress.Value = i;
                runningProgress.Update();

            }
        }
    }
}
