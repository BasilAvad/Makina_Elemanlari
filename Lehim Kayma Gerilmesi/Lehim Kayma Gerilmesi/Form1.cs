using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehim_Kayma_Gerilmesi
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
                double F = Convert.ToDouble(this.F_Tbx.Text);
                double S = Convert.ToDouble(this.S_Tbx.Text);
                double L = Convert.ToDouble(this.L_Tbx.Text);
                double Lehim = Convert.ToDouble(this.Lehim_Tbx.Text);
                double Uzun = Convert.ToDouble(this.Uzun_Tbx.Text);

                double M = ((F * Uzun) / (1000));
                İleriMoment_Tbx.Text = M.ToString();

                double D = Math.Sqrt(((2 * M * 1000 * S) / (Lehim * Math.PI * L)));

                Cap_Tbx.Text = D.ToString();
                double Alan = (Math.Pow(D, 2) * Math.PI * L);
                Alan_Tbx.Text = Alan.ToString();
            }
            catch (Exception)
            {

                Console.WriteLine("Bütün sarı alanlar (zorunlu) doldurmanız gerekmektedir.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Tbx.Text = " ";
           S_Tbx.Text=" ";
            L_Tbx.Text = " ";
            Lehim_Tbx.Text = " ";
            Uzun_Tbx.Text = " ";
            İleriMoment_Tbx.Text = " ";
            Cap_Tbx.Text = " ";
            Alan_Tbx.Text = " ";
        }
    }
}
