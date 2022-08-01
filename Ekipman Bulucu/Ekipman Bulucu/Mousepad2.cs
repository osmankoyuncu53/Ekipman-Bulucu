using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekipman_Bulucu
{
    public partial class Mousepad2 : Form
    {
        public Mousepad2()
        {
            InitializeComponent();
        }
        public static string sayfaa4="";
        public static string url = "";
        private void Mousepad2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet1.Mousepad' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mousepadTableAdapter.Fill(this.myEquipmentDataSet1.Mousepad);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeGirisi uyeGirisi = new UyeGirisi();
            uyeGirisi.Show();
            this.Hide();
        }

   

        private void button1_Click_1(object sender, EventArgs e)
        {
            EkipmanUyeOlmayanlarIcın ekipmanUyeOlmayanlar = new EkipmanUyeOlmayanlarIcın();
            ekipmanUyeOlmayanlar.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ÜRÜN SEÇİLDİ");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            url = link;
            sayfaa4 = "4";
            Yonlendiriliyorsunuz yon = new Yonlendiriliyorsunuz();
            yon.Show();
        }

        private void Mousepad2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan çıkış yapmak istediğinize emin misiniz?", "Program Kapatılıyor....", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {

                Environment.Exit(0);

            }
            else if (x == DialogResult.No)
            {

                e.Cancel = true;
            }
        }
    }
}
