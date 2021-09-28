using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatalogEmblem
{
    public partial class NewEmblem : Form
    {
        public Image PicEmblem { get; private set; }
        public string PicName { get; private set; }
        public string PicPath { get; private set; }
        public ListViewGroup PicGroup { get; private set; }

        public NewEmblem()
        {
            InitializeComponent();
            for(int i=0;i<Form1.Groups.Count;i++)
            {
                cmbGroups.Items.Add(Form1.Groups[i]);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Pictures|*.jpg;*.png;*.ico;*.bmp";
            openFileDialog1.FileName = "Unknown";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName!="Unknown")
            {
                picEmblem.Image = Image.FromFile(openFileDialog1.FileName);
                txtName.Text = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\')+1);
                PicPath = openFileDialog1.FileName;
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PicEmblem = picEmblem.Image;
            PicName = txtName.Text;
            PicGroup = new ListViewGroup(cmbGroups.Text);
        }
    }
}
