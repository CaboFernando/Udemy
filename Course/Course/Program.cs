using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Saída de Dados
            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine(produto1 + ", cujo o preço é $ " + preco1.ToString("f2"));
            //Console.WriteLine(produto2 + ", cujo o preço é $ " + preco2.ToString("f2"));
            //Console.WriteLine();
            //Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            //Console.WriteLine();
            //Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("f8"));
            //Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("f3"));
            //Console.WriteLine("Separador decimal invarian culture: " + medida.ToString("f3").Replace(",", ".")) ;
            //Console.ReadKey();
            #endregion

            #region Entrada de Dados
            string frase, x, y, z, a, b, c;

            frase = Console.ReadLine();
            x = Console.ReadLine();
            y = Console.ReadLine();
            z = Console.ReadLine();
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            #endregion
        }
    }
}
