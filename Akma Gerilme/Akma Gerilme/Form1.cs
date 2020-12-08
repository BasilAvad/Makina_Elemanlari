using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akma_Gerilme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ;
            try
            {
                Double Sidet_Tbx = Convert.ToDouble(this.Sidet_Tbx.Text);
                Double Sigma_A_K_Tbxx = Convert.ToDouble(this.Sigma_A_K_Tbx.Text);
                Double E = Convert.ToDouble(this.E_Tbx.Text);

                Double N = Convert.ToDouble(this.N_Tbx.Text);
                Double Yukseklik = Convert.ToDouble(this.Yukseklik_Tbx.Text);
                Double Geneslik = Convert.ToDouble(this.Geneslik_Tbx.Text);
                Double L = Convert.ToDouble(this.L_Tbx.Text);
                Double S_ = Convert.ToDouble(this.S_Tbx.Text);
                Double Sigma1_Tbx = Convert.ToDouble(this.Sigma1_Tbx.Text);
                Double Sigma2_Tbx = Convert.ToDouble(this.Sigma2_Tbx.Text);


                Double J = (Yukseklik * Math.Pow(Geneslik, 3)) / 12;
                J_Tbx.Text = J.ToString();
                Double Alan = (Geneslik * Yukseklik);
                A_Tbx.Text = Alan.ToString();
                Double i = Math.Sqrt(J / Alan);
                İ_Tbx.Text = i.ToString();
                Double S = L * S_;
                S_Sonuc_Tbx.Text = S.ToString();
                Double Narin = (S / i);
                Narinlik_Derece_Tbx.Text = Narin.ToString();
                Double SinirNarin = Math.Sqrt((Math.Pow(3.141592653,2) * E) / Sigma_A_K_Tbxx);
                Sinir_Narinlik_Derece_Tbx.Text = SinirNarin.ToString();
                if (Narin < SinirNarin)
                {
                    string D = "Elastik olmayan burkulma soz konusudur";
                    Sart_Tbx.Text = D;
                }
                else
                {
                    string DD = "Elastik burkulma soz konusudur";
                    Sart_Tbx.Text = DD;
                }
                Double Sigma = (Sigma1_Tbx - Sigma2_Tbx * Narin);
                Sigma_Sonuc_Tbx.Text = Sigma.ToString();
                Double FF =Alan * Sigma_A_K_Tbxx *  (1 - ((Sigma_A_K_Tbxx * Math.Pow(Narin, 2))/ (4 *E* Math.Pow(3.141592653, 2))));
                F_Tbx.Text = FF.ToString();
                Double Emniyet = (FF / Sidet_Tbx);
                Emniyet_Tbx.Text = Emniyet.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Bütün Zorunlu Sarı Alanları Doldurmanız gerekmektedir.");
            }
            
        }
    }
}
