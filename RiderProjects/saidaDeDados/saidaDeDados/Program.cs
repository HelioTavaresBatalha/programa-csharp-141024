using System;
using System.Globalization;

namespace saidaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char genero ='M';
           int idade = 32;
           double saldo = 10.35874;
           string nome = "Hélio Batalha";

           Console.WriteLine("O seu nome é: " + nome + "a sua idade é " + idade + " anos " + " genero " + genero + " saldo disponivel é ,  " + saldo.ToString("F2") );
           Console.WriteLine("O seu saldo é: " + saldo.ToString("F2", CultureInfo.InvariantCulture) );
        }
    }
}