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
    public partial class frmstudents : Form
    {
        public frmstudents()
        {
            InitializeComponent();
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            panel1.Visible = true;
            panel3.Visible = false;
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
            label5.Visible = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
            panel3.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
        }
    }
}
