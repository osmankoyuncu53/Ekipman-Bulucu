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
    public partial class Yonlendiriliyorsunuz : Form
    {
        public Yonlendiriliyorsunuz()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string link = Klavye2.url.ToString();
            string link2 = Mouse2.url.ToString();
            string link3 = Kulaklık2.url.ToString();
            string link4 = Mousepad2.url.ToString();
            string link5 = Monitor2.url.ToString();
            string link6 = OyuncuKoltugu2.url.ToString();
            int sayi = Convert.ToInt32(label4.Text) - 1;
            string sayfa = Klavye2.sayfano.ToString();
            string sayfa2 = Mouse2.sayfa.ToString();
            string sayfa3 = Kulaklık2.sayfaa.ToString();
            string sayfa4 = Mousepad2.sayfaa4.ToString();
            string sayfa5 = Monitor2.sayfaa5.ToString();
            string sayfa6 = OyuncuKoltugu2.sayfaa6.ToString();
            label4.Text = sayi.ToString();

            if (sayi == 0)
            {
                label4.Visible = false;
                label5.Visible = false;
                if (sayfa == "1")
                {
                    System.Diagnostics.Process.Start(link);
                    this.Hide();
                }
                else if (sayfa2 == "2")
                {
                    System.Diagnostics.Process.Start(link2); 
                    this.Hide();

                }
                else if (sayfa3 == "3")
                {
                    System.Diagnostics.Process.Start(link3);
                    this.Hide();

                }
                else if (sayfa4 == "4")
                {
                    System.Diagnostics.Process.Start(link4);
                    this.Hide();

                }
                else if (sayfa5 == "5")
                {
                    System.Diagnostics.Process.Start(link5);
                    this.Hide();

                }
                else if (sayfa6 == "6")
                {
                    System.Diagnostics.Process.Start(link6);
                    this.Hide();

                }
            }
        }

      
    }
}
