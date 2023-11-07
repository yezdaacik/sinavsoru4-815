using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav_soru_4_815
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
           
            Random rnd = new Random();

            lbSayilar.Items.Clear();

            for (int i = 0; i < 20; i++)
            {
                int sayilar = rnd.Next(0, 100);
                lbSayilar.Items.Add(sayilar);

            }
        }

        private void btnSayi_Click(object sender, EventArgs e)
        {
            lbSayilar2.Items.Clear();
            for (int i = 0; i < lbSayilar.Items.Count; i++)
            {
                int sayi = Convert.ToInt32(lbSayilar.Items[i].ToString());
              
                if (sayi >= 50 && sayi <= 70)
                {
                    lbSayilar2.Items.Add(sayi);
                }
            }
        }
    }
}
