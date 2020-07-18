using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GraphFilter
{
    public partial class PleaseWaitForm : Form
    {
        public PleaseWaitForm()
        {
            InitializeComponent();
        }

        const int MF_BYCOMMAND = 0x400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRever);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        private void PleaseWaitForm_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int CountMenu = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, CountMenu, MF_BYCOMMAND);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
