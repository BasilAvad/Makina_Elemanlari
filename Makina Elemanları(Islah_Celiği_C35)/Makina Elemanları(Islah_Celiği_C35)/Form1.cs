using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makina_Elemanları_Islah_Celiği_C35_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double F_Tbcx = Convert.ToDouble(this.F_Tbx.Text);
                Double F2_Tbx = Convert.ToDouble(this.F2_Tbx.Text);
                Double L_Tbx = Convert.ToDouble(this.L_Tbx.Text);
                Double Cap_Tbx = Convert.ToDouble(this.Cap_Tbx.Text);
                Double B1_Tbx = Convert.ToDouble(this.B1_Tbx.Text);

                Double Beta_Tbx = Convert.ToDouble(this.Beta_Tbx.Text);
                Double Puruz_Tbx = Convert.ToDouble(this.Puruz_Tbx.Text);
                Double W_3 = Convert.ToDouble(this.F2_Tbx.Text);
                Double Mesned = Convert.ToDouble(this.Bolme_Tbx.Text);

                Double SEM = (F_Tbcx * L_Tbx) / (Mesned);
                SEM_Tbx.Text = SEM.ToString();
                Double DEM = (F2_Tbx * L_Tbx) / (Mesned);
                DEM_Tbx.Text = DEM.ToString();
                Double Atalet = (Math.PI * Math.Pow(Cap_Tbx, 4)) / (64);
                Atalet_Tbx.Text = Atalet.ToString();
                Double EG_SEM_Tb = (SEM * (Cap_Tbx / 2)) / (Atalet);
                EG_SEM_Tbx.Text = EG_SEM_Tb.ToString();
                Double EG_SDM_Tb = (DEM * (Cap_Tbx / 2)) / (Atalet);
                EG_DGM_Tbx.Text = EG_SDM_Tb.ToString();

                Double SigmaAkma = Convert.ToDouble(this.SigmaAkma_Tbx.Text);
                Double SigmaT_D = Convert.ToDouble(this.Sigma_TD_Tbx.Text);
                Double SA = (Puruz_Tbx * SigmaAkma);
                SA_Sonuc_Tbx.Text = SA.ToString();
                Double STD = (Puruz_Tbx * SigmaT_D);
                S_TD_Sonuc.Text = STD.ToString();

                Double SigmaSTD = (B1_Tbx / Beta_Tbx) * STD;
                Sigma_ŞTD_Tbx.Text = SigmaSTD.ToString();


                Double SigmaSG = (B1_Tbx / Beta_Tbx) * 190;
                Sigma_ŞG_Tbx.Text = SigmaSG.ToString();

                Double SigmaESU = (EG_SEM_Tb + EG_SDM_Tb);
                SigmaESU_Tbx.Text = SigmaESU.ToString();

                Double Tan_Alfa = (SigmaESU / EG_SEM_Tb);
                TanAlfa_Tbx.Text = Tan_Alfa.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Bütün Zorunlu Sarı Alanları Doldurmanız gerekmektedir.");

               
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F_Tbx.Text = "";
            F2_Tbx.Text = "";
            L_Tbx.Text = " ";
            Cap_Tbx.Text = "";
            Beta_Tbx.Text = "";
            Puruz_Tbx.Text = "";
            F2_Tbx.Text = "";
            Bolme_Tbx.Text = "";
            SEM_Tbx.Text = "";
            DEM_Tbx.Text = "";
            Atalet_Tbx.Text = "";
            EG_SEM_Tbx.Text = "";
            EG_DGM_Tbx.Text = "";
            SA_Sonuc_Tbx.Text = "";
            S_TD_Sonuc.Text = "";
            Sigma_ŞTD_Tbx.Text = "";
            Sigma_ŞG_Tbx.Text = "";
            SigmaESU_Tbx.Text = "";
            TanAlfa_Tbx.Text = "";
        }
    }
}
