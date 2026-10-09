using System;
using System.Collections.Generic;
using System.Text;

namespace OpsFlow.Console
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }
        public string Pozisyon { get; set; }
        private decimal Maas { get; set; }

        public Personel(int id, string ad, string soyad, string departman, string pozisyon, decimal maas)
        {
            this.Id = id;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Departman = departman;
            this.Pozisyon = pozisyon;
            this.Maas = maas;
        }
    }
}
