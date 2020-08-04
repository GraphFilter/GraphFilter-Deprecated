using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml;

namespace GraphFilter
{
    class CheckForUpdates
    {
        public void DoUpdate()
        {
            string downloadUrl = "http://sistemas.jf.ifsudestemg.edu.br/graphfilter/download";
            Version newVersion = null;
            string xmlUrl = "http://sistemas.jf.ifsudestemg.edu.br/graphfilter/update/";
            XmlTextReader reader = null;
            try
            {
                /*WebPermission myWebPermission = new WebPermission(PermissionState.None);
                myWebPermission.AddPermission(NetworkAccess.Connect, "http://sistemas.jf.ifsudestemg.edu.br/graphfilter/update/");
                PermissionSet myPermissions = new PermissionSet(PermissionState.None);
                myPermissions.AddPermission(myWebPermission);
                XmlSecureResolver myResolver = new XmlSecureResolver(new XmlUrlResolver(), myPermissions);*/
                reader = new XmlTextReader(xmlUrl);

                reader.MoveToContent();
                string elementName = "";
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "graphfilter"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            elementName = reader.Name;
                        }
                        else
                        {
                            if ((reader.NodeType == XmlNodeType.Text) && (reader.HasValue))
                            {
                                switch (elementName)
                                {
                                    case "version":
                                        newVersion = new Version(reader.Value);
                                        break;
                                    case "url":
                                        downloadUrl = reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }

            Version applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (applicationVersion.CompareTo(newVersion) < 0)
            {
                DialogResult confirm = System.Windows.Forms.MessageBox.Show("Version" + newVersion.Major + "." + newVersion.Minor + "." + newVersion.Build + "GraphFilter is now available, would you like to download it?", "\n", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(downloadUrl);
                }
                else
                {
                    //Environment.Exit(1);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("This program is up to date!");
            }
        }
    }
}
