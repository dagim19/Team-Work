using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamCollaborationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(panel2);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
  
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Getting Started");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Setting");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

           indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Getting Started");
        }
      
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Project");
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            BunifuPage.SetPage("Journal");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
