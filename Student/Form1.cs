using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Form1 : Form
    {
        bool x1 = false;
        bool x2 = false;
        bool x3 = false;
        bool x4 = false;
        bool x5 = false;

        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProfilePanel.BringToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilePanel.BringToFront();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsPanel.BringToFront();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedbackPanel.BringToFront();
        }

        private void whiteStar5_Click(object sender, EventArgs e)
        {
            goldStar1.Visible = true;
            whiteStar1.Visible = false;
            x1 = true;
        }

        private void whiteStar4_Click(object sender, EventArgs e)
        {
            goldStar1.Visible = true;
            goldStar2.Visible = true;
            whiteStar1.Visible = false;
            whiteStar2.Visible = false;
            x1 = true;
            x2 = true;
        }

        private void whiteStar3_Click(object sender, EventArgs e)
        {
            goldStar1.Visible = true;
            goldStar2.Visible = true;
            goldStar3.Visible = true;
            whiteStar3.Visible = false;
            whiteStar2.Visible = false;
            whiteStar1.Visible = false;
            x1 = true;
            x2 = true;
            x3 = true;
        }

        private void whiteStar2_Click(object sender, EventArgs e)
        {
            goldStar1.Visible = true;
            goldStar2.Visible = true;
            goldStar3.Visible = true;
            goldStar4.Visible = true;
            whiteStar4.Visible = false;
            whiteStar3.Visible = false;
            whiteStar2.Visible = false;
            whiteStar1.Visible = false;
            x1 = true;
            x2 = true;
            x3 = true;
            x4 = true;
        }

        private void whiteStar1_Click(object sender, EventArgs e)
        {
            goldStar1.Visible = true;
            goldStar2.Visible = true;
            goldStar3.Visible = true;
            goldStar4.Visible = true;
            goldStar5.Visible = true;
            whiteStar5.Visible = false;
            whiteStar4.Visible = false;
            whiteStar3.Visible = false;
            whiteStar2.Visible = false;
            whiteStar1.Visible = false;
            x1 = true;
            x2 = true;
            x3 = true;
            x4 = true;
            x5 = true;
        }

        private void goldStar2_MouseClick(object sender, MouseEventArgs e)
        {
            goldStar1.Visible = true;
            goldStar2.Visible = true;
            goldStar3.Visible = true;
            goldStar4.Visible = true;
            goldStar5.Visible = false;
            whiteStar5.Visible = true;
            whiteStar4.Visible = false;
            whiteStar3.Visible = false;
            whiteStar2.Visible = false;
            whiteStar1.Visible = false;
        }

        private void goldStar3_MouseClick(object sender, MouseEventArgs e)
        {
            goldStar1.Visible = true;
            goldStar2.Visible = true;
            goldStar3.Visible = true;
            goldStar4.Visible = false;
            goldStar5.Visible = false;
            whiteStar5.Visible = true;
            whiteStar4.Visible = true;
            whiteStar3.Visible = false;
            whiteStar2.Visible = false;
            whiteStar1.Visible = false;
        }

        private void goldStar4_MouseClick(object sender, MouseEventArgs e)
        {
            goldStar1.Visible = true;
            goldStar2.Visible = true;
            goldStar3.Visible = false;
            goldStar4.Visible = false;
            goldStar5.Visible = false;
            whiteStar5.Visible = true;
            whiteStar4.Visible = true;
            whiteStar3.Visible = true;
            whiteStar2.Visible = false;
            whiteStar1.Visible = false;
        }

        private void goldStar5_MouseClick(object sender, MouseEventArgs e)
        {            
            goldStar1.Visible = true;
            goldStar2.Visible = false;
            goldStar3.Visible = false;
            goldStar4.Visible = false;
            goldStar5.Visible = false;
            whiteStar5.Visible = true;
            whiteStar4.Visible = true;
            whiteStar3.Visible = true;
            whiteStar2.Visible = true;
            whiteStar1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            goldStar1.Visible = false;
            goldStar2.Visible = false;
            goldStar3.Visible = false;
            goldStar4.Visible = false;
            goldStar5.Visible = false;
            whiteStar5.Visible = true;
            whiteStar4.Visible = true;
            whiteStar3.Visible = true;
            whiteStar2.Visible = true;
            whiteStar1.Visible = true;
        }

        private void analysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void whiteStar5_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void goldStar5_MouseLeave(object sender, EventArgs e)
        {
                        
        }

        private void whiteStar5_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void whiteStar4_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void goldStar4_MouseLeave(object sender, EventArgs e)
        {
            
        }
    }
}
