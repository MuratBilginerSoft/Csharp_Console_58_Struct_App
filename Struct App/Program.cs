using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_App
{
    class Program
    {
        struct PersonelBilgisi
        {
            public string PersonelID; // 12344535342
            public string PersonelAd;
            public string PersonelSoyadı;
            public string Şifre;
        }

        static void Main(string[] args)
        {
            PersonelBilgisi PB = new PersonelBilgisi();

            PB.PersonelID = "12345";
            PB.PersonelAd = "Murat";
            PB.PersonelSoyadı = "Bilginer";
            PB.Şifre = "12345";

            Console.WriteLine(PB.PersonelID);

            Console.ReadKey();
        }
    }
}
