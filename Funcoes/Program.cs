using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int valor1;

            Console.Write("Inclua o primeiro valor: ");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inclusa o segundo valor: ");
            valor1 = Convert.ToInt32(Console.ReadLine());

            int resultado;
            resultado = valor + valor1;

            Console.WriteLine("O valor da soma foi: " + resultado);

            double resultado1;
            resultado1 = valor - valor1;

            Console.WriteLine("O valor da divisão foi: " + resultado1);

            Console.ReadLine();
        }
    }
}
