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
            labelProfile2.Visible = false;
            labelResManager2.Visible = false;
            labelAnalize2.Visible = false;
            panelProfile.Visible = true;
           
            panelResultsManager.Visible = false;
            panelAnalizeFeedback.Visible = false;
           

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
            ///labelAnalize2.Visible = true;
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
            labelProfile2.Visible = true;
        }

        private void labelProfile2_MouseLeave(object sender, EventArgs e)
        {
            labelProfile2.Visible = false; 
        }

        private void labelProfile2_Click(object sender, EventArgs e)
        {
            panelProfile.Show();
            panelResultsManager.Hide();
            panelAnalizeFeedback.Hide() ;
        }

        private void labelResultsManager1_MouseEnter(object sender, EventArgs e)
        {
            labelResManager2.Visible = true;
        }

        private void labelResultsManager2_MouseLeave(object sender, EventArgs e)
        {
            labelResManager2.Visible = false; 
        }

        private void labelResultsManager2_Click(object sender, EventArgs e)
        {
           
             panelResultsManager.Show();
            panelAnalizeFeedback.Hide();
             panelProfile.Hide();
            
        }
    }
}
