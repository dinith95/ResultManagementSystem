using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultManagementSystemKalpa
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ProfilePanel.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void labelback1_Click(object sender, EventArgs e)
        {
           


            this.Hide();
            frmlogin frm1 = new frmlogin();
            frm1.Show();




        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsPanel.BringToFront();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedbackPanel.BringToFront();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportYear1Panel.BringToFront();
        }

        private void whiteStar1_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
        }

        private void whiteStar2_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
        }

        private void whiteStar3_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
        }

        private void whiteStar4_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
            goldStar4.BringToFront();
        }

        private void whiteStar5_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
            goldStar4.BringToFront();
            goldStar5.BringToFront();
        }

        private void goldStar1_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            whiteStar2.BringToFront();
            whiteStar3.BringToFront();
            whiteStar4.BringToFront();
            whiteStar5.BringToFront();
        }

        private void goldStar2_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            whiteStar3.BringToFront();
            whiteStar4.BringToFront();
            whiteStar5.BringToFront();
        }

        private void goldStar3_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
            whiteStar4.BringToFront();
            whiteStar5.BringToFront();
        }

        private void goldStar4_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
            goldStar4.BringToFront();
            whiteStar5.BringToFront();
        }

        private void goldStar5_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
            goldStar4.BringToFront();
            whiteStar5.BringToFront();
        }

        private void whiteStar1_MouseEnter(object sender, EventArgs e)
        {
            goldFAke1.BringToFront();
        }

        private void whiteStar2_MouseClick(object sender, MouseEventArgs e)
        {
            goldFAke1.BringToFront();
            goldFake2.BringToFront();
        }

        private void whiteStar3_MouseEnter(object sender, EventArgs e)
        {
            goldFAke1.BringToFront();
            goldFake2.BringToFront();
            goldFake3.BringToFront();
        }

        private void whiteStar4_MouseEnter(object sender, EventArgs e)
        {
            goldFAke1.BringToFront();
            goldFake2.BringToFront();
            goldFake3.BringToFront();
            goldFake4.BringToFront();
        }

        private void whiteStar5_MouseEnter(object sender, EventArgs e)
        {
            goldFAke1.BringToFront();
            goldFake2.BringToFront();
            goldFake3.BringToFront();
            goldFake4.BringToFront();
            goldFake5.BringToFront();
        }

        private void goldFAke1_MouseLeave(object sender, EventArgs e)
        {
            goldFake2.SendToBack();
        }

        private void goldFake2_MouseLeave(object sender, EventArgs e)
        {
            goldFake2.SendToBack();
            goldFAke1.SendToBack();
        }

        private void goldFake3_MouseLeave(object sender, EventArgs e)
        {
            goldFake2.SendToBack();
            goldFAke1.SendToBack();
            goldFake3.SendToBack();
        }

        private void goldFake4_MouseLeave(object sender, EventArgs e)
        {
            goldFake2.SendToBack();
            goldFAke1.SendToBack();
            goldFake3.SendToBack();
            goldFake4.SendToBack();
        }

        private void goldFake5_MouseLeave(object sender, EventArgs e)
        {
            goldFake2.SendToBack();
            goldFAke1.SendToBack();
            goldFake3.SendToBack();
            goldFake4.SendToBack();
            goldFake5.SendToBack();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            whiteStar1.BringToFront();
            whiteStar2.BringToFront();
            whiteStar3.BringToFront();
            whiteStar4.BringToFront();
            whiteStar5.BringToFront();
        }

        private void goldFAke1_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
        }

        private void goldFake2_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
        }

        private void goldFake3_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
        }

        private void goldFake4_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
            goldStar4.BringToFront();
        }

        private void goldFake5_Click(object sender, EventArgs e)
        {
            goldStar1.BringToFront();
            goldStar2.BringToFront();
            goldStar3.BringToFront();
            goldStar4.BringToFront();
            goldStar5.BringToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
