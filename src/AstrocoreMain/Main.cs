using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AstrocoreMain
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Games"))
            {
                Directory.CreateDirectory("Games");
            }

            Directory.SetCurrentDirectory("Games");
        }

        private void ChoicesPlay_Click(object sender, EventArgs e)
        {
            if (File.Exists("Choices.exe"))
                File.Delete("Choices.exe");

            WebClient wc = new WebClient();
            wc.DownloadFile("https://github.com/AstrocoreGames/Launcher/raw/master/Choices.exe", "Choices.exe");
            wc.Dispose();

            System.Diagnostics.Process.Start("Choices.exe");
        }
    }
}
