using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_VT_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] empleados = new string[5];
            double[] sueldos = new double[5];
            int maxIndex = 0;

            for(int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine("Escribe el nombre del empleado {0}", i);
                empleados[i] = Console.ReadLine();
                Console.WriteLine("Escribe el sueldo del empleado {0}", i);

                do
                {
                    sueldos[i] = double.Parse(Console.ReadLine());

                } while (sueldos[i] <= 0);

            }

            for (int index = 1; index < sueldos.Length; index++)
            {
                if(sueldos[maxIndex] < sueldos[index])
                {
                    maxIndex = index;
                }

            }

            Console.WriteLine("El mayor sueldo lo cobra: {0}", empleados[maxIndex]);
            Console.WriteLine("Y es de: {0}", sueldos[maxIndex]);



        }
    }
}
