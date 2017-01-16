using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
/*
* @Author Dallas Tang A00937791
*/
namespace Assignment1
{
    public partial class StaffListView : Form
    {
        private DataTable table;
        private OdbcConnection conn;
        public StaffListView()
        {
            InitializeComponent();
            // Set the view to show details.
            stafflstView.View = View.Details;
            // Allow the user to edit item text.
            stafflstView.LabelEdit = false;
            // Allow the user to rearrange columns.
            stafflstView.AllowColumnReorder = true;
            // Select the item and subitems when selection is made.
            stafflstView.FullRowSelect = true;
            // Display grid lines.
            stafflstView.GridLines = true;
        }
        private void StaffListView_Load(object sender, EventArgs e)
        {
            conn = new OdbcConnection("Driver={Microsoft Access Driver (*.mdb, *.accdb)};Dbq=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Database.accdb"));
            update_lstview();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add_Editform add_edit = new Add_Editform();
            add_edit.isEdit = false;
            add_edit.ShowDialog();
            if (add_edit.DialogResult == DialogResult.OK)
            {
                String query = "INSERT INTO Employees(Emp_name,Jobtitle,Startdate,Picblob) VALUES(?,?,?,?);";
                conn.Open();
                OdbcTransaction dbtrans = conn.BeginTransaction();
                OdbcCommand dbcmd = new OdbcCommand(query,conn,dbtrans);
                //add parameters
                dbcmd.Parameters.Add("Emp_name", OdbcType.VarChar).Value = add_edit.nameTxt;
                dbcmd.Parameters.Add("Jobtitle", OdbcType.VarChar).Value = add_edit.jobtitleTxt;
                dbcmd.Parameters.Add("Startdate", OdbcType.VarChar).Value = add_edit.startdateTxt;
                dbcmd.Parameters.Add("Picblob", OdbcType.VarBinary).Value = ImgtoByte(add_edit.emp_img);
                dbcmd.ExecuteNonQuery();
                dbtrans.Commit();
                conn.Close();
            }
            add_edit.Dispose();
            update_lstview();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (stafflstView.SelectedItems.Count == 1)
            {
                Add_Editform add_edit = new Add_Editform();
                int index = stafflstView.SelectedItems[0].Index;
                add_edit.isEdit = true;
                add_edit.emp_img = stafflstView.SmallImageList.Images[index];
                add_edit.nameTxt = stafflstView.SelectedItems[0].SubItems[2].Text;
                add_edit.jobtitleTxt = stafflstView.SelectedItems[0].SubItems[3].Text;
                add_edit.startdateTxt = stafflstView.SelectedItems[0].SubItems[4].Text;
                add_edit.ShowDialog();
                if (add_edit.DialogResult == DialogResult.OK)
                {
                    //get returned data
                    String id = stafflstView.SelectedItems[0].SubItems[1].Text;
                    String name = add_edit.nameTxt;
                    String jobtitle = add_edit.jobtitleTxt;
                    String startdate = add_edit.startdateTxt;
                    Image img = add_edit.emp_img;

                    String query = "UPDATE Employees SET Emp_name=?, Jobtitle=?, Startdate=?, Picblob=? WHERE ID=?;";
                    conn.Open();
                    Console.Write(id + " " + name + " " + jobtitle);
                    //do transaction
                    OdbcTransaction dbtrans = conn.BeginTransaction();
                    OdbcCommand dbcmd = new OdbcCommand(query, conn, dbtrans);
                    dbcmd.Parameters.Add("Emp_name", OdbcType.VarChar).Value = name;
                    dbcmd.Parameters.Add("Jobtitle", OdbcType.VarChar).Value = jobtitle;
                    dbcmd.Parameters.Add("Startdate", OdbcType.VarChar).Value = startdate;
                    dbcmd.Parameters.Add("Picblob", OdbcType.VarBinary).Value = ImgtoByte(img);
                    dbcmd.Parameters.Add("ID", OdbcType.Int).Value = Convert.ToInt32(id);
                    dbcmd.ExecuteNonQuery();
                    dbtrans.Commit();
                    conn.Close();
                    add_edit.Dispose();
                    update_lstview();
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (stafflstView.SelectedItems.Count == 1)
            {
                int index = stafflstView.SelectedItems[0].Index;
                String id = stafflstView.SelectedItems[0].SubItems[1].Text;
                String query = "DELETE FROM Employees WHERE ID=?";
                conn.Open();
                OdbcTransaction dbtrans = conn.BeginTransaction();
                OdbcCommand dbcmd = new OdbcCommand(query,conn,dbtrans);
                dbcmd.Parameters.Add("ID", OdbcType.Int).Value = Int32.Parse(id);
                dbcmd.ExecuteNonQuery();
                dbtrans.Commit();
                conn.Close();
                update_lstview();
            }
        }

        private byte[] ImgtoByte(Image img)
        {
            if (img == null)
            {
                return null;
            }
            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void update_lstview()
        {
            conn.Open();
            stafflstView.Items.Clear();
            table = new DataTable();
            string query = "SELECT * FROM Employees";
            OdbcCommand dbcmd = new OdbcCommand(query, conn);
            dbcmd.CommandType = CommandType.Text;
            OdbcDataAdapter adapt = new OdbcDataAdapter(dbcmd);
            adapt.Fill(table);
            //add images to image list
            ImageList imglst = new ImageList();
            imglst.ImageSize = new Size(75, 75);
            stafflstView.SmallImageList = imglst;//bind image list to listview
            //read database
            int i = 0;
            foreach (DataRow dr in table.Rows)
            {
                Image tmp_img = (Bitmap)((new ImageConverter()).ConvertFrom(dr["Picblob"]));//read img from db
                imglst.Images.Add(tmp_img);//add img to imglst
                //build listViewItem
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;//set image index
                item.SubItems.Add(dr["ID"].ToString());
                item.SubItems.Add(dr["Emp_name"].ToString());
                item.SubItems.Add(dr["Jobtitle"].ToString());
                item.SubItems.Add(dr["Startdate"].ToString());
                stafflstView.Items.Add(item);
                i++;
            }
            conn.Close();
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
