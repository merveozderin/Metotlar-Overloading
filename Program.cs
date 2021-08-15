using System;

namespace Metot_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi= "999" ;

            bool sonuc = int.TryParse(sayi, out int outsayi) ;
            if(sonuc)
            {
                Console.WriteLine("Başarılı") ;
                Console.WriteLine(outsayi) ;
            }
            else
            {
                Console.WriteLine("Başarısız") ;
            }

            Metotlar instance = new Metotlar() ;
            instance.toplam(1, 2, out int toplamsonucu) ;
            Console.WriteLine(toplamsonucu) ;

            //Metot Overloading (Aşırı Yükleme )

            int ifade = 999 ;
            instance.ekranayazdir(Convert.ToString(ifade)) ;
            instance.ekranayazdir(ifade) ;
              
            instance.ekranayazdir("Merve ","Özderin") ;

        //Metot İmza
        // metotadı + parametre sayısı + parametre



        }
    }

    class Metotlar
    {
        public void toplam(int a, int b, out int toplam)
        {
            toplam = a+b ;
        }

        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri) ;
        }

        public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        // private void ekranayazdir(int veri)
        // {
        //     Console.WriteLine(veri);
        // }

        //aynı metot için
        // public-public -> overloading
        // public(int)-private(int) -> overloading
        // public(int)-private(string) -> not overloading

        public void ekranayazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2) ;
        }
    }
}
