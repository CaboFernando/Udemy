using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo o preço é $ " + preco1.ToString("f2"));
            Console.WriteLine(produto2 + ", cujo o preço é $ " + preco2.ToString("f2"));
            Console.WriteLine();
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("f8"));
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("f3"));
            Console.WriteLine("Separador decimal invarian culture: " + medida.ToString("f3").Replace(",", ".")) ;
            Console.ReadKey();
        }
    }
}
