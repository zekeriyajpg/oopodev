using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class oop
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        public oop(string ad, string soyad, DateTime dogumTarihi)
        {
            Ad = ad;
            Soyad = soyad;
            DogumTarihi = dogumTarihi;
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}";
        }
    }
}
