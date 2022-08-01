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
    public partial class KayıtOl : Form
    {
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        string cs = "Data Source=.;Initial Catalog=MyEquipment;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        string drm;

        public KayıtOl()
        {
            InitializeComponent();
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

        private void KayıtOl_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            panel1.Visible = false;
            Aciklama.SetToolTip(button1, "Kaydol");
            Aciklama.SetToolTip(button2, "Geri");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                int dy = Convert.ToInt32(textBox6.Text);
                if (dy >= 1945 && dy <= 2002)
                {
                    // int id = Convert.ToInt32(textBox9.Text);
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "" || textBox5.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox8.Text == "")
                    {
                        MessageBox.Show("Lütfen bütün alanları doldurunuz...");
                    }
                    else
                    {


                        if (true)
                        {
                            con = new SqlConnection(cs);
                            con.Open();
                            SqlCommand komut = new SqlCommand("select * from Kullanici_giris where kullanici_adi='" + textBox7.Text + "'", con);
                            SqlDataReader dr = komut.ExecuteReader();


                            if (dr.Read())
                            {
                                MessageBox.Show("Bu kullanıcı adı kullanılıyor....");

                                panel1.BackColor = Color.Red;
                                label10.Text = "Kayıt Başarısız !";
                                textBox7.Text = "";

                            }
                            else if (true)
                            {
                                con = new SqlConnection(cs);
                                con.Open();
                                SqlCommand komut2 = new SqlCommand("select * from Kullanici_giris where e_posta='" + textBox4.Text + "'", con);
                                SqlDataReader dr2 = komut2.ExecuteReader();


                                if (dr2.Read())
                                {
                                    MessageBox.Show("Bu e-posta kullanılıyor....");

                                    panel1.BackColor = Color.Red;
                                    label10.Text = "Kayıt Başarısız !";
                                    textBox4.Text = "";
                                }
                                else if (true)
                                {
                                    con = new SqlConnection(cs);
                                    con.Open();
                                    SqlCommand komut3 = new SqlCommand("select * from Kullanici_giris where telno='" + textBox3.Text + "'", con);
                                    SqlDataReader dr3 = komut3.ExecuteReader();


                                    if (dr3.Read())
                                    {
                                        MessageBox.Show("Bu telefon numarası kullanılıyor....");

                                        panel1.BackColor = Color.Red;
                                        label10.Text = "Kayıt Başarısız !";
                                        textBox3.Text = "";
                                    }
                                    else
                                    {
                                        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
                                        cmd = new SqlCommand();
                                        baglanti.Open();
                                        cmd.Connection = baglanti;
                                        cmd.CommandText = "insert into Kullanici_giris(kullanici_adi,kullanici_sifre,ad,soyadi,telno,e_posta,ulke,il,dogum_yili) values ('" + textBox7.Text + "','" + textBox8.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                                        cmd.ExecuteNonQuery();
                                        baglanti.Close();
                                        panel1.BackColor = Color.Green;
                                        label10.Text = "Kayıt Başarılı !";
                                        textBox1.Text = "";
                                        textBox2.Text = "";
                                        textBox3.Text = "";
                                        textBox4.Text = "";
                                        textBox5.Text = "";
                                        textBox6.Text = "";
                                        textBox7.Text = "";
                                        textBox8.Text = "";
                                        comboBox1.SelectedItem = "Türkiye";
                                    }

                                }



                            }
                        }







                    }
                }
                else
                {
                    MessageBox.Show("Lütfen doğum yılını 1945 ile 2002 arasında giriniz....");
                    panel1.BackColor = Color.Red;
                    label10.Text = "Kayıt Başarısız !";
                }
            }


            catch
            {
                panel1.BackColor = Color.Red;
                label10.Text = "Kayıt Başarısız !";
                MessageBox.Show("Girdiğiniz bilgileri kontrol ediniz....");

            }

        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeGirisi uyeGirisi = new UyeGirisi();
            uyeGirisi.Show();
            this.Hide();
        }

        private void KayıtOl_FormClosing(object sender, FormClosingEventArgs e)
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

      

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

