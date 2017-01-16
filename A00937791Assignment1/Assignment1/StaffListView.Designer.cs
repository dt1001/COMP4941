namespace Assignment1
{
    partial class StaffListView
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
            this.stafflstView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.jobtitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.picture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // stafflstView
            // 
            this.stafflstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.picture,
            this.id,
            this.name,
            this.jobtitle,
            this.startdate});
            this.stafflstView.Location = new System.Drawing.Point(12, 12);
            this.stafflstView.Name = "stafflstView";
            this.stafflstView.Size = new System.Drawing.Size(424, 182);
            this.stafflstView.TabIndex = 0;
            this.stafflstView.UseCompatibleStateImageBehavior = false;
            this.stafflstView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 71;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 88;
            // 
            // jobtitle
            // 
            this.jobtitle.Text = "Job Title";
            this.jobtitle.Width = 86;
            // 
            // startdate
            // 
            this.startdate.Text = "Start Date";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 227);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(180, 227);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 2;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(361, 227);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // picture
            // 
            this.picture.Text = "Picture";
            this.picture.Width = 109;
            // 
            // StaffListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.stafflstView);
            this.Name = "StaffListView";
            this.Text = "StaffListView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_close);
            this.Load += new System.EventHandler(this.StaffListView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader jobtitle;
        private System.Windows.Forms.ColumnHeader startdate;
        public System.Windows.Forms.ListView stafflstView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader picture;
    }
}