using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    class LINKQ2 {

        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno(){Nome = "Pedro", Idade = 24, Nota = 8.0},
                new Aluno(){Nome = "Vincy", Idade = 26, Nota = 7.4},
                new Aluno(){Nome = "Bia", Idade = 27, Nota = 9.0},
                new Aluno(){Nome = "Teo", Idade = 19, Nota = 6.8},
                new Aluno(){Nome = "Ana", Idade = 22, Nota = 5.1},
                new Aluno(){Nome = "Lia", Idade = 29, Nota = 10},
                new Aluno(){Nome = "Tom", Idade = 30, Nota = 2.4}
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome}{pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));
            if (fulano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota.Equals("Sicrano"));
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente!");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatarioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatarioNotas);

            var mediaDaTurma = alunos.Average(alunos => alunos.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
