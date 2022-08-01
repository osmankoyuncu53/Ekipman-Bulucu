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
   
    public partial class Mouse2 : Form
    {
        public Mouse2()
        {
            InitializeComponent();
        }
        public static string url = "";
        public static string sayfa = "";
        private void Mouse2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet9.Mouse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mouseTableAdapter.Fill(this.myEquipmentDataSet9.Mouse);
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Geri");
            Aciklama.SetToolTip(linkLabel1, "Filtrelemek için üye girişi yapın....");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UyeGirisi uyeGirisi = new UyeGirisi();
            uyeGirisi.Show();
            this.Hide();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            EkipmanUyeOlmayanlarIcın ekipmanUye = new EkipmanUyeOlmayanlarIcın();
            ekipmanUye.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ÜRÜN SEÇİLDİ");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[seçilialan].Cells[6].Value.ToString();
            url = link;
            sayfa = "2";
            Yonlendiriliyorsunuz yon = new Yonlendiriliyorsunuz();
            yon.Show();
        }

        private void Mouse2_FormClosing(object sender, FormClosingEventArgs e)
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
