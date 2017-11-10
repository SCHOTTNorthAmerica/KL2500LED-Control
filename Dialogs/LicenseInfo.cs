using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SCHOTT.KL2500LED.Control.Dialogs
{
    public partial class LicenseInfo : Form
    {
        public LicenseInfo(Form ownerForm)
        {
            InitializeComponent();
            
            Owner = ownerForm;
        }
        
        private void ok_Click(object sender, EventArgs e)
        {
            Close();
        }

        private static string GetEmbeddedText(string embeddedNameContains)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fileName = assembly.GetManifestResourceNames()
                .Single(s => s.Contains(embeddedNameContains));

            var stream = assembly.GetManifestResourceStream(fileName);
            if (stream == null) return "";

            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;

            switch (listView1.SelectedItems[0].Text)
            {
                case "SCHOTT KL2500LED Control":
                    description.Text = @"The SCHOTT KL2500LED Control is a demonstrator for the other SCHOTT Libraries, as well as a basic application that can be used for configuring the SCHOTT KL2500LED.";
                    license.Text = GetEmbeddedText("SCHOTT.KL2500LED.Control License - MIT.txt");
                    break;

                case "SCHOTT Core Library":
                    description.Text = @"The SCHOTT Core Library contains many useful functions for interfacing with SCHOTT products. Contains Communications Objects, Data Extensions, State Machine Utilities, Threading Utilities, Etc.";
                    license.Text = GetEmbeddedText("SCHOTT.Core License - MIT.txt");
                    break;

                case "SCHOTT WinForms Library":
                    description.Text = @"The SCHOTT WinForms Library contains many useful functions for interfacing with SCHOTT products in a Windows Forms Application. Contains Docking Objects, Custom Controls, Custom Dialogs, Window Information, Etc.";
                    license.Text = GetEmbeddedText("SCHOTT.WinForms License - MIT.txt");
                    break;

                case "SCHOTT KL2500LED Library":
                    description.Text = @"The SCHOTT KL2500LED Library contains functions used to interface with the SCHOTT KL2500LED. These functions are designed to make it easy for customers to write their own software.";
                    license.Text = GetEmbeddedText("SCHOTT.KL2500LED License - MIT.txt");
                    break;

                case "WeifenLuo Docking Suite":
                    description.Text = @"The docking capabilities of this application were achieved using the WeifenLuo Docking Suite.";
                    license.Text = GetEmbeddedText("WeifenLuo License - MIT.txt");
                    break;

                default:
                    break;
            }

            license.Select(0, 0);
            license.ScrollToCaret();
        }
    }
    
}