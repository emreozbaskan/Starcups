﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starcups
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kahveler = { "Filtre kahve", "Expresso", "Sütlü Kahve", "Frappaccino", "Mocca", "Su" };
        double[] KahveFiyat = { 10, 10, 15, 20, 18, 5 };
        string[] SiprarisList = new string[0];
        double siparisToplami=0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            for(int i=0;i<6;i++)
            {
                LstKahve.Items.Add(i+1+". "+kahveler[i]+" - "+KahveFiyat[i]+" TL");

            }
            
        }

        private void btnSiparisOnay_Click(object sender, EventArgs e)
        {
            lstSiparisOzeti.Items.Clear();
            Array.Resize(ref SiprarisList,SiprarisList.Length+1);
            SiprarisList[SiprarisList.Length-1] = kahveler[Convert.ToInt32(txtKahveSecim.Text)-1];
            lstSiparisOzeti.Items.Add("Sipariş Sahibi: "+txtAd.Text);
            lstSiparisOzeti.Items.Add("--Siparişler--");
            foreach (var sipraris in SiprarisList)
            {
                lstSiparisOzeti.Items.Add(sipraris);
                
            }
            siparisToplami += (Convert.ToDouble(KahveFiyat[Convert.ToInt32(txtKahveSecim.Text) - 1]));

            lstSiparisOzeti.Items.Add(siparisToplami);
            
        }
    }
}
