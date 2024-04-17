using System;

namespace Conversão_metrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Double valor, cm, mm;

            Console.Write("Digite um valor em metros: ");
            valor = Convert.ToDouble(Console.ReadLine());
            cm = valor * 100;
            mm = valor * 1000; 
            //pq no escuro nao tem bugs

            Console.WriteLine("O valor em centímetros é : " + cm);
            Console.WriteLine("O valor em milímitros é : " + mm);
            Console.ReadKey();
        }
    }
}
