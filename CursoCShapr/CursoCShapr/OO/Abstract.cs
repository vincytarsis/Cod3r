using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO {

    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Tu ruu ruru ruru...";
        }
    }

    public class Amazon : Celular {
        public override string Assistente() {
            return "Olá Meu nome é Alexia!";
        }
    }

    public class Google : Celular {
        public override string Assistente() {
            return "Ok Google!";
        }
    }
    class Abstract {

        public static void Executar() {
            var celulares = new List<Celular> {
                new Amazon(),
                new Google()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
