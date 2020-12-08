using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bindirme_Lehiminde_Kayma_Gerilmesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HESAPLA_Click(object sender, EventArgs e)
        {
            try
            {
                Double Staatik = Convert.ToDouble(this.Statik_Tbx.Text);
                Double tork = Convert.ToDouble(this.Tork_Tbx.Text);
                Double cap = Convert.ToDouble(this.Cap_Tbx.Text);
                Double kat = Convert.ToDouble(this.Kat_Tbx.Text);

                Double Kayma_gerilm = tork / kat;
                KaymaGerilme_Tbx.Text = Kayma_gerilm.ToString();

                Double uzunluk = (Staatik / Math.PI * Kayma_gerilm) * (0.001);
                Uzunluk_Tbx.Text = uzunluk.ToString();
                Double Alan = Math.PI * cap * uzunluk;
                Double Sayi = uzunluk;
                Alan_Tbx.Text = Alan.ToString();
                if (uzunluk == Sayi)
                {
                    Math.Round(Sayi);
                    string V = Sayi.ToString();

                    Console.WriteLine($"Buna gore : L = ", Sart_tbx.Text = V + "mm olmak yeterli olacaktır."); ;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bütün Zorunlu Sarı Alanları Doldurmanız gerekmektedir.");
            }
            
        }
    }
}
