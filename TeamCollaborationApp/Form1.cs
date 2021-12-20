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
            // 
            pictureBox1.Top = ((Control)sender).Top;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

           pictureBox1.Top = ((Control)sender).Top;
        }
      
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = ((Control)sender).Top;
        }
    }
}
