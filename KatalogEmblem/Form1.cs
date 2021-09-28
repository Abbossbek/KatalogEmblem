using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KatalogEmblem
{
    public partial class Form1 : Form
    {
        string KatalogPath = @"c:\Program Files\Katalog Emblems";
        string[] imagePaths;
        public static List<string> Groups = new List<string>();

        public Form1()
        {
            InitializeComponent();

            try
            {
                if (Directory.Exists(KatalogPath))
                {
                    imagePaths = Directory.GetFiles(KatalogPath);
                    List<Image> images = new List<Image>();
                    for (int i = 0; i < imagePaths.Length; i++)
                    {
                        imageList1.Images.Add(imagePaths[i].Remove(0, imagePaths[i].LastIndexOf('\\') + 1), Image.FromFile(imagePaths[i]));
                        lvEmblems.Items.Add(imagePaths[i].Remove(0, imagePaths[i].LastIndexOf('\\') + 1), i);
                    }
                }
                else
                {
                    Directory.CreateDirectory(KatalogPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            for(int i = 0; i < lvEmblems.Groups.Count; i++)
            {
                Groups.Add(lvEmblems.Groups[i].Name);
            }
        }

        private void newEmblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEmblem newEmblem = new NewEmblem();
            newEmblem.ShowDialog();
            if (newEmblem.DialogResult == DialogResult.OK)
            {
                imageList1.Images.Add(newEmblem.PicName, newEmblem.PicEmblem);
                ListViewItem item = new ListViewItem(newEmblem.PicName, imageList1.Images.Count - 1,newEmblem.PicGroup);
                lvEmblems.Items.Add(item);
                File.Copy(newEmblem.PicPath, KatalogPath + "\\" + newEmblem.PicName);
            }
            imagePaths = Directory.GetFiles(KatalogPath);
        }

        private void tsmTxtSearch_TextChanged(object sender, EventArgs e)
        {
            lvEmblems.Clear();
            for (int i = 0; i < imagePaths.Length; i++)
            {
                lvEmblems.Items.Add(imagePaths[i].Remove(0, imagePaths[i].LastIndexOf('\\') + 1), i);
            }
            for (int i = 0; i < lvEmblems.Items.Count; i++)
            {
                if (!lvEmblems.Items[i].Text.Contains(tsmTxtSearch.Text))
                {
                    lvEmblems.Items[i].Remove();
                    i--;
                }
            }
        }

        private void newGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGroup newg = new NewGroup();
            newg.ShowDialog();
            if (newg.DialogResult == DialogResult.OK && newg.GroupName != "")
            {
                lvEmblems.Groups.Add(newg.GroupName,newg.GroupName);
                Groups.Add(newg.GroupName);
            }
        }
    }
}
