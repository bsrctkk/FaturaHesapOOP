using FaturaHesapOOP.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaHesapOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(FaturaTip)))
            {
                cmbxFaturaTip.Items.Add(item);
            }

            //SuFaturası su = new SuFaturası();
            //su.IlkIndex = int.Parse(txtİlkİndex.Text);
            //su.SonIndex = int.Parse(txtSonIndex.Text);
            //DogalgazFaturasi dogalgaz = new DogalgazFaturasi();
            //dogalgaz.IlkIndex = int.Parse(txtİlkİndex.Text);
            //dogalgaz.SonIndex = int.Parse(txtSonIndex.Text);
            //ElektrikFaturası elektrik = new ElektrikFaturası();
            //elektrik.IlkIndex = int.Parse(txtİlkİndex.Text);
            //elektrik.SonIndex=int.Parse(txtSonIndex.Text);

         


           
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            SuFaturası su = new SuFaturası();
            su.IlkIndex = int.Parse(txtİlkİndex.Text);
            su.SonIndex = int.Parse(txtSonIndex.Text);
            DogalgazFaturasi dogalgaz = new DogalgazFaturasi();
            dogalgaz.IlkIndex = int.Parse(txtİlkİndex.Text);
            dogalgaz.SonIndex = int.Parse(txtSonIndex.Text);
            ElektrikFaturası elektrik = new ElektrikFaturası();
            elektrik.IlkIndex = int.Parse(txtİlkİndex.Text);
            elektrik.SonIndex = int.Parse(txtSonIndex.Text);




            FaturaTip selectedItem = (FaturaTip)cmbxFaturaTip.SelectedItem;

            switch (selectedItem)
            {
                case FaturaTip.Su:
                    decimal sufatura = su.Hesapla();
                    lblOdenecekTutar.Text = sufatura.ToString();  
                    break;
                case FaturaTip.Elektrik:
                    decimal elektrikfatura= elektrik.Hesapla();
                    lblOdenecekTutar.Text= elektrikfatura.ToString();   
                    break;
                case FaturaTip.Doğalgaz:
                    decimal dogalgazfatura = dogalgaz.Hesapla();
                    lblOdenecekTutar.Text=dogalgazfatura.ToString();
                    break;
                default:
                    break;
            }
          
        }
    }
}
