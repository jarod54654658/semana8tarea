using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana8tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea semana 8");
            Console.WriteLine("A binario ");
            Console.WriteLine("Ingrese un numero ");
            int dec = Convert.ToInt32(Console.ReadLine());
            string res3 = "";
            while(dec>0)
            {
                if(dec%2==0)
                {
                    res3 = "0" + res3;
                    dec = dec / 2;
                }
                else
                {
                    dec = dec / 2;
                    res3 = "1" + res3;

                }
            }
            Console.WriteLine(res3);



            Console.WriteLine("A hexadecimal");
            Console.WriteLine("ingrese numero ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 16));
            Console.ReadKey();
        }
    }
}
