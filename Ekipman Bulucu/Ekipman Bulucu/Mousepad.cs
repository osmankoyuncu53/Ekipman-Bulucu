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
    public partial class Mousepad : Form
    {
        public Mousepad()
        {
            InitializeComponent();
        }
        public static string url = "";
        public static string ad = "";
        public static string fiyatı = "";
        public static string marka = "";
        public static string resimyolu = "";
        public static string puan = "";
        public static string sayfaa4 = "";
        string cs = "Data Source=.;Initial Catalog=MyEquipment;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        DataSet ds;
        SqlCommand cmd;
        private void Mousepad_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet13.Mousepad' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mousepadTableAdapter.Fill(this.myEquipmentDataSet13.Mousepad);
            dataGridView1.Visible = false;
            button2.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label10.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Filtrelemeyi Uygula");
            Aciklama.SetToolTip(button2, "Filtrele");
            Aciklama.SetToolTip(button3, "Geri");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string boy = comboBox2.Text;
            string ufiyat = comboBox4.Text;
            dataGridView1.Visible = true;
            panel1.Visible = false;
            button2.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label10.Visible = true;
            if (boy != "SEÇİNİZ...."  && ufiyat != "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mousepad where Urun_boy='" + boy + "' and Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }

            else if (boy == "SEÇİNİZ...." && ufiyat == "SEÇİNİZ....")
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mousepad", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
           
            else
            {
                con = new SqlConnection(cs);
                con.Open();
                adapt = new SqlDataAdapter("select * from Mousepad where Urun_boy='" + boy + "' or Fiyat_seviye ='" + ufiyat + "'", con);
                dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }



            int kayitsayisi;

            kayitsayisi = dataGridView1.RowCount;
            int yenikayitsayisi = kayitsayisi - 1;
            label7.Text = yenikayitsayisi.ToString();
            if (kayitsayisi == 0)
            {
                MessageBox.Show("Aradığınız kriterde ürün bulamadık....");
                panel1.Visible = true;
                dataGridView1.Visible = false;
                button2.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label5.Visible = false;
                label10.Visible = false;

                comboBox2.Text = "SEÇİNİZ....";
               
                comboBox4.Text = "SEÇİNİZ....";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            panel1.Visible = true;
            button2.Visible = false;
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
            // string resimyol = dataGridView1.Rows[seçilialan].Cells[5].Value.ToString();

            url = link;
            ad = adi;
            marka = markasi;
            fiyatı = fiyat;
            //string resimyol;
            sayfaa4 = "4";
            puan = puani;


            con.Close();

            UrunBilgi urunBilgi = new UrunBilgi();
            urunBilgi.Show();
            this.Hide();
        }

        private void Mousepad_FormClosing(object sender, FormClosingEventArgs e)
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
