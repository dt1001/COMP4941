namespace Assignment1
{
    partial class Add_Editform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Editform));
            this.ok_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.jobtitlelbl = new System.Windows.Forms.Label();
            this.startdatelbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.jobtitletxt = new System.Windows.Forms.TextBox();
            this.startdatetxt = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(56, 299);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(75, 23);
            this.ok_btn.TabIndex = 0;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(167, 299);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 1;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(53, 133);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(35, 13);
            this.namelbl.TabIndex = 2;
            this.namelbl.Text = "Name";
            // 
            // jobtitlelbl
            // 
            this.jobtitlelbl.AutoSize = true;
            this.jobtitlelbl.Location = new System.Drawing.Point(53, 197);
            this.jobtitlelbl.Name = "jobtitlelbl";
            this.jobtitlelbl.Size = new System.Drawing.Size(47, 13);
            this.jobtitlelbl.TabIndex = 3;
            this.jobtitlelbl.Text = "Job Title";
            // 
            // startdatelbl
            // 
            this.startdatelbl.AutoSize = true;
            this.startdatelbl.Location = new System.Drawing.Point(53, 254);
            this.startdatelbl.Name = "startdatelbl";
            this.startdatelbl.Size = new System.Drawing.Size(55, 13);
            this.startdatelbl.TabIndex = 4;
            this.startdatelbl.Text = "Start Date";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(142, 130);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(100, 20);
            this.nametxt.TabIndex = 5;
            // 
            // jobtitletxt
            // 
            this.jobtitletxt.Location = new System.Drawing.Point(142, 194);
            this.jobtitletxt.Name = "jobtitletxt";
            this.jobtitletxt.Size = new System.Drawing.Size(100, 20);
            this.jobtitletxt.TabIndex = 6;
            // 
            // startdatetxt
            // 
            this.startdatetxt.Location = new System.Drawing.Point(142, 251);
            this.startdatetxt.Name = "startdatetxt";
            this.startdatetxt.Size = new System.Drawing.Size(100, 20);
            this.startdatetxt.TabIndex = 7;
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(56, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(186, 112);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.get_Img);
            // 
            // Add_Editform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 341);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.startdatetxt);
            this.Controls.Add(this.jobtitletxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.startdatelbl);
            this.Controls.Add(this.jobtitlelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.ok_btn);
            this.Name = "Add_Editform";
            this.Text = "Add/Edit";
            this.Load += new System.EventHandler(this.Add_Editform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label jobtitlelbl;
        private System.Windows.Forms.Label startdatelbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox jobtitletxt;
        private System.Windows.Forms.TextBox startdatetxt;
        private System.Windows.Forms.PictureBox picture;
    }
}