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
    public partial class OyuncuKoltuguu : Form
    {
        public OyuncuKoltuguu()
        {
            InitializeComponent();
        }

        public static string url = "";
        public static string ad = "";
        public static string fiyatı = "";
        public static string marka = "";
        public static string resimyolu = "";
        public static string puan = "";
        public static string sayfaa6 = "";
        string cs = "Data Source=.;Initial Catalog=MyEquipment;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        DataSet ds;
        SqlCommand cmd;
        private void button3_Click(object sender, EventArgs e)
        {
            Ekipman ekipman = new Ekipman();
            ekipman.Show();
            this.Hide();
        }

        private void OyuncuKoltuguu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'myEquipmentDataSet15.OyuncuKoltugu' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.oyuncuKoltuguTableAdapter.Fill(this.myEquipmentDataSet15.OyuncuKoltugu);
            button2.Visible = false;
            label8.Visible= false;
            label5.Visible = false;
            label7.Visible = false;
            label10.Visible = false;
            dataGridView1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label10.Visible = false;
            panel1.Visible = true;
            button2.Visible = false;
            label8.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            dataGridView1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ufiyat = "";

           
            ufiyat = comboBox4.Text;
            label10.Visible = true;
            panel1.Visible = false;
            button2.Visible = true;
            label8.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            dataGridView1.Visible = true;
            try
            {
                if (ufiyat == "SEÇİNİZ....")
                {

                    con = new SqlConnection(cs);
                    con.Open();
                    adapt = new SqlDataAdapter("select * from OyuncuKoltugu ", con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();

                }
                else
                {
                    con = new SqlConnection(cs);
                    con.Open();
                    adapt = new SqlDataAdapter("select * from OyuncuKoltugu where Fiyat_seviye='" + ufiyat + "'", con);
                    dt = new DataTable();
                    adapt.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol ediniz....");
            }

           







            int kayitsayısı = dataGridView1.RowCount;
            label7.Text = kayitsayısı.ToString();
            if (kayitsayısı==0)
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol ediniz....");
                comboBox4.Text="SEÇİNİZ....";
                panel1.Visible = true;
                dataGridView1.Visible = false;
                button2.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label5.Visible = false;
            }
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
            sayfaa6 = "6";
            UrunBilgi urunBilgi = new UrunBilgi();
            urunBilgi.Show();
            this.Hide();
        }

        private void OyuncuKoltuguu_FormClosing(object sender, FormClosingEventArgs e)
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
