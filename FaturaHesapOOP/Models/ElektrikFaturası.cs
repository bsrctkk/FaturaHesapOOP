using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesapOOP.Models
{
    public class ElektrikFaturası : FaturaBase
    {
        private const decimal enerjiTuketimVergisi = 3;
        public ElektrikFaturası()
        {
            this.birimFiyat = 1.25M;
        }

        public ElektrikFaturası(decimal birimFiyat):base(birimFiyat) 
        {
            
        }
        public override decimal Hesapla()
        {
            decimal birimToplam=KullanımMiktarı*this.birimFiyat;
            decimal vergiliToplamTutar = birimToplam + enerjiTuketimVergisi;
            return vergiliToplamTutar;
        }
    }
       
    
}
