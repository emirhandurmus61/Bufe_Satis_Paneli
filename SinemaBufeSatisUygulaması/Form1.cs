using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaBufeSatisUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int su, misir, cay, bilet, toplam;
            su = Convert.ToInt16(txtsu.Text);
            misir = Convert.ToInt16(txtmisir.Text);
            cay = Convert.ToInt16(txtcay.Text);
            bilet = Convert.ToInt16(txtbilet.Text);

            toplam = su*5+misir*15+cay*7+bilet*40;
            lbltoplam.Text=toplam.ToString() + " TL";

            kasatutar = kasatutar + toplam;
            lblkasa.Text = kasatutar.ToString()+ " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsu.Text = "";
            txtmisir.Text = "";
            txtcay.Text = "";
            txtbilet.Text = "";
            lbltoplam.Text = "00 TL";
            txtsu.Focus();

        }
    }
}
