    using System;
    using System.Globalization;

    namespace exercicio_001
    {
        class Program
        {
           static void Main(string[] args)
            {
               string produto1 = "Computador";
               string produto2 = "Mesa de escritorio";
               
               byte idade = 30;
               int codigo = 5290;
               char genero = 'M';
               
               double preco1 = 2100.0;
               double preco2 = 650.50;
               double medida = 53.234567;

               Console.WriteLine("Produtos:");
               Console.WriteLine(produto1 + ", cujo preço é $ " + preco1.ToString("F2") );
               Console.WriteLine(produto2 + ", cujo o preço é $ " + preco2.ToString("F2")+ "\n\n");
               Console.WriteLine("Registro: " + idade + " anos de idade, " + " código " + codigo + " e genero: " + genero + "\n\n");
            }
        }
    }
    

    