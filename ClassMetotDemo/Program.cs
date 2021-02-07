using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriName = "Ahmet";
            musteri1.MusteriId = 1;
            musteri1.MusteriBalance = 250.54;
            musteri1.MusteriAge = 24;

            Musteri musteri2= new Musteri();
            musteri2.MusteriName = "Eren";
            musteri2.MusteriId = 2;
            musteri2.MusteriBalance = 23.2;
            musteri2.MusteriAge = 18;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriName = "Berkcan";
            musteri3.MusteriId = 3;
            musteri3.MusteriBalance = 69420.31;
            musteri3.MusteriAge = 52;

            Musteri musteri4 = new Musteri();
            musteri4.MusteriName = "Fatma";
            musteri4.MusteriId = 4;
            musteri4.MusteriBalance = 893.37;
            musteri4.MusteriAge = 16;

            Musteri musteri5 = new Musteri();
            musteri5.MusteriName = "Elif";
            musteri5.MusteriId = 5;
            musteri5.MusteriBalance = 259.42;
            musteri5.MusteriAge = 26;
            //fuck
            MusteriManager m1 = new MusteriManager();
            m1.FirstActions(new Musteri());

        }
    }
}
