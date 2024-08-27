using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_11_21
{
    public class property_islem
    {
        private int y;          //bu satirda yapilan islem paketleme islemidir.

        public int YinDegeri     //property ve paketlen kisim ayni veri turunden olmalidir.
        {
            set
            {
                if (value < 0)
                    y = 0;
                else
                    y = value;

            }
            get
            {
                return y;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            property_islem _pi = new property_islem();
            _pi.YinDegeri=154;
            Console.WriteLine(_pi.YinDegeri);
            Console.ReadKey();
        }
    }
}
