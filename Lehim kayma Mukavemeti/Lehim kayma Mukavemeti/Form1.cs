using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehim_kayma_Mukavemeti
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
                Double Kuvvet = Convert.ToDouble(this.Kuvvet_Tbx.Text);
                Double B = Convert.ToDouble(this.B_Tbx.Text);
                Double L = Convert.ToDouble(this.L_Tbx.Text);
                Double Alfa = Convert.ToDouble(this.Alfa_Tbx.Text);
                Double Kayma = Convert.ToDouble(this.kaymaMukav_Tbx.Text);

                Double Alan = B * L + (Math.Pow(L, 2) * Math.Atan(Alfa));
                Alan_Tbx.Text = Alan.ToString();

                Double KaymaGerilmesi = Kuvvet / Alan;
                KaymaGerilmesi_Tbx.Text = KaymaGerilmesi.ToString();

                Double KaymaMukavemeti = Kayma * KaymaGerilmesi;
                S_Tbx.Text = KaymaMukavemeti.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Bütün Zorunlu Sarı Alanları Doldurmanız gerekmektedir.");
            }
        
        }
    }
}
