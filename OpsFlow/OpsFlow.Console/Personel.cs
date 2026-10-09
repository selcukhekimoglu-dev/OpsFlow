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
        public decimal Maas { get; private set; }

        public Personel(int id, string ad, string soyad, string departman, string pozisyon, decimal maas)
        {
            this.Id = id;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Departman = departman;
            this.Pozisyon = pozisyon;
            if (maas > 0)
            {
                this.Maas = maas;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(maas), "Maaş sıfırdan büyük olmalıdır.");
            }
        }
        public void MaasGuncelle(decimal yeniMaas)
        {
            if (yeniMaas > 0)
            {
                this.Maas = yeniMaas;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    nameof(yeniMaas),
                    "Maaş sıfırdan büyük olmalıdır.");
            }
        }
    }
}