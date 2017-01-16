using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * @Author Dallas Tang A00937791
*/
namespace Assignment1
{
    public partial class Add_Editform : Form
    {
        private Boolean edit;
        private String name;
        private String jobtitle;
        private String startdate;
        private Image img;
        
        public Add_Editform()
        {
            InitializeComponent();
        }

        private void Add_Editform_Load(object sender, EventArgs e)
        {
            if (edit)
            {
                nametxt.Text = name;
                jobtitletxt.Text = jobtitle;
                startdatetxt.Text = startdate;
                if (img != null)
                {
                    picture.Image = img;
                }
                else
                {
                    picture.Image = new Bitmap("../../IMG3.jpg");
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.name = nametxt.Text;
            this.jobtitle = jobtitletxt.Text;
            this.startdate = startdatetxt.Text;
            this.img = picture.Image;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void get_Img(object sender, EventArgs e)
        {
            OpenFileDialog filediag = new OpenFileDialog();
            filediag.Multiselect = false;
            if (filediag.ShowDialog()==DialogResult.OK)
            {
                String filename = filediag.FileName;
                picture.Image = new Bitmap(filename);
            }
        }

        public Boolean isEdit
        {
            set
            {
                this.edit = value;
            }
        }
        public String nameTxt
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public String jobtitleTxt
        {
            get
            {
                return this.jobtitle;
            }
            set
            {
                this.jobtitle = value;
            }
        }
        public String startdateTxt
        {
            get
            {
                return this.startdate;
            }
            set
            {
                this.startdate = value;
            }
        }
        public Image emp_img
        {
            get
            {
                return this.img;
            }
            set
            {
                img = value;
            }
        }
    }
}
