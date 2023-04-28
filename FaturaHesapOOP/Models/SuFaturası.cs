using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesapOOP.Models
{
    public class SuFaturası : FaturaBase
    {
        private const decimal suTuketimVergisi = 0.5M;

        public SuFaturası() 
        {
            this.birimFiyat = 0.75M;
        }
        public SuFaturası(decimal birimFiyat):base(birimFiyat)
        {

        }
        public override decimal Hesapla()
        {
            decimal birimToplam = KullanımMiktarı * this.birimFiyat;
            decimal vergiToplamTutar = birimToplam + suTuketimVergisi;
            return vergiToplamTutar;
        }
    }
}
