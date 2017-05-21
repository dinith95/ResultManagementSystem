﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecturer
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
            this.Text = "Dr. Chathura Rajapaksa";
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilePanel.BringToFront();
            RatingsPanel.BringToFront();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsPanel.BringToFront();
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeedbackPanel.BringToFront();
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
