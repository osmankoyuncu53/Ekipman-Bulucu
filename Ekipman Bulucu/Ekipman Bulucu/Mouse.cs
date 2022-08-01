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
    public partial class Mouse : Form
    {
        public Mouse()
        {
            InitializeComponent();
        }

        public static string url = "";
        public static string ad = "";
        public static string fiyatı = "";
        public static string marka = "";
        public static string resimyolu = "";
        public static string puan = "";
        public static string sayfa = "";
        string cs = "Data Source=.;Initial Catalog=MyEquipment;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        DataSet ds;
        SqlCommand cmd;

        void griddoldur()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
            adapt = new SqlDataAdapter("Select *From Mouse", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adapt.Fill(ds, "Mouse");
            dataGridView1.DataSource = ds.Tables["Mouse"];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button2.Visible = true;
            label8.Visible = true;
            dataGridView1.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label10.Visible = true;
            string tur = "";
            string boy = "";
            string makro = "";
            string kablo = "";
            string ufiyat = "";

           tur = comboBox1.Text;
            boy = comboBox2.Text;
            makro = comboBox3.Text;
            kablo = comboBox5.Text;
            ufiyat = comboBox4.Text;


            if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "' and  Makro ='" + makro + "' and  Kablosuz ='" + kablo + "' and  Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {

                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Urun_boy='" + boy + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Makro='" + makro + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Kablosuz='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Makro ='" + makro + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Kablosuz ='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Urun_boy='" + boy + "' and Makro ='" + makro + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Urun_boy='" + boy + "' and Kablosuz ='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Urun_boy='" + boy + "' and Fiyat_Seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Makro='" + makro + "' and Kablosuz ='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Makro='" + makro + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Kablosuz='" + kablo + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "'and Makro='"+makro+"'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "'and Kablosuz='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Urun_boy='" + boy + "' and Makro ='" + makro + "'and Kablosuz='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Urun_boy='" + boy + "' and Makro ='" + makro + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Kablosuz='" + kablo + "' and Makro ='" + makro + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Kablosuz='" + kablo + "' and Makro ='" + makro + "'and Oyun_tur='" + tur + "' and Urun_boy='"+boy+"'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Fiyat_seviye='" + ufiyat + "' and Makro ='" + makro + "'and Oyun_tur='" + tur + "' and Urun_boy='" + boy + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Fiyat_seviye='" + ufiyat + "' and Kablosuz ='" + kablo + "'and Oyun_tur='" + tur + "' and Urun_boy='" + boy + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Fiyat_seviye='" + ufiyat + "' and Kablosuz ='" + kablo + "'and Oyun_tur='" + tur + "' and Makro='" + makro + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && makro != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mouse where Fiyat_seviye='" + ufiyat + "' and Kablosuz ='" + kablo + "'and Urun_boy='" + boy + "' and Makro='" + makro + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            int kayitsayisi;
            
            kayitsayisi = dataGridView1.RowCount;
            label7.Text = kayitsayisi.ToString();
            if (kayitsayisi==0)
            {
                MessageBox.Show("Aradığınız kriterde ürün bulamadık....");
                panel1.Visible = true;
                dataGridView1.Visible = false;
                button2.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label5.Visible = false;
                panel1.Visible = true;
                label10.Visible = false;
                comboBox3.Text = "SEÇİNİZ....";
                comboBox1.Text = "SEÇİNİZ....";
                comboBox2.Text = "SEÇİNİZ....";
                comboBox5.Text = "SEÇİNİZ....";
                comboBox4.Text = "SEÇİNİZ....";
            }


        }

        private void Mouse_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet8.Mouse' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mouseTableAdapter.Fill(this.myEquipmentDataSet8.Mouse);
            button2.Visible = false;
            label8.Visible = false;
            dataGridView1.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Filtelemeyi Uygula");
            Aciklama.SetToolTip(button2, "Filtrele");
            Aciklama.SetToolTip(button3, "Geri");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button2.Visible = false;
            dataGridView1.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
        }

        

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Ürün seçildi....");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string adi = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string markasi = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string fiyat = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string link = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string puani = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
          //  string resimyol = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();

            url = link;
            ad = adi;
            marka = markasi;
            fiyatı = fiyat;
            puan = puani;
           // resimyolu = resimyol;
            sayfa = "2";
            UrunBilgi urunBilgi = new UrunBilgi();
            urunBilgi.Show();
            this.Hide();
        }

        private void Mouse_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }

        private void Mouse_FormClosing_1(object sender, FormClosingEventArgs e)
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
