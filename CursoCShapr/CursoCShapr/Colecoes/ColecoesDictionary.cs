using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2019, "Vingadores Ultimato");
            filmes.Add(2021, "Arcane");
            filmes.Add(2022, "Galatick");
            filmes.Add(2023, "Mario Bros, o Filme");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2019: " + filmes[2019]);
                Console.WriteLine("2019: " + filmes.GetValueOrDefault(2019));
            }

            Console.WriteLine(filmes.ContainsValue("Amnésia"));

            Console.WriteLine($"Removeu? {filmes.Remove(2019)}");

            filmes.TryGetValue(2020, out string filmes2020);
            Console.WriteLine($"Filme {filmes2020}!");

            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }

            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}.");
            }

        }

    }
}
