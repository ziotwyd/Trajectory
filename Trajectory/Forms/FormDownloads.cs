using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trajectory
{
    public partial class FormDownloads : Form
    {
        public FormDownloads()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cdn.fnbuilds.services/9.10.rar");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
