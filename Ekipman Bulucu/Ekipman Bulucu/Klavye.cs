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
    public partial class Klavye : Form
    {
        public Klavye()
        {
            InitializeComponent();
        }
        public static string url = "";
        public static string ad = "";
        public static string fiyatı = "";
        public static string marka = "";
        public static string resimyolu = "";
        public static string puan = "";
        public static string sayfano = "";
        string cs = "Data Source=.;Initial Catalog=MyEquipment;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        DataSet ds;
        SqlCommand cmd;
        private void Klavye_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet14.Klavye' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.klavyeTableAdapter.Fill(this.myEquipmentDataSet14.Klavye);
      

            button2.Visible = false;
            label3.Visible = false;
            dataGridView1.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
          
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Filtelemeyi Uygula");
            Aciklama.SetToolTip(button2, "Filtrele");
            Aciklama.SetToolTip(button3, "Geri");
        }
        /*void griddoldur()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=MyEquipment;Integrated Security=True");
            adapt = new SqlDataAdapter("Select * From Klavye", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adapt.Fill(ds, "Klavye");
            dataGridView1.DataSource = ds.Tables["Klavye"];
            baglanti.Close();
        }
        */
       
        
        private void button1_Click(object sender, EventArgs e)
        {

           
            panel1.Visible = false;
            button2.Visible = true;
            label3.Visible = true;
            dataGridView1.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            string tur = comboBox1.Text;
            string boy = comboBox2.Text;
            string bdestek = comboBox3.Text;
            string ufiyat = comboBox4.Text;

            if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && bdestek != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "' and Bilek_destegi='" + bdestek + "' and  Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && bdestek == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && bdestek == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && bdestek != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' and Bilek_destegi ='" + bdestek + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && bdestek == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && bdestek != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Urun_boy='" + boy + "' and Bilek_destegi ='" + bdestek + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && bdestek == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Urun_boy='" + boy + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy == "SEÇİNİZ...." && bdestek != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Bilek_destegi='" + bdestek + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && bdestek != "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "'and Bilek_destegi='" + bdestek + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            else if (tur != "SEÇİNİZ...." && boy != "SEÇİNİZ...." && bdestek == "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' and Urun_boy ='" + boy + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur != "SEÇİNİZ...." && boy == "SEÇİNİZ...." && bdestek != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' and Bilek_destegi ='" + bdestek + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else if (tur == "SEÇİNİZ...." && boy != "SEÇİNİZ...." && bdestek != "SEÇİNİZ...." && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Urun_boy='" + boy + "' and Bilek_destegi ='" + bdestek + "'and Fiyat_seviye='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else

            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Klavye where Oyun_tur='" + tur + "' or Urun_boy ='" + boy + "' or Bilek_destegi='" + bdestek + "' or  Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            int kayitsayisi;
            kayitsayisi = dataGridView1.RowCount;
            label7.Text = kayitsayisi.ToString();
            if (kayitsayisi == 0)
            {
                MessageBox.Show("Aradığınız kriterde ürün bulamadık....");
                panel1.Visible = true;
                dataGridView1.Visible = false;
                button2.Visible = false;
                label3.Visible = false;
                label7.Visible = false;
                label5.Visible = false;
            
                comboBox1.Text = "SEÇİNİZ....";
                comboBox2.Text = "SEÇİNİZ....";
                comboBox3.Text = "SEÇİNİZ....";
                comboBox4.Text = "SEÇİNİZ....";
            }


            //griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button2.Visible = false;
            label9.Visible = false;
            label3.Visible = false;
            dataGridView1.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
        }

        private void Klavye_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            MessageBox.Show("Ürün seçildi....");
            int seçilialan = dataGridView1.SelectedCells[0].RowIndex;
            string adi = dataGridView1.Rows[seçilialan].Cells[0].Value.ToString();
            string markasi = dataGridView1.Rows[seçilialan].Cells[1].Value.ToString();
            string fiyat = dataGridView1.Rows[seçilialan].Cells[2].Value.ToString();
            string link = dataGridView1.Rows[seçilialan].Cells[3].Value.ToString();
            string puani = dataGridView1.Rows[seçilialan].Cells[4].Value.ToString();
            // string resimyol = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();

            url = link;
            ad = adi;
            marka = markasi;
            fiyatı = fiyat;
            //string resimyol;
            sayfano = "1";
            puan = puani;
            
          
            con.Close();

            UrunBilgi urunBilgi = new UrunBilgi();
            urunBilgi.Show();
            this.Hide();
        }
    }
}
          
        