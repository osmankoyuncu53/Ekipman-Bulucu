using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ekipman_Bulucu
{
    public partial class Ekipman : Form
    {
        public Ekipman()
        {
            InitializeComponent();
        }

        private void Ekipman_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            UyeGirisi uyeGirisi = new UyeGirisi();
            uyeGirisi.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kulaklık kulaklık = new Kulaklık();
            kulaklık.Show();
            this.Hide();
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            Mouse mouse = new Mouse();
            mouse.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mousepad mousepad = new Mousepad();
            mousepad.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Monitör monitör = new Monitör();
            monitör.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OyuncuKoltuguu oyuncuKoltuğu = new OyuncuKoltuguu();
            oyuncuKoltuğu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klavye klavye = new Klavye();
            klavye.Show();
            this.Hide();
        }



        private void Ekipman_Load(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            button2.Cursor = Cursors.Hand;
            button3.Cursor = Cursors.Hand;
            button4.Cursor = Cursors.Hand;
            button5.Cursor = Cursors.Hand;
            button6.Cursor = Cursors.Hand;
            button7.Cursor = Cursors.Hand;
            button8.Cursor = Cursors.Hand;
            label1.Cursor = Cursors.Arrow;
            label10.Cursor = Cursors.Arrow;
            Ekipman ekipman = new Ekipman();
            ekipman.Cursor = Cursors.Arrow;
            Klavye.sayfano = "";
            Mouse.sayfa = "";
            Kulaklık.sayfaa = "";
            Mousepad.sayfaa4 = "";
            Monitör.sayfaa5 = "";
            OyuncuKoltuguu.sayfaa6 = "";
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button2, "Klavye");
            Aciklama.SetToolTip(button3, "Mouse");
            Aciklama.SetToolTip(button4, "Kulaklık");
            Aciklama.SetToolTip(button5, "Mousepad");
            Aciklama.SetToolTip(button6, "Monitör");
            Aciklama.SetToolTip(button7, "Oyuncu Koltuğu");
            Aciklama.SetToolTip(button1, "Oturumu Kapat");
            Aciklama.SetToolTip(button8, "Profil");
            string kadi = UyeGirisi.k;
            string sifre = UyeGirisi.s;
            string adi;
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from Kullanici_giris where kullanici_adi='" + kadi + "'    and kullanici_sifre = '" + sifre + "'", baglanti);

            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                adi = dr["ad"].ToString();
                label10.Text = adi;
            }
            baglanti.Close();

        }
        private void button8_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        
    }
}
