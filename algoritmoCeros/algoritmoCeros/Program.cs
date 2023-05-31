using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace algoritmoCeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
  

            Int64 num=0;
            Boolean isNumber = true;
            string binary_s;
            do {
                try
                {
                    Console.WriteLine("Digite un número entero: ");
                    num = Convert.ToInt64(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ha ocurrido un error :c");
                    isNumber = false;
                }
            } while (!isNumber); 

            stopWatch.Start();
            binary_s = Convert.ToString(num, 2);
            Console.WriteLine("Binario:"+binary_s);

            Calculations(binary_s);

            stopWatch.Stop();
            Console.WriteLine($"Tiempo: {stopWatch.Elapsed.TotalMilliseconds} ms");

            Console.ReadKey();

            
        }

        public static int Calculations(string binary)
        {
   
            int cont=0;
            int cont_aux = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '0')
                {
                    cont_aux++;
                }
                else
                {
                    cont_aux = 0;
                }

                if (cont_aux >= cont)
                {
                    cont = cont_aux;
                }
            }

            Console.WriteLine("Conjunto maximo:"+cont);
            return cont;

        }
    }


}
