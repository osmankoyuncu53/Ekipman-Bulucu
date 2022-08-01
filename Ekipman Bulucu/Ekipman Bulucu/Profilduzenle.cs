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
    public partial class Profilduzenle : Form
    {
        public Profilduzenle()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        private void Profilduzenle_Load(object sender, EventArgs e)
        {
            string adi = Profil.adi.ToString();
            string soyadi = Profil.soyadi.ToString();
            string eposta = Profil.eposta.ToString();
            string tel = Profil.tel.ToString();
            string il = Profil.il.ToString();
            string ulke = Profil.ulke.ToString();
            string yil = Profil.yil.ToString();
            label20.Text=Profil.id;
            button2.Visible = false;
            label9.Visible = false;


            textBox1.Text = adi;
            textBox2.Text = soyadi;
            textBox3.Text = tel;
            textBox4.Text = eposta;
            comboBox1.Text = ulke;
            textBox5.Text = il;
            textBox6.Text=yil;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            comboBox1.Enabled = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Düzenlemeyi etkinleştir");
            Aciklama.SetToolTip(button2, "Kaydet");
            Aciklama.SetToolTip(button3, "Geri");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            comboBox1.Enabled = true;
            button2.Visible = true;
            label9.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int id = Convert.ToInt32(label20.Text);
               int yil=Convert.ToInt32(textBox6.Text);
                if (yil >= 1945 && yil <= 2002)
                {


                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
                    {
                        MessageBox.Show("Lütfen bütün alanları doldurunuz...");
                    }
                    else
                    {
                        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                        cmd = new SqlCommand();
                        baglanti.Open();
                        cmd.Connection = baglanti;
                        cmd.CommandText = "update Kullanici_giris set  ad='" + textBox1.Text + "',soyadi='" + textBox2.Text + "',telno='" + textBox3.Text + "',e_posta='" + textBox4.Text + "',ulke='" + comboBox1.Text + "',il='" + textBox5.Text + "',dogum_yili='" + textBox6.Text + "' where id= '" + id + "'";
                        cmd.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Bilgileriniz değişti....");
                        // griddoldur();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen doğum yılını 1945 ile 2002 arasında giriniz....");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil();
            profil.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

       

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Profilduzenle_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Üyeliğinizi silmek istediğinize emin misiniz?", "Üyelik siliniyor....", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                cmd = new SqlCommand();
                baglanti.Open();
                cmd.Connection = baglanti;
                cmd.CommandText = "Delete Kullanici_giris where id='" + label20.Text + "'";
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güle Güle ! Seni özleyeceğiz....");
                //delete from Kullanıcıgir where Kullanıcı_Adı='" + textBox1.Text + "'";

                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();

            }
            else if (x == DialogResult.No)
            {
                MessageBox.Show("Üyelik silme işlemi iptal edildi....");

            }
        }
    }
}

