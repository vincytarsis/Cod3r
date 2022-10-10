using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executarTrabalho1 = false;
            var executarTrabalho2 = false;

            bool comprouTV50 = executarTrabalho1 && executarTrabalho2;
            Console.WriteLine($"Comprou a TV 50? {comprouTV50}");

            var comprouSorvete = executarTrabalho1 || executarTrabalho2;
            Console.WriteLine($"Comprou o Sorvete? {comprouSorvete}");

            var comprouTv32 = executarTrabalho1 ^ executarTrabalho2;
            Console.WriteLine($"Comprou a TV 32? {comprouTv32}");

            Console.WriteLine($"Mais saudável? {!comprouSorvete}");

        }
    }
}
