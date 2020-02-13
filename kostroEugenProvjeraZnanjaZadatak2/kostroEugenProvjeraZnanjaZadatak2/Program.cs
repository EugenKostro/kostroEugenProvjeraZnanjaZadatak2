using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            string unos;
            Console.WriteLine("Upiši 3 nasumična broja: ");
            unos = Console.ReadLine();
            x = Convert.ToInt32(unos.Substring(0, 2));
            y = Convert.ToInt32(unos.Substring(3, 2));
            z = Convert.ToInt32(unos.Substring(6, 2));
            if(x>y && x > z)
            {
                Console.WriteLine(x);
            }
            if(y>x && y > z)
            {
                Console.WriteLine(y);
            }
            if(z>x && z > y){
                Console.WriteLine(z);
            }
            Console.ReadKey();

        }
    }
}
