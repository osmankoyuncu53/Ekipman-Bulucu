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
    public partial class EkipmanUyeOlmayanlarIcın : Form
    {
        public EkipmanUyeOlmayanlarIcın()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klavye2 klavye2 = new Klavye2();
            klavye2.Show();
            this.Hide();
        }

        private void EkipmanUyeOlmayanlarIcın_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Anasayfa");
            Aciklama.SetToolTip(button2, "Klavye");
            Aciklama.SetToolTip(button3, "Mouse");
            Aciklama.SetToolTip(button4, "Kulaklık");
            Aciklama.SetToolTip(button5, "Mousepad");
            Aciklama.SetToolTip(button6, "Monitör");
            Aciklama.SetToolTip(button7, "Oyuncu Koltuğu");
            Klavye2.sayfano = "";
            Mouse2.sayfa = "";
            Kulaklık2.sayfaa = "";
            Mousepad2.sayfaa4 = "";
            Monitor2.sayfaa5 = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mouse2 mouse2 = new Mouse2();
            mouse2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kulaklık2 kulaklık2 = new Kulaklık2();
            kulaklık2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mousepad2 mousepad2 = new Mousepad2();
            mousepad2.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Monitor2 monitor2 = new Monitor2();
            monitor2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OyuncuKoltugu2 oyuncuKoltugu = new OyuncuKoltugu2();
            oyuncuKoltugu.Show();
            this.Hide();
        }

        private void EkipmanUyeOlmayanlarIcın_FormClosing(object sender, FormClosingEventArgs e)
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
