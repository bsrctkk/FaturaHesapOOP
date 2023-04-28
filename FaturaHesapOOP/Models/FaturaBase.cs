using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturaHesapOOP.Models
{
    public abstract class FaturaBase
    {
        //sadece kalıtım alan sınıflar protected alanlara ulaşabilir.
        protected decimal birimFiyat;

        public int IlkIndex { get; set; }
        public int SonIndex { get; set;}

        public int KullanımMiktarı
        {
            get
            {
                return Math.Abs(this.SonIndex - this.IlkIndex);
            }
        }

        //Kullanıcı formdan birim fiyat girerse.
        public FaturaBase(decimal birimFiyat) 
        {
            this.birimFiyat = birimFiyat;
        }

        public FaturaBase() 
        {
            
        }
        public abstract decimal Hesapla();

    }
}
