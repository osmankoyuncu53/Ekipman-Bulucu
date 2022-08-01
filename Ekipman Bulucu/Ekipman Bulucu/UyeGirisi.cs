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
    public partial class UyeGirisi : Form
    {
        public UyeGirisi()
        {
            InitializeComponent();
        }

        public static string k = "";
        public static string s = "";



        public static string K { get => k; set => k = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtOl kayitol = new KayıtOl();
            kayitol.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeGirisi uyeGirisi = new UyeGirisi();
            uyeGirisi.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from Kullanici_giris where kullanici_adi='" + tbKullanici.Text + "'    and kullanici_sifre = '" + tbParola.Text + "'", baglanti);
            baglanti.Open();
            int Sonuc = Convert.ToInt32(komut.ExecuteScalar());

            if (Sonuc != 0)
            {

                k = tbKullanici.Text;
                s = tbParola.Text;
                Loading yklnyr = new Loading();
                yklnyr.Show();
                this.Hide();
            }

            else
            {



                MessageBox.Show("Kullanıcı Adı Veya Parola Yanlış.....", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*Loading loading = new Loading();
            loading.Show();
            this.Hide();*/
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {

                tbParola.PasswordChar = '\0';
            }
            else
            {

                tbParola.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void UyeGirisi_FormClosing(object sender, FormClosingEventArgs e)
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

        private void UyeGirisi_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Yenile");
            Aciklama.SetToolTip(button2, "Kaydol");
            Aciklama.SetToolTip(button3, "Anasayfa");
            Aciklama.SetToolTip(btnGiris, "Giriş");
        }
    }
}
