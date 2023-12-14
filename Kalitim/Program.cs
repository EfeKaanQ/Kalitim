using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Ogretmen ogr = new Ogretmen
                {
                    Ad = "EFE KAAN ",
                    Soyad = "KAZGAN ",
                    Brans = "Matematik",
 };
                OkulPersoneli per = ogr; 
                Console.WriteLine(per.Ad);
                Console.WriteLine(per.Soyad);
                

            }
        }
    }
    }
    public class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    public class Ogretmen : OkulPersoneli
    {
        public string Brans { get; set; }
    }

