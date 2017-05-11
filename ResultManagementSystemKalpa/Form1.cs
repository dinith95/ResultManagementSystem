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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            panelabout.Visible = false;
            panel1.Visible = false;
            textBox2.Hide();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "Pass Word";
            //textBox1.Text = "User Name";
            panel1.Visible = true;
            btnsignin.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "k")&&(textBox2.Text=="k"))
            {
                this.Hide();
                frmStudents frm2 = new frmStudents();
                frm2.Show();
            }
            if ((textBox1.Text == "w") && (textBox2.Text == "w"))
            {
                this.Hide();
                frmLecturers frm3 = new frmLecturers();
                frm3.Show();
            }
            if ((textBox1.Text == "") && (textBox2.Text == ""))
            {
                this.Hide();
                frmadmin Frm4 = new frmadmin();
                Frm4.Show();
            }

            }

        private void textBox1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Hide();
            textBox2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            panelabout.Visible = false;
        }

        private void btnsignin_MouseEnter(object sender, EventArgs e)
        {
            btnsignin.BackColor = Color.Red;
        }

        private void btnsignin_MouseLeave(object sender, EventArgs e)
        {
            btnsignin.BackColor = Color.DarkRed;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkRed;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            panelabout.Visible = true;
            labeltexthelp.Visible = false;
            labeltxtabout.Visible = true;
        }

        private void labelhelp_Click(object sender, EventArgs e)
        {
            panelabout.Visible = true;
            labeltexthelp.Visible = true;
            labeltxtabout.Visible = false;
        }

        private void panelabout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
