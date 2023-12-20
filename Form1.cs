using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortalama_Hesapla_Average_Calculation_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float vize;
        float final;
        float butunleme;
        float ortalama;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            vize = Convert.ToInt32(txtVize.Text);
            final = Convert.ToInt32(txtFinal.Text);

            float vizeYuzdeKirk = (vize * 40) / 100;
            float finalYuzdeAltmis = (final * 60) / 100;

            ortalama = vizeYuzdeKirk + finalYuzdeAltmis;

            if (txtBut.Text != "")
            {
                butunleme = Convert.ToInt32(txtBut.Text);
                float butYuzdeAltmis = (butunleme * 60) / 100;
                ortalama = vizeYuzdeKirk + butYuzdeAltmis;
            }

            lblOrt.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                lblDrm.Text = "Gecti";
            }

            else
            {
                lblDrm.Text = "Kaldi";
            }
        }
    }
}
