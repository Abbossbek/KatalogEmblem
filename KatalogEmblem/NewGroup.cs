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
    public partial class NewGroup : Form
    {
        public string GroupName { get; private set; }

        public NewGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupName = txtGroupName.Text;
        }
    }
}
