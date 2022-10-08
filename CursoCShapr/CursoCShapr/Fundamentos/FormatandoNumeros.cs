using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));// 1 casa depois da virgula
            Console.WriteLine(valor.ToString("C"));// Moeda
            Console.WriteLine(valor.ToString("P"));// Porcentagem x100
            Console.WriteLine(valor.ToString("#.##"));// 2 casas depois da virgula

            CultureInfo cultura = new CultureInfo("pt-br");// Coloca a cultura do pais desejado
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));// Adiciona a quantidade necessaria de 0 para chegar no numero de casas desejado
        }
    }
}
