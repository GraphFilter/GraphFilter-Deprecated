using System;
using System.Windows.Forms;

namespace SharpUpdate
{
    public partial class SharpUpdateInfoForm : MetroFramework.Forms.MetroForm
    {
        public SharpUpdateInfoForm(ISharpUpdatable applicationInfo, SharpUpdateXml updateInfo)
        {
            InitializeComponent();

            if (applicationInfo.ApplicationIcon != null)
                this.Icon = applicationInfo.ApplicationIcon;

            this.Text = applicationInfo.ApplicationName + " - Update Info";
            this.lblVersions.Text = String.Format("Current Version: {0}\nUpdate Version: {1}", applicationInfo.ApplicationAssembly.GetName().ToString(),
                updateInfo.Version.ToString());
            this.txtDescription.Text = updateInfo.Description;

        }

        private void SharpUpdateInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDescription_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (!(e.Control && e.KeyCode == Keys.C))
                e.SuppressKeyPress = true;
        }
    }
}
