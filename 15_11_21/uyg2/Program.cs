using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg2
{
    //STATİC UYGULAMA
    public class MatematikIslem
    {
        public MatematikIslem()
        {
            Console.WriteLine("ben non static kurucu içindeyim");
        }
        static MatematikIslem()   //static constructorların erişim belirtelici yoktur.
        {
            Console.WriteLine("ben static kurucu içindeyin");
        }
        public int Toplam(int a,int b)
        {
            return a + b;
        }
        public static int ToplaStatik(int a,int b)
        {
            return a + b;
        }
        static class MatematikIslemStatik    //static olmayan bir sınıfın içinde stativ olmayan elemanlar tanımlanmaz.
        {
            public static int Toplam(int a,int b)
            {
                return a + b;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MatematikIslem nesne1 = new MatematikIslem();
            int Toplam = nesne1.Toplam(8, 9);
            Console.WriteLine(Toplam);
            //staticler progrmaın load time ında yükleniyor.
            //static olmayan bir sınıftan static bir elemente ulşmak istiyorsak sınıfın adını kullanabiliriz.
            MatematikIslem.ToplaStatik(5, 2);
            Console.WriteLine(MatematikIslem.ToplaStatik(5, 2));
            MatematikIslem nesne2 = new MatematikIslem();
        }
    }
}
