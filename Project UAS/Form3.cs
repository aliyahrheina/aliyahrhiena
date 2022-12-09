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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string[,] arrMenu;
        int[][] arrHarga;
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxStand.Text=("Eat and Great");
            comboBoxStand.Text = ("S'Crepes");
            comboBoxStand.Text = ("Kakak Adek Bento");
            comboBoxStand.Text = ("Lima Reomah Sby");
            comboBoxStand.Text = ("Gado Gado Surabaya");

            arrMenu = new string[5,5];
            arrMenu[1, 1] = "Crofle";
            arrMenu[1, 2] = "Kebab";
            arrMenu[1, 3] = "Sosis Bakar & Seafood";
            arrMenu[1, 4] = "Toast";
            arrMenu[2, 1] = "Banana Choco Chips";
            arrMenu[2, 2] = "Tiramisu ";
            arrMenu[2, 3] = "Strawbery Special";
            arrMenu[2, 4] = "Fruit Coctail";
            arrMenu[2, 5] = "Tuna Pizza";
            arrMenu[3, 1] = "Bento 1 : Mix Bento";
            arrMenu[3, 2] = "Bento 2 : Katsu Bento";
            arrMenu[3, 3] = "Bento 3 : Teriyaki Bento";
            arrMenu[3, 4] = "Bento 4 : Crazy Mix";
            arrMenu[3, 5] = "Bento 5 : Blackpepper Bento";
            arrMenu[4, 1] = "Ayam Gr Rempah";
            arrMenu[4, 2] = "Bakwan Goreng";
            arrMenu[4, 3] = "Bandeng Presto Goreng";
            arrMenu[4, 4] = "Ayam Goreng Kremes";
            arrMenu[5, 1] = "Gado Gado";
            arrMenu[5, 2] = "Lontong Kare";
            arrMenu[5, 3] = "Lontong Pecel";
            arrMenu[5, 4] = "Lontong Sayur";

            arrHarga = new int[5][];
            arrHarga[1] = new int[] { 10000, 10000, 10000, 16000 };
            arrHarga[2] = new int[] { 7000, 7000, 8000, 8000, 9000 };
            arrHarga[3] = new int[] { 16000, 16000, 16000, 16000, 16000 };
            arrHarga[4] = new int[] { 17000, 17000, 17000, 17000 };
            arrHarga[5] = new int[] { 15000, 15000, 15000, 15000 };
        }

        private void btnPilinMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonPilih_Click(object sender, EventArgs e)
        {

        }
    }
}
