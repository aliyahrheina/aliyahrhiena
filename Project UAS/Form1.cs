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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStand.Items.Add("S'Crepes");
            comboBoxStand.Items.Add("Eat & Great");
            comboBoxStand.Items.Add("Kakak Adek Bento");
            comboBoxStand.Items.Add("Lima Roemah Sby");
            comboBoxStand.Items.Add("Gado-Gado Surabaya");
        }
    }
}
