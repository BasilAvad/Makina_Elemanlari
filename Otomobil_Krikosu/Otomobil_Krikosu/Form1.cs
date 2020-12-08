using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomobil_Krikosu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double Max_kaldırmaMesafe_Tbx = Convert.ToDouble(this.Max_kaldırmaMesafe_Tbx.Text);
                Double Max_kaldırmaYuk_Tbx = Convert.ToDouble(this.Max_kaldırmaYuk_Tbx.Text);
                Double MilimCapi_Tbx = Convert.ToDouble(this.MilimCapi_Tbx.Text);
                Double St_Tbx = Convert.ToDouble(this.St_Tbx.Text);

                Double Alan = (Math.PI * Math.Pow(MilimCapi_Tbx, 2)) / 4;
                Alan_Tbx.Text = Alan.ToString();
                Double Sigma = Max_kaldırmaYuk_Tbx / Alan;
                Sigma_b_Tbx.Text = Sigma.ToString();
                Double J = (Math.PI * Math.Pow(MilimCapi_Tbx, 4)) / 64;
                J_Tbx.Text = J.ToString();
                double İ = Math.Sqrt(J / Alan);
                İ_Tbx.Text = İ.ToString();
                Double S = 2 * Max_kaldırmaMesafe_Tbx;
                S_Tbx.Text = S.ToString();
                Double Narenlik = S / İ;
                Narenlik_Tbx.Text = Narenlik.ToString();

                

            }
            catch (Exception)
            {
                MessageBox.Show("Bütün Zorunlu Sarı Alanları Doldurmanız gerekmektedir.");


            }
        }
    }
}
