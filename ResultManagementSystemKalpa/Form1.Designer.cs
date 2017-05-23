namespace ResultManagementSystemKalpa
{
    partial class frmlogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.btnsignin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelabout = new System.Windows.Forms.Label();
            this.labelhelp = new System.Windows.Forms.Label();
            this.panelabout = new System.Windows.Forms.Panel();
            this.labeltexthelp = new System.Windows.Forms.Label();
            this.labeltxtabout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelabout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.Transparent;
            this.btnsignin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsignin.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsignin.Location = new System.Drawing.Point(370, 590);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(86, 26);
            this.btnsignin.TabIndex = 0;
            this.btnsignin.Text = "Sign in";
            this.btnsignin.UseVisualStyleBackColor = false;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            this.btnsignin.MouseEnter += new System.EventHandler(this.btnsignin_MouseEnter);
            this.btnsignin.MouseLeave += new System.EventHandler(this.btnsignin_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(333, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 197);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(37, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign me in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox3.Location = new System.Drawing.Point(12, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 17);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Password";
            this.textBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseClick);
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkRed;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(139, 17);
            this.textBox2.TabIndex = 2;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 17);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "User Name";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.CursorChanged += new System.EventHandler(this.textBox1_CursorChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // labellogin
            // 
            this.labellogin.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.labellogin.AutoSize = true;
            this.labellogin.BackColor = System.Drawing.Color.Transparent;
            this.labellogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labellogin.Location = new System.Drawing.Point(8, 131);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(46, 16);
            this.labellogin.TabIndex = 2;
            this.labellogin.Text = "Login";
            this.labellogin.Click += new System.EventHandler(this.label2_Click);
            this.labellogin.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // labelabout
            // 
            this.labelabout.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.labelabout.AutoSize = true;
            this.labelabout.BackColor = System.Drawing.Color.Transparent;
            this.labelabout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelabout.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelabout.Location = new System.Drawing.Point(55, 132);
            this.labelabout.Name = "labelabout";
            this.labelabout.Size = new System.Drawing.Size(101, 16);
            this.labelabout.TabIndex = 3;
            this.labelabout.Text = "About system";
            this.labelabout.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelhelp
            // 
            this.labelhelp.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.labelhelp.AutoSize = true;
            this.labelhelp.BackColor = System.Drawing.Color.Transparent;
            this.labelhelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhelp.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.labelhelp.Location = new System.Drawing.Point(156, 133);
            this.labelhelp.Name = "labelhelp";
            this.labelhelp.Size = new System.Drawing.Size(37, 15);
            this.labelhelp.TabIndex = 4;
            this.labelhelp.Text = "Help";
            this.labelhelp.Click += new System.EventHandler(this.labelhelp_Click);
            // 
            // panelabout
            // 
            this.panelabout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelabout.BackgroundImage")));
            this.panelabout.Controls.Add(this.labeltexthelp);
            this.panelabout.Controls.Add(this.labeltxtabout);
            this.panelabout.Location = new System.Drawing.Point(-2, 156);
            this.panelabout.Name = "panelabout";
            this.panelabout.Size = new System.Drawing.Size(501, 491);
            this.panelabout.TabIndex = 5;
            this.panelabout.Paint += new System.Windows.Forms.PaintEventHandler(this.panelabout_Paint);
            // 
            // labeltexthelp
            // 
            this.labeltexthelp.AutoSize = true;
            this.labeltexthelp.BackColor = System.Drawing.Color.Transparent;
            this.labeltexthelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltexthelp.Location = new System.Drawing.Point(30, 194);
            this.labeltexthelp.Name = "labeltexthelp";
            this.labeltexthelp.Size = new System.Drawing.Size(561, 36);
            this.labeltexthelp.TabIndex = 6;
            this.labeltexthelp.Text = "You Should have User Name and Password For loging this System.\r\nYou can Enter the" +
    "m in login panal.In a about panal You can Know About this System.";
            // 
            // labeltxtabout
            // 
            this.labeltxtabout.AutoSize = true;
            this.labeltxtabout.BackColor = System.Drawing.Color.Transparent;
            this.labeltxtabout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltxtabout.Location = new System.Drawing.Point(59, 194);
            this.labeltxtabout.Name = "labeltxtabout";
            this.labeltxtabout.Size = new System.Drawing.Size(334, 54);
            this.labeltxtabout.TabIndex = 0;
            this.labeltxtabout.Text = "This System devoloped by MIT 2nd year studends\r\nas their coures project.\r\nYou can" +
    " use this System for Analize yor Results.\r\n";
            // 
            // frmlogin
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(507, 649);
            this.Controls.Add(this.panelabout);
            this.Controls.Add(this.labelhelp);
            this.Controls.Add(this.labelabout);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmlogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelabout.ResumeLayout(false);
            this.panelabout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelabout;
        private System.Windows.Forms.Label labelhelp;
        private System.Windows.Forms.Panel panelabout;
        private System.Windows.Forms.Label labeltexthelp;
        private System.Windows.Forms.Label labeltxtabout;
    }
}

