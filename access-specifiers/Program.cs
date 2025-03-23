using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_specifiers
{
    class Kullanici
    {
        private string adSoyad;
        private int yas;
        public string Email { get; set; }

        public string GetAdSoyad()
        {
            return adSoyad;
        }

        public void SetAdSoyad(string ad)
        {
            adSoyad = ad;
        }

        public int GetYas()
        {
            return yas;
        }

        public void SetYas(int kullaniciYasi)
        {
            if (kullaniciYasi > 0)
            {
                yas = kullaniciYasi;
            }
            else
            {
                Console.WriteLine("Yaş 0'dan büyük olmalı");
            }
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad Soyad: {adSoyad}\nYaş: {yas}\nE-Posta: {Email}");
        }
    }
    public class Program
    {
        static void Main()
        {
            Kullanici kullanici = new Kullanici();
            kullanici.SetAdSoyad("Abdullah Aksoy");
            kullanici.SetYas(21);
            kullanici.Email = "abdusaksoy052@gmail.com";

            kullanici.BilgileriGoster();
        }
    }
}
