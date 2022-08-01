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
    public partial class Kulaklık : Form
    {
        public Kulaklık()
        {
            InitializeComponent();
        }
        public static string url = "";
        public static string ad = "";
        public static string fiyatı = "";
        public static string marka = "";
        public static string resimyolu = "";
        public static string puan = "";
        public static string sayfaa = "";
        string cs = "Data Source=.;Initial Catalog=MyEquipment;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        DataSet ds;
        SqlCommand cmd;
        void griddoldur()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
            adapt = new SqlDataAdapter("Select *From Kulaklık", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adapt.Fill(ds, "Kulaklık");
            dataGridView1.DataSource = ds.Tables["Kulaklık"];
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }

        private void Kulaklık_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet10.Kulaklık' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kulaklıkTableAdapter.Fill(this.myEquipmentDataSet10.Kulaklık);

            label8.Visible = false;
            dataGridView1.Visible = false;
            button2.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label3.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Filtelemeyi Uygula");
            Aciklama.SetToolTip(button2, "Filtrele");
            Aciklama.SetToolTip(button3, "Geri");
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button2.Visible = true;
            label8.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label3.Visible = true;
            dataGridView1.Visible = true;
            string ses = comboBox1.Text;
            string muzik = comboBox2.Text;
            string kablo = comboBox5.Text;
            string ufiyat = comboBox4.Text;

            if (ses != "SEÇİNİZ...." && muzik != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' and müzik_perf ='" + muzik + "' and kablo='" + kablo + "' and  Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses == "SEÇİNİZ...." && muzik == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses != "SEÇİNİZ...." && muzik != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' and müzik_perf ='" + muzik + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses != "SEÇİNİZ...." && muzik == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' and kablo ='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses != "SEÇİNİZ...." && muzik == "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses == "SEÇİNİZ...." && muzik != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where müzik_perf='" + muzik + "' and kablo ='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses == "SEÇİNİZ...." && muzik != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where müzik_perf='" + muzik + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses == "SEÇİNİZ...." && muzik == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where kablo='" + kablo + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses != "SEÇİNİZ...." && muzik != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' and müzik_perf ='" + muzik + "'and kablo='" + kablo + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (ses != "SEÇİNİZ...." && muzik != "SEÇİNİZ...." && kablo == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' and müzik_perf ='" + muzik + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses != "SEÇİNİZ...." && muzik == "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' and kablo ='" + kablo + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (ses == "SEÇİNİZ...." && muzik != "SEÇİNİZ...." && kablo != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where müzik_perf='" + muzik + "' and kablo ='" + kablo + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else

            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Kulaklık where ses_kas='" + ses + "' or müzik_perf ='" + muzik + "' or kablo='" + kablo + "' or  Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            //griddoldur();
            int kayitsayisi;

            kayitsayisi = dataGridView1.RowCount;
            int yenikayitsayisi = kayitsayisi - 1;
            label7.Text = yenikayitsayisi.ToString();
            
            if (yenikayitsayisi == 0)
            {
                MessageBox.Show("Aradığınız kriterde ürün bulamadık....");
                panel1.Visible = true;
                dataGridView1.Visible = false;
                button2.Visible = false;
                label8.Visible = false;
                label3.Visible = false;
                label7.Visible = false;
                label5.Visible = false;
                comboBox1.Text = "SEÇİNİZ....";
                comboBox2.Text = "SEÇİNİZ....";
                comboBox5.Text = "SEÇİNİZ....";
                comboBox4.Text = "SEÇİNİZ....";
              

            }
        }

        private void Kulaklık_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel1.Visible = true;
            button2.Visible = false;
            label8.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label3.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ÜRÜN SEÇİLDİ");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string adi = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string markasi = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string fiyat = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string link = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string puani = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            ad = adi;
            marka = markasi;
            fiyatı = fiyat;
            url = link;
            puan = puani;
            sayfaa = "3";
            UrunBilgi urunBilgi = new UrunBilgi();
            urunBilgi.Show();
            this.Hide();

        }
    }
}
