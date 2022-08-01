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
    public partial class Klavye2 : Form
    {
        public Klavye2()
        {
            InitializeComponent();
        }
        public static string url = "";
        public static string sayfano = "";
        private void Klavye2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet2.Klavye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.klavyeTableAdapter.Fill(this.myEquipmentDataSet2.Klavye);
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Geri");
            Aciklama.SetToolTip(linkLabel1, "Filtrelemek için üye girişi yapın....");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkipmanUyeOlmayanlarIcın ekipman = new EkipmanUyeOlmayanlarIcın();
            ekipman.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeGirisi uyeGirisi = new UyeGirisi();
            uyeGirisi.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ÜRÜN SEÇİLDİ");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            url = link;
            sayfano = "1";
            Yonlendiriliyorsunuz yon = new Yonlendiriliyorsunuz();
            yon.Show();
        }

        private void Klavye2_FormClosing(object sender, FormClosingEventArgs e)
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
