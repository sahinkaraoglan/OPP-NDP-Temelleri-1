using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Uye
    {
        private string[] Uyeler = { "metin", "ali", "feyyaz" };
        public string this[int Indeks]
        {
            get
            {
                if(Indeks<0||Indeks>=Uyeler.Length)
                {
                    return null;
                }
                else
                {
                    return Uyeler[Indeks];
                }
            }
            set
            {
                if (!(Indeks < 0 || Indeks >= Uyeler.Length))
                    Uyeler[Indeks] = value;
            }
        }
        public int uzunluk
        {
            get { return Uyeler.Length; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uye _u = new Uye();
            Console.WriteLine(_u[0]);
            _u[0] = "metin";
            Console.WriteLine(_u[0]);
            Console.WriteLine(_u.uzunluk);
            Console.ReadLine();
        }
    }
}
