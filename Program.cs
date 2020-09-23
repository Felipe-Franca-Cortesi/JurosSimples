using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("-----Juros Simples-----");
            
            Console.Write("Capital (R$).......: ");
            decimal capital = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Taxa de juros (%)..: ");
            decimal taxaJuros = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Tempo (meses)......: ");
            decimal tempo = Convert.ToDecimal(Console.ReadLine());

            decimal j = capital * tempo; 
            decimal porcentagem = (taxaJuros / 100) * j;
            decimal m = capital + porcentagem; 

            Console.WriteLine($"Juros (R$).....:{porcentagem}");
            Console.WriteLine($"Montagem (R$)..:{m}");
        }
    }
}
