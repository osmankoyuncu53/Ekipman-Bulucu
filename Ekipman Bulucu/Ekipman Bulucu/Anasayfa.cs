using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekipman_Bulucu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProgramHakkinda form1 = new ProgramHakkinda();
            form1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UyeGirisi form2 = new UyeGirisi();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkipmanUyeOlmayanlarIcın ekipman2 = new EkipmanUyeOlmayanlarIcın();
                ekipman2.Show();
            this.Hide();
        }

       

        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            if (label5.Text== "Copyright  © 2021")
            {
                label5.Text = "Bütün hakları Samet,Osman ve Mehmet'de saklıdır.";
            }
            else
            {
                label5.Text = "Copyright  © 2021";
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "Üye olmadan devam et");
            Aciklama.SetToolTip(button2, "Üye Girişi");
            
            Aciklama.SetToolTip(button4, "Program Hakkında");
        }

     
    }
}
