using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg1
{
    //PROPERTY UYGULAMASI.
    public class MatematikIslemler
    {
        private double sayi1;       
        private double sayi2;

        public MatematikIslemler(double s1,double s2)    //contructor tanımladık.
                                                         //sayi1 = s1;    
                                                         ////sayi sayi1 ve sati2 böyle atanırsa 0 dan küçük değerler girebilir.
                                                         //sayi2 = s2;
        {
            Sayi1 = s1;
            Sayi2 = s2;
        }
        public double Sayi1    //sayi1 değişkeni için bir property tanımlandı.
        {
            get
            {
                return sayi1;
            }
            set
            {
                if (value <= 0)
                    sayi1 = 0;
                else
                    sayi1 = value;
            }
        }
        public double Sayi2    //sayi2 değişkeni için bir property tanımlandı.
        {
            get
            {
                return sayi2;
            }
            set
            {
                if (value <= 0)
                    sayi2 = 0;
                else
                    sayi2 = value;
            }
        }
        public double Topla       //burda yeni bir property tanımlandı.Sadece get olduğu olduğu için read only (okuma) yapacaktır.
        {
            get
            {
                return sayi1 + sayi2;
            }
        }

        public double ToplaYordam()   //property olarak tanımlananlar aynı ismi almaz.
        {
            return sayi1 + sayi2;
        }
        public double FarkYordam()
        {
            return sayi1 - sayi2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MatematikIslemler nesne1 = new MatematikIslemler(-40,20);
            Console.WriteLine(nesne1.Topla);
            MatematikIslemler nesne2 = new MatematikIslemler(13, 9);
            nesne2.Sayi1 = 55;
            nesne2.Sayi2 = 33;
            Console.WriteLine("sayi= {0},sayi2= {1},toplam= {2},fark= {3},", nesne2.Sayi1, nesne2.Sayi2, nesne2.ToplaYordam(), nesne2.FarkYordam());

        }
    }
}
