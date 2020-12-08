using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehim_Bagları
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
                Double Genislik_Tbxx = Convert.ToDouble(this.Genislik_Tbx.Text);

                Double Kalinlik_Tbx = Convert.ToDouble(this.Kalinlik_Tbx.Text);
                Double Uzunluk_Tbx = Convert.ToDouble(this.Uzunluk_Tbx.Text);
                Double KaymaSiniri_Tbx = Convert.ToDouble(this.KaymaSiniri_Tbx.Text);

                Double StatikYuk_Tbx = Convert.ToDouble(this.StatikYuk_Tbx.Text);
                Double MinimumEmniyet_Tbx = Convert.ToDouble(this.MinimumEmniyet_Tbx.Text);
                Double Alan = (Uzunluk_Tbx * Genislik_Tbxx) / (2);
                Alan_Tbx.Text = Alan.ToString();
                Double SigmeEmniyet = (KaymaSiniri_Tbx) / (MinimumEmniyet_Tbx);
                Sigme_EM_Tbx.Text = SigmeEmniyet.ToString();
                Double İstenelenSigme = (StatikYuk_Tbx / Alan);
                İstenelenSigme_Tbx.Text = İstenelenSigme.ToString();
                Double SigmaCekme = (StatikYuk_Tbx) / (Genislik_Tbxx*Kalinlik_Tbx);
                SigmeCekme_Tbx.Text = SigmaCekme.ToString();
                
                Double KopmaDayanımı_Tbx1 = Convert.ToDouble(this.KopmaDayanımı_Tbx.Text);
                Double AkımaDayanımı_Tbx1 = Convert.ToDouble(this.AkımaDayanımı_Tbx.Text);
                Double kopmaKarsiEmni_Tbx1 = Convert.ToDouble(this.kopmaKarsiEmni_Tbx.Text);
                Double SigmeEmniyett = (KopmaDayanımı_Tbx1 / kopmaKarsiEmni_Tbx1);
                SigmeEmniyet_Tbx.Text = SigmeEmniyett.ToString();

                Double YeniAlan = (StatikYuk_Tbx / SigmeEmniyett);
                YeniAlan_Tbx.Text = YeniAlan.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Zorunlu Sarı Alan Boş Brakmayın");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
