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
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }
        public static string adi;
        public static string soyadi;
        public static string eposta;
        public static string tel;
        public static string yil;
        public static string ulke;
        public static string il;
        public static string id;
        private void Profil_Load(object sender, EventArgs e)
        {
            string kadi = UyeGirisi.k.ToString();
            string sifre = UyeGirisi.s.ToString();
           

            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from Kullanici_giris where kullanici_adi='" + kadi + "'    and kullanici_sifre = '" + sifre + "'", baglanti);
            //SqlCommand komut2 = new SqlCommand("select * from Kullanici_giris where kullanici_adi='" + kadi + "'    and kullanici_sifre = '" + sifre + "'", baglanti);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                adi = dr["ad"].ToString();
                label10.Text = adi;
                soyadi = dr["soyadi"].ToString();
                label12.Text = soyadi;
                tel = dr["telno"].ToString();
                label11.Text = tel;
                eposta = dr["e_posta"].ToString();
                label14.Text = eposta;
                yil = dr["dogum_yili"].ToString();
                label16.Text = yil;
                ulke = dr["ulke"].ToString();
                label13.Text = ulke;
                il = dr["il"].ToString();
                label15.Text = il;
                id = dr["id"].ToString();
                label20.Text = id;
                label17.Text = kadi;
                // label18.Text = sifre;
                ToolTip Aciklama = new ToolTip();
                Aciklama.SetToolTip(button1, "Geri");
                Aciklama.SetToolTip(linkLabel1, "Bilgilerinizi güncellemek için tıklayın....");
                Aciklama.SetToolTip(checkBox1, "Şifreyi Göster");
               
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string sifre = UyeGirisi.s.ToString();
            
            if (checkBox1.Checked)
            {

                label18.Text = sifre;
            }
            else
            {

                label18.Text = "**********";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profilduzenle profilduzenle = new Profilduzenle();
            profilduzenle.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }

        private void Profil_FormClosing(object sender, FormClosingEventArgs e)
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
