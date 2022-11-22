using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    
    public class CalculadoraEstatica {

        // Método de Classe ou Método Estatico!!!
        public static int Multiplicar(int a, int b) {
            return a * b;
        }
        // Métodos de instância!!!
        public int Somar(int a, int b) {
            return a + b;
        }
    }
    class MetodosEstaticos {
        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(3, 5);
            Console.WriteLine($"Resultado: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(8, 8));

        }
    }
}
