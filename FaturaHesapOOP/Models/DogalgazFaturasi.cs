using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesapOOP.Models
{
    public class DogalgazFaturasi : FaturaBase
    {
        private const decimal dogalgazTuketimBedeli = 5M;
        public DogalgazFaturasi() 
        {
            this.birimFiyat = 3M;
        }
        public DogalgazFaturasi(decimal birimFiyat):base(birimFiyat)
        {

        }
        public override decimal Hesapla()
        {
            decimal birimToplam=KullanımMiktarı*this.birimFiyat;
            decimal vergiliToplamTutar = birimToplam + dogalgazTuketimBedeli;
            return vergiliToplamTutar;
        }
    }
}
