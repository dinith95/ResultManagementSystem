using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ResultManagementSystemKalpa
{
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
            
            labelstaff2.Visible = false;
            labelstudents2.Visible = false;
            labelcourses2.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            pictureBox2.Visible = false;
            panel6.Visible = false;

        }

        private void labelstaff1_MouseEnter(object sender, EventArgs e)
        {
            labelstaff1.Visible = false;
            labelstaff2.Visible = true;
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void labelstaff1_MouseLeave(object sender, EventArgs e)
        {
            

        }

        private void labelstaff2_MouseLeave(object sender, EventArgs e)
        {
           // labelstaff2.Visible = false;
          ///labelstaff1.Visible = true;
          
        }

        private void labelstudents1_MouseEnter(object sender, EventArgs e)
        {
            labelstudents1.Visible = false;
            labelstudents2.Visible = true;
            panel1.Visible = false;
        }

        private void labelstudents2_MouseLeave(object sender, EventArgs e)
        {
            labelstudents1.Visible = true;
           
            labelstaff1.Visible = true;
            labelstaff2.Visible = false;
           

        }

        private void labelcourses1_MouseEnter(object sender, EventArgs e)
        {
            labelcourses1.Visible = false;
            labelcourses2.Visible = true;
            
        }

        private void labelcourses2_MouseLeave(object sender, EventArgs e)
        {
           // labelcourses2.Visible = false;
           // labelcourses1.Visible = true;
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            labelstaff1.Visible = false;
            panel1.Visible = true;
            labelstaff2.Visible = true;
           
        }

        private void frmadmin_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
            labelstaff1.Visible = true;
            labelstaff2.Visible = false;
            labelcourses1.Visible = true;
            labelcourses2.Visible = false;
            panel2.Visible = false;
            labelstudents1.Visible = true;
            labelstudents2.Visible = false;
            panel3.Visible = false;

        }

        private void frmadmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
           // label1.BackColor = Color.DarkRed;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
           label1.BackColor = Color.AntiqueWhite;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Gainsboro;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            labeladdprofilepic.Text = "Add Profile Picture";
            btndelete.Visible = false;
            panel4.Visible = true;
            btncler.Visible = true;
            btnsubmit.Visible = true;
            panel6.Visible = false;

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            labelupdatenewstaff.BackColor = Color.AntiqueWhite;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.BackColor = Color.AntiqueWhite;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            labelupdatenewstaff.BackColor = Color.Gainsboro;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.BackColor = Color.Gainsboro;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelstudents2_MouseEnter(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void label2_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            labelAddMember.BackColor = Color.AntiqueWhite;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            labelUpdateInformation.BackColor = Color.AntiqueWhite;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            labelDeleteRecords.BackColor = Color.AntiqueWhite;
        }

        private void label2_DragLeave(object sender, EventArgs e)
        {

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            labelAddMember.BackColor = Color.Gainsboro;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            labelUpdateInformation.BackColor = Color.Gainsboro;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            labelDeleteRecords.BackColor = Color.Gainsboro;
        }

        private void labelstaff2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            labelstudents1.Visible = false;
            panel2.Visible = true;
            labelstudents2.Visible = true;
           
        }

        private void label7_DragEnter(object sender, DragEventArgs e)
        {
            //label7.BackColor = Color.AntiqueWhite;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.BackColor = Color.AntiqueWhite;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.BackColor = Color.AntiqueWhite;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.BackColor = Color.AntiqueWhite;
           
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.BackColor = Color.Gainsboro;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.BackColor = Color.Gainsboro;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //label9.BackColor = Color.Gainsboro;
       }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelcourses2_MouseEnter(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.BackColor = Color.Gainsboro;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void imagestaff_Click(object sender, EventArgs e)
        {

        }

        private void labeladdprofilepic_DragEnter(object sender, DragEventArgs e)
        {
            labeladdprofilepic.ForeColor=Color.Blue;
        }

        private void labeladdprofilepic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(open.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void labeladdprofilepic_MouseEnter(object sender, EventArgs e)
        {
            labeladdprofilepic.ForeColor = Color.Blue;
            labeladdprofilepic.Font = new Font(labeladdprofilepic.Font.Name, 9, FontStyle.Underline);

        }

        private void labeladdprofilepic_MouseLeave(object sender, EventArgs e)
        {
            labeladdprofilepic.ForeColor = Color.Black;
            labeladdprofilepic.Font = new Font(labeladdprofilepic.Font.Name, 9, FontStyle.Regular);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {

        }

        private void labelupdatenewstaff_Click(object sender, EventArgs e)
        {
            labeladdprofilepic.Text = "Add New Profile Picture";
            panel4.Visible = true;
            btndelete.Visible = false;
            panel6.Visible = false;
            btnsubmit.Text = "Update";
            btncler.Visible = true;
            btnsubmit.Visible = true;
        }
       
        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
            labelstaff1.Visible = true;
            labelstaff2.Visible = false;
            labelcourses1.Visible = true;
            labelcourses2.Visible = false;
            panel2.Visible = false;
            labelstudents1.Visible = true;
            labelstudents2.Visible = false;
            panel3.Visible = false;
        }

        private void texsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            labeladdprofilepic.Visible= false;
            panel4.Visible = true;
            btnsubmit.Visible = false;
            panel6.Visible = false;
            btndelete.Visible = true;
            btncler.Visible = false;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            btnupdate.Visible = false;
            buttondelete.Visible = false;
            btnadd.Visible = true;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttondelete_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            buttondelete.Visible = false;
            btnadd.Visible = false;
            btnupdate.Visible=true;

        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            panel6.Visible = true;
            buttondelete.Visible = true;
            btnadd.Visible = false;
            btnupdate.Visible = false;
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel1.Visible = false;
            labelstaff1.Visible = true;
            labelstaff2.Visible = false;
            labelcourses1.Visible = true;
            labelcourses2.Visible = false;
            panel2.Visible = false;
            labelstudents1.Visible = true;
            labelstudents2.Visible = false;
            panel3.Visible = false;
        }
    }
}
