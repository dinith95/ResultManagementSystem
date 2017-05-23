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
    // the label on the bottom is given relavant name and 1
    // label which on top is given relavant name and 2
    public partial class frmLecturers : Form
    {
        public frmLecturers()
        {
            InitializeComponent();
           

        }

        private void frmstudents_Load(object sender, EventArgs e)
        {

        }

        private void labelback1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmlogin frm1 = new frmlogin();
            frm1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            //labelProfile2.Visible = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
           // labelProfile2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            //labelResManager2.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            //labelResManager2.Visible = true;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            //labelAnalize2.Visible = false;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //panelProfile.Visible = false;
           // panelResultsManager.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
           // panelProfile.Visible = false;
            //panelResultsManager.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
            //panelResultsManager.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //panelResultsManager.Visible = false;
            //panelProfile.Visible = true;
        }

        private void labelProfile1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void labelProfile2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void labelProfile2_Click(object sender, EventArgs e)
        {
            
        }

        private void labelResultsManager1_MouseEnter(object sender, EventArgs e)
        {
        }    

        private void labelResultsManager2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void labelResultsManager2_Click(object sender, EventArgs e)
        {
           
            
            
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilePanel.BringToFront();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedbackPanel.BringToFront();
        }

        private void addResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResultsPanel.BringToFront();
        }

        private void checkResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsPanel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RatingsPanel.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Feedbacks.BringToFront();
        }
    }
}
