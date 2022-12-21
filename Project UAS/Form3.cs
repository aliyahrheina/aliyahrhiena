using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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
        List<int> listOfPilih = new List<int>();
        private int TotalHarga(List<int> Harga)
        {
            int total = 0;
            for (int i = 0; i < Harga.Count(); i++)
            {
                total += Harga[i];
            }
            return total;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBoxStand.Items.Add("Eat and Great");
            comboBoxStand.Items.Add("S'Crepes");
            comboBoxStand.Items.Add("Kakak Adek Bento");
            comboBoxStand.Items.Add("Lima Reomah Sby");
            comboBoxStand.Items.Add("Gado Gado Surabaya");

            arrMenu = new string[5,5];
            arrMenu[0, 0] = "Crofle";
            arrMenu[0, 1] = "Kebab";
            arrMenu[0, 2] = "Sosis Bakar & Seafood";
            arrMenu[0, 3] = "Toast";

            arrMenu[1, 0] = "Banana Choco Chips";
            arrMenu[1, 1] = "Tiramisu ";
            arrMenu[1, 2] = "Strawbery Special";
            arrMenu[1, 3] = "Fruit Coctail";
            arrMenu[1, 4] = "Tuna Pizza";

            arrMenu[2, 0] = "Bento 1 : Mix Bento";
            arrMenu[2, 1] = "Bento 2 : Katsu Bento";
            arrMenu[2, 2] = "Bento 3 : Teriyaki Bento";
            arrMenu[2, 3] = "Bento 4 : Crazy Mix";
            arrMenu[2, 4] = "Bento 5 : Blackpepper Bento";

            arrMenu[3, 0] = "Ayam Gr Rempah";
            arrMenu[3, 1] = "Bakwan Goreng";
            arrMenu[3, 2] = "Bandeng Presto Goreng";
            arrMenu[3, 3] = "Ayam Goreng Kremes";

            arrMenu[4, 0] = "Gado Gado";
            arrMenu[4, 1] = "Lontong Kare";
            arrMenu[4, 2] = "Lontong Pecel";
            arrMenu[4, 3] = "Lontong Sayur";

            arrHarga = new int[5][];
            arrHarga[0] = new int[] { 10000, 10000, 10000, 16000 };
            arrHarga[1] = new int[] { 7000, 7000, 8000, 8000, 9000 };
            arrHarga[2] = new int[] { 16000, 16000, 16000, 16000, 16000 };
            arrHarga[3] = new int[] { 17000, 17000, 17000, 17000 };
            arrHarga[4] = new int[] { 15000, 15000, 15000, 15000 };
        }

        private void buttonPilih_Click(object sender, EventArgs e)
        {
            comboBoxMenu.Items.Clear();
            if (comboBoxStand.SelectedItem=="Eat and Great")
            {
                for (int menu = 0; menu <= 3; menu++)
                {
                    comboBoxMenu.Items.Add(arrMenu[0, menu]);
                }
            }
            else if(comboBoxStand.SelectedItem=="S'Crepes")
            {
                for (int menu = 0; menu <= 4; menu++)
                {
                    comboBoxMenu.Items.Add(arrMenu[1, menu]);
                }
            }
            else if (comboBoxStand.SelectedItem == "Kakak Adek Bento")
            {
                for (int menu = 0; menu <= 4; menu++)
                {
                    comboBoxMenu.Items.Add(arrMenu[2, menu]);
                }
            }
            else if (comboBoxStand.SelectedItem == "Lima Reomah Sby")
            {
                for (int menu = 0; menu <= 3; menu++)
                {
                    comboBoxMenu.Items.Add(arrMenu[3, menu]);
                }
            }
            else
            {
                for (int menu = 0; menu <= 3; menu++)
                {
                    comboBoxMenu.Items.Add(arrMenu[4, menu]);
                }
            }
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //labelHarga.Text = (arrHarga[comboBoxStand.SelectedIndex][comboBoxMenu.SelectedIndex]).ToString("C0", new CultureInfo("id"));
            labelHarga.Text = "Rp. " + arrHarga[comboBoxStand.SelectedIndex][comboBoxMenu.SelectedIndex];
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Add(comboBoxMenu.SelectedItem + " " + labelHarga.Text );
            string Label = labelHarga.Text;
            string[] no = Label.Split(' ');

            listOfPilih.Add(int.Parse(no[1]));

        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            int Total = TotalHarga(listOfPilih);
            listBoxInfo.Items.Add("Total pesanan anda Rp." + Total.ToString());

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxInfo.Items.Clear();
            listOfPilih.Clear();
        }
    }
}
