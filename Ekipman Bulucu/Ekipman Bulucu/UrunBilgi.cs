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
    public partial class UrunBilgi : Form
    {
        public UrunBilgi()
        {
            InitializeComponent();
        }

        private void UrunBilgi_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string sayfa = Klavye.sayfano.ToString();
            string sayfa2 = Mouse.sayfa.ToString();
            string sayfa3 = Kulaklık.sayfaa.ToString();
            string sayfa4 = Mousepad.sayfaa4.ToString();
            string sayfa5 = Monitör.sayfaa5.ToString();
            string sayfa6 = OyuncuKoltuguu.sayfaa6.ToString();
            string resimyol;
            string resimyol2;
            string resimyol3;
            string resimyol4;
            string resimyol5;
            string resimyol6;
            try
            {

            


            if (sayfa == "1")
            {
                sayfa = "0";
                string link = Klavye.url.ToString();
                string adi = Klavye.ad.ToString();
                string markasi = Klavye.marka.ToString();
                string fiyat = Klavye.fiyatı.ToString();
                string puan = Klavye.puan.ToString();
                //string resimyolu = Klavye.resimyolu.ToString();
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                SqlCommand komut = new SqlCommand("select * from Klavye where Urun_adi='" + adi + "'    and Urun_Link = '" + link + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    resimyol = dr["Urun_Resimlink"].ToString();
                    pictureBox1.ImageLocation = resimyol;
                }
                baglanti.Close();

                label1.Text = adi;
                label2.Text = markasi;
                label3.Text = fiyat;
                label10.Text = puan;


            }

            else if (sayfa2 == "2")
            {
                sayfa2 = "0";
                string link2 = Mouse.url.ToString();
                string adi2 = Mouse.ad.ToString();
                string markasi2 = Mouse.marka.ToString();
                string fiyat2 = Mouse.fiyatı.ToString();
                string puan2 = Mouse.puan.ToString();
                //string resimyolu2 = Mouse.resimyolu.ToString();
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                SqlCommand komut = new SqlCommand("select * from Mouse where Urun_adi='" + adi2 + "'    and Urun_Link = '" + link2 + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    resimyol2 = dr["Urun_Resimlink"].ToString();
                    pictureBox1.ImageLocation = resimyol2;
                }
                baglanti.Close();
                label1.Text = adi2;
                label2.Text = markasi2;
                label3.Text = fiyat2;
                label10.Text = puan2;

                //ctureBox1.ImageLocation = resimyol2;
            }

            else if (sayfa3 == "3")
            {
                sayfa3 = "0";
                string link3 = Kulaklık.url.ToString();
                string adi3 = Kulaklık.ad.ToString();
                string markasi3 = Kulaklık.marka.ToString();
                string fiyat3 = Kulaklık.fiyatı.ToString();
                string puan3 = Kulaklık.puan.ToString();
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                SqlCommand komut = new SqlCommand("select * from Kulaklık where Urun_adi='" + adi3 + "'    and Urun_Link = '" + link3 + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    resimyol3 = dr["Urun_Resimlink"].ToString();
                    pictureBox1.ImageLocation = resimyol3;
                }
                baglanti.Close();
                label10.Text = puan3;
                label1.Text = adi3;
                label2.Text = markasi3;
                label3.Text = fiyat3;

            }
            else if (sayfa4 == "4")
            {
                sayfa3 = "0";
                string link4 = Mousepad.url.ToString();
                string adi4 = Mousepad.ad.ToString();
                string markasi4 = Mousepad.marka.ToString();
                string fiyat4 = Mousepad.fiyatı.ToString();
                string puan4 = Mousepad.puan.ToString();
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                SqlCommand komut = new SqlCommand("select * from Mousepad where Urun_adi='" + adi4 + "'    and Urun_Link = '" + link4 + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    resimyol4 = dr["Urun_Resimlink"].ToString();
                    pictureBox1.ImageLocation = resimyol4;
                }
                baglanti.Close();
                label10.Text = puan4;
                label1.Text = adi4;
                label2.Text = markasi4;
                label3.Text = fiyat4;

            }
            else if (sayfa5 == "5")
            {
                sayfa5 = "0";
                string link5 = Monitör.url.ToString();
                string adi5 = Monitör.ad.ToString();
                string markasi5 = Monitör.marka.ToString();
                string fiyat5 = Monitör.fiyatı.ToString();
                string puan5 = Monitör.puan.ToString();
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                SqlCommand komut = new SqlCommand("select * from Monitor where Urun_adi='" + adi5 + "'    and Urun_Link = '" + link5 + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    resimyol5 = dr["Urun_Resimlink"].ToString();
                    pictureBox1.ImageLocation = resimyol5;
                }
                baglanti.Close();
                label10.Text = puan5;
                label1.Text = adi5;
                label2.Text = markasi5;
                label3.Text = fiyat5;
            }
            else if (sayfa6 == "6")
            {
                sayfa6 = "0";
                string link6 = OyuncuKoltuguu.url.ToString();
                string adi6 = OyuncuKoltuguu.ad.ToString();
                string markasi6 = OyuncuKoltuguu.marka.ToString();
                string fiyat6 = OyuncuKoltuguu.fiyatı.ToString();
                string puan6 = OyuncuKoltuguu.puan.ToString();
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                SqlCommand komut = new SqlCommand("select * from OyuncuKoltugu where Urun_adi='" + adi6 + "'    and Urun_Link = '" + link6 + "'", baglanti);
                baglanti.Open();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    resimyol6 = dr["Urun_Resimlink"].ToString();
                    pictureBox1.ImageLocation = resimyol6;
                }
                baglanti.Close();
                label10.Text = puan6;
                label1.Text = adi6;
                label2.Text = markasi6;
                label3.Text = fiyat6;
            }
            else
            {
                MessageBox.Show("Tüh!!! Beklenmedik bir sorunla karşılaştık. Lütfen tekrar deneyin....");
            }
        }
             catch 
            {

                MessageBox.Show("Tüh!!! Beklenmedik bir sorunla karşılaştık. Lütfen tekrar deneyin....");
                Ekipman ekipman = new Ekipman();
                ekipman.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string link = Klavye.url.ToString();
            string link2 = Mouse.url.ToString();
            string link3 = Kulaklık.url.ToString();
            string link4 = Mousepad .url.ToString();
            string link5 = Monitör.url.ToString();
            string link6 = OyuncuKoltuguu.url.ToString();
            int sayi = Convert.ToInt32(label4.Text) - 1;
            string sayfa = Klavye.sayfano.ToString();
            string sayfa2 = Mouse.sayfa.ToString();
            string sayfa3 = Kulaklık.sayfaa.ToString();
            string sayfa4 = Mousepad.sayfaa4.ToString();
            string sayfa5 = Monitör.sayfaa5.ToString();
            string sayfa6 = OyuncuKoltuguu.sayfaa6.ToString();
            label4.Text = sayi.ToString();

            if (sayi == 0)
            {
                label4.Visible = false;
                label5.Visible = false;
                if (sayfa == "1")
                {
                    System.Diagnostics.Process.Start(link);
                }
                else if (sayfa2 == "2")
                {
                    System.Diagnostics.Process.Start(link2);
                }
                else if (sayfa3 == "3")
                {
                    System.Diagnostics.Process.Start(link3);
                }
                else if (sayfa4 == "4")
                {
                    System.Diagnostics.Process.Start(link4);
                }
                else if (sayfa5=="5")
                {
                    System.Diagnostics.Process.Start(link5);
                }
                else if (sayfa6=="6")
                {
                    System.Diagnostics.Process.Start(link6);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Enabled = false;
           
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }

        private void UrunBilgi_FormClosing(object sender, FormClosingEventArgs e)
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
