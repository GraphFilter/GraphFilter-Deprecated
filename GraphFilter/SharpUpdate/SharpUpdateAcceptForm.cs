using System;
using System.Windows.Forms;

namespace SharpUpdate
{
    internal partial class SharpUpdateAcceptForm : MetroFramework.Forms.MetroForm
    {
        private ISharpUpdatable applicationInfo;

        private SharpUpdateXml updateInfo;

        private SharpUpdateInfoForm updateInfoForm;

        internal SharpUpdateAcceptForm(ISharpUpdatable applicationInfo, SharpUpdateXml updateInfo)
        {
            InitializeComponent();

            this.applicationInfo = applicationInfo;
            this.updateInfo = updateInfo;

            this.Text = this.applicationInfo.ApplicationName + " - Update Available";

            if (this.applicationInfo.ApplicationIcon != null)
                this.Icon = this.applicationInfo.ApplicationIcon;

            this.lblNewVersion.Text = string.Format("New version: {0}", this.updateInfo.Version.ToString());
        }

        private void SharpUpdateAcceptForm_Load(object sender, EventArgs e)
        {

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (this.updateInfoForm == null)
                this.updateInfoForm = new SharpUpdateInfoForm(this.applicationInfo, this.updateInfo);

            this.updateInfoForm.ShowDialog(this);
        }
    }
}
