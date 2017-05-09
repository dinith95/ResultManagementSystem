namespace ResultManagementSystemKalpa
{
    partial class frmLectures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLectures));
            this.labelback1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelback1
            // 
            this.labelback1.AutoSize = true;
            this.labelback1.BackColor = System.Drawing.Color.Transparent;
            this.labelback1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelback1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelback1.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelback1.Location = new System.Drawing.Point(924, 560);
            this.labelback1.Name = "labelback1";
            this.labelback1.Size = new System.Drawing.Size(59, 19);
            this.labelback1.TabIndex = 1;
            this.labelback1.Text = "<<Back";
            this.labelback1.Click += new System.EventHandler(this.labelback1_Click);
            // 
            // frmLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1005, 601);
            this.Controls.Add(this.labelback1);
            this.Name = "frmLectures";
            this.Text = "Lectures";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelback1;
    }
}