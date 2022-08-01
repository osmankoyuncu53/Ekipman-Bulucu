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
    public partial class Monitor2 : Form
    {
        public Monitor2()
        {
            InitializeComponent();
        }

        private void Monitor2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet5.Monitor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.monitorTableAdapter.Fill(this.myEquipmentDataSet5.Monitor);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkipmanUyeOlmayanlarIcın ekipmann = new EkipmanUyeOlmayanlarIcın();
            ekipmann.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeGirisi uye = new UyeGirisi();
            uye.Show();
            this.Hide();
        }
        public static string url = "";
        public static string sayfaa5 = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("ÜRÜN SEÇİLDİ");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();
            url = link;
            sayfaa5 = "5";
            Yonlendiriliyorsunuz yon = new Yonlendiriliyorsunuz();
            yon.Show();
        }

        private void Monitor2_FormClosing(object sender, FormClosingEventArgs e)
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
