using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento {
    public class SubCelebridade {

        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herança
        protected string CorDoOlho = "Preto";

        // Mesmo Projeto (Assembly)
        internal ulong NumeroCelular = 5511999999;

        // Herança ou mesmo Projeto
        protected internal string JeitoDeFalar = "Usos muitas gírias";

        // Mesma class ou herança no mesmo projeto
        private protected string SegredoFamilia = "Bla bla";

        // Private é o padrão
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("SubCelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
