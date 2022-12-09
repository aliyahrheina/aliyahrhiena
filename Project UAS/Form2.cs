using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_UAS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonTidak_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonYA_Click(object sender, EventArgs e)
        {
            Form3 f4 = new Form3();
            this.Hide();
            f4.ShowDialog();
        }
    }
}
