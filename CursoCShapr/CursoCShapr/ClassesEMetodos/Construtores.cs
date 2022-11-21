using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabrincante, int ano) {
            Modelo = modelo;
            Fabricante = Fabricante;
            Ano = ano;
        }

        public Carro() {

        }

    }
    class Construtores {

        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2022;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            var carro2 = new Carro("Renegate", "Jeep", 2022);
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3 = new Carro() {
                Fabricante = "Wolskvagen",
                Modelo = "Golf",
                Ano = 2022
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
