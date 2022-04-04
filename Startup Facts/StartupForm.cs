using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using IWshRuntimeLibrary;

namespace Startup_Facts
{
    public partial class StartupForm : Form
    {
        public Dictionary<string, string> stuff = null;
        public StartupForm()
        {
            InitializeComponent();
            if (Startup_Facts.Settings.Default.FirstRun == true)
            {
                Settings.Default.FirstRun = false;
                Settings.Default.Save();
                WshShell wshShell = new WshShell();
                IWshRuntimeLibrary.IWshShortcut shortcut;
                string startUpFolderPath =
                  Environment.GetFolderPath(Environment.SpecialFolder.Startup);

                // Create the shortcut
                shortcut =
                  (IWshRuntimeLibrary.IWshShortcut)wshShell.CreateShortcut(
                    startUpFolderPath + "\\" +
                    Application.ProductName + ".lnk");

                shortcut.TargetPath = Application.ExecutablePath;
                shortcut.WorkingDirectory = Application.StartupPath;
                shortcut.Description = "Display facts on startup";
                // shortcut.IconLocation = Application.StartupPath + @"\App.ico";
                shortcut.Save();
                Settings.Default.FirstRun = false;
            }
            Main();
        }
        // make a function that runs on the first run of the program
        public void Main()
        {
            bool IsEnglish = false;
            while (!IsEnglish)
            {
                stuff = GetStuff();
                if (stuff["language"] != "en") continue;
                IsEnglish = true;
            }
            text.Text = stuff["text"];
            relocatelabel(text);
        }
        public Dictionary<string, string> GetStuff()
        {
            var client = new RestClient("https://uselessfacts.jsph.pl/");
            var request = new RestRequest("random.json", Method.GET);
            IRestResponse response = client.Execute(request);
            var stuff = JsonConvert.DeserializeObject<Dictionary<string, string>>(response.Content);
            return stuff;
        }
        public void relocatelabel(Label l)
        {
            int x = (this.Width / 2) - (l.Width / 2);
            l.Location = new Point((int)x, l.Location.Y);
        }

        private void Sauce_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = stuff["source_url"];
            System.Diagnostics.Process.Start(psi);
        }

        private void AnotherFactButton_Click(object sender, EventArgs e)
        {
            Main();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
