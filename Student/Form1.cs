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
            goldStar5.Visible = true;
            whiteStar5.Visible = false;
        }

        private void whiteStar4_Click(object sender, EventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = true;
            whiteStar5.Visible = false;
            whiteStar4.Visible = false;
        }

        private void whiteStar3_Click(object sender, EventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = true;
            goldStar3.Visible = true;
            whiteStar3.Visible = false;
            whiteStar4.Visible = false;
            whiteStar5.Visible = false;
        }

        private void whiteStar2_Click(object sender, EventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = true;
            goldStar3.Visible = true;
            goldStar2.Visible = true;
            whiteStar2.Visible = false;
            whiteStar3.Visible = false;
            whiteStar4.Visible = false;
            whiteStar5.Visible = false;
        }

        private void whiteStar1_Click(object sender, EventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = true;
            goldStar3.Visible = true;
            goldStar2.Visible = true;
            goldStar1.Visible = true;
            whiteStar1.Visible = false;
            whiteStar2.Visible = false;
            whiteStar3.Visible = false;
            whiteStar4.Visible = false;
            whiteStar5.Visible = false;
        }

        private void goldStar2_MouseClick(object sender, MouseEventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = true;
            goldStar3.Visible = true;
            goldStar2.Visible = true;
            goldStar1.Visible = false;
            whiteStar1.Visible = true;
            whiteStar2.Visible = false;
            whiteStar3.Visible = false;
            whiteStar4.Visible = false;
            whiteStar5.Visible = false;
        }

        private void goldStar3_MouseClick(object sender, MouseEventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = true;
            goldStar3.Visible = true;
            goldStar2.Visible = false;
            goldStar1.Visible = false;
            whiteStar1.Visible = true;
            whiteStar2.Visible = true;
            whiteStar3.Visible = false;
            whiteStar4.Visible = false;
            whiteStar5.Visible = false;
        }

        private void goldStar4_MouseClick(object sender, MouseEventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = true;
            goldStar3.Visible = false;
            goldStar2.Visible = false;
            goldStar1.Visible = false;
            whiteStar1.Visible = true;
            whiteStar2.Visible = true;
            whiteStar3.Visible = true;
            whiteStar4.Visible = false;
            whiteStar5.Visible = false;
        }

        private void goldStar5_MouseClick(object sender, MouseEventArgs e)
        {
            goldStar5.Visible = true;
            goldStar4.Visible = false;
            goldStar3.Visible = false;
            goldStar2.Visible = false;
            goldStar1.Visible = false;
            whiteStar1.Visible = true;
            whiteStar2.Visible = true;
            whiteStar3.Visible = true;
            whiteStar4.Visible = true;
            whiteStar5.Visible = false;
        }
    }
}
