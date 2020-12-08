using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silindirik_Su_Deposu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double Silindir_Tbxx = Convert.ToDouble(this.Silindir_Tbx.Text);
                Double Kutle_Tbxx = Convert.ToDouble(this.Kutlesi_Tbx.Text);
                Double BYukseklik_Tbxx = Convert.ToDouble(this.BYukseklik_Tbx.Text);
                Double St_Tbxx = Convert.ToDouble(this.St_Tbx.Text);
                Double Dis_Cap_Tbxx = Convert.ToDouble(this.Dis_Cap_Tbx.Text);
                Double İC_Cap_Tbxx = Convert.ToDouble(this.İC_Cap_Tbx.Text);
                Double E_Tbxx = Convert.ToDouble(this.E_Tbx.Text);

                Double Alan = (Math.PI )/(4)* (Math.Pow(Dis_Cap_Tbxx,2)-Math.Pow(İC_Cap_Tbxx,2));
                Alan_Tbx.Text = Alan.ToString();
                Double J = (Math.PI) / (64) * (Math.Pow(Dis_Cap_Tbxx, 4) - Math.Pow(İC_Cap_Tbxx, 4));
                J_Tbx.Text = J.ToString();

                double İ = Math.Sqrt(J / Alan);
                İ_Tbx.Text = İ.ToString();
                Double S = 2 * BYukseklik_Tbxx;
                S_Tbx.Text = S.ToString();
                Double Narenlik = S / İ;
                Narinlik_Tbx.Text = Narenlik.ToString();

                Double Burkulma = (E_Tbxx * J * Math.Pow(Math.PI, 2))/Math.Pow( S,2);
                Burkulma_Tbx.Text = Burkulma.ToString();

                Double SuKutlesi = (Burkulma - (Kutle_Tbxx * 9.81));
                Su_Kutlesi_Tbx.Text = SuKutlesi.ToString();
                Double SuYuksekligi = (4 * SuKutlesi)/ (Math.PI * Math.Pow(Silindir_Tbxx, 2) * 1000 * 9.81);
                L_Tbx.Text = SuYuksekligi.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Bütün Zorunlu Sarı Alanları Doldurmanız gerekmektedir.");


            }
        }
    }
}
