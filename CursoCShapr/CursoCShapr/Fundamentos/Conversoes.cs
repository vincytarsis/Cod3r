using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;// Conversão Explicita: Não preciso informar
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;// COnversão Inplicita: Preciso informar
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeString}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"Resultado: {numero1}");

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine() , out int numero2);
            Console.WriteLine($"Resultado: {numero2}");

        }
    }
}
