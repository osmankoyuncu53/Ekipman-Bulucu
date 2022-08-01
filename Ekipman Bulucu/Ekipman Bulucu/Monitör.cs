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
    public partial class Monitör : Form
    {
        public Monitör()
        {
            InitializeComponent();
        }

        public static string url = "";
        public static string ad = "";
        public static string fiyatı = "";
        public static string marka = "";
        public static string resimyolu = "";
        public static string puan = "";
        public static string sayfaa5 = "";
        string cs = "Data Source=.;Initial Catalog=MyEquipment;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        DataSet ds;
        SqlCommand cmd;
        void griddoldur()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
            adapt = new SqlDataAdapter("Select *From Monitor", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adapt.Fill(ds, "Monitor");
            dataGridView1.DataSource = ds.Tables["Monitor"];
            baglanti.Close();
        }
        private void Monitör_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet4.Monitor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.monitorTableAdapter.Fill(this.myEquipmentDataSet4.Monitor);
            dataGridView1.Visible = false;
            button2.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label3.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Filtrelemeyi Uygula");
            Aciklama.SetToolTip(button2, "Filtrele");
            Aciklama.SetToolTip(button3, "Geri");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }
        // TazelemeOrani    Urun_boy   Kavis         Fiyat_seviye
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            panel1.Visible = false;
            dataGridView1.Visible = true;
            button2.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            string hz = comboBox1.Text;
            string boy = comboBox2.Text;
            string Kavis = comboBox3.Text;
            string ufiyat = comboBox4.Text;

            if (hz != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && Kavis != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' and Urun_boy ='" + boy + "' and Kavis='" + Kavis + "' and  Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && Kavis == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && Kavis == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' and Urun_boy ='" + boy + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && Kavis != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' and kablo ='" + Kavis + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && Kavis == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && Kavis != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where Urun_boy='" + boy + "' and Kavis ='" + Kavis + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && Kavis == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where Urun_boy='" + boy + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && Kavis != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where Kavis='" + Kavis + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && Kavis != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' and Urun_boy ='" + boy + "'and Kavis='" + Kavis + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (hz != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && Kavis == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' and Urun_boy ='" + boy + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && Kavis != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' and Kavis ='" + Kavis + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (hz == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && Kavis != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where Urun_boy='" + boy + "' and Kavis ='" + Kavis + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else

            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Monitor where TazelemeOrani='" + hz + "' or Urun_boy ='" + boy + "' or Kavis='" + Kavis + "' or  Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            //griddoldur();
            int kayitsayisi;

            kayitsayisi = dataGridView1.RowCount;
            int yenikayıtsayisi = kayitsayisi - 1;
            label7.Text = yenikayıtsayisi.ToString();
            if (yenikayıtsayisi == 0)
            {
                MessageBox.Show("Aradığınız kriterde ürün bulamadık....");
                panel1.Visible = true;
                dataGridView1.Visible = false;
                button2.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label5.Visible = false;
                label3.Visible = false;
                comboBox1.Text = "SEÇİNİZ....";
                comboBox2.Text = "SEÇİNİZ....";
                comboBox3.Text = "SEÇİNİZ....";
                comboBox4.Text = "SEÇİNİZ....";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            button2.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            panel1.Visible = true;
            label8.Visible = false;
            label3.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ÜRÜN SEÇİLDİ");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string adi = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string markasi = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string fiyat = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            string link = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string puani = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            ad = adi;
            marka = markasi;
            fiyatı = fiyat;
            url = link;
            puan = puani;
            sayfaa5 = "5";
            UrunBilgi urunBilgi = new UrunBilgi();
            urunBilgi.Show();
            this.Hide();
        }

        private void Monitör_FormClosing(object sender, FormClosingEventArgs e)
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
