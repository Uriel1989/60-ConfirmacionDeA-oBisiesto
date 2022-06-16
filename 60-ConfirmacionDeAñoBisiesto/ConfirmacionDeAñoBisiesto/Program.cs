using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfirmacionDeAñoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 30;

            Console.WriteLine("Aqui determinaremos si un año es bisiesto o no, ingrese el año en cuestion:");
            int año = Convert.ToInt32(Console.ReadLine());


            while (año == 1700 || año == 1800 || año == 1900 || año == 1900 || año == 2100 || año == 2200 || año == 2300)
            {
               
                Console.WriteLine("Año no valido, re-ingrese:");
                año = Convert.ToInt32(Console.ReadLine());
            }
            if (año % 4 == 0)
            {
                Console.WriteLine("Es un año bisiesto");
            }

            Console.ReadKey();
        }
    }
}
