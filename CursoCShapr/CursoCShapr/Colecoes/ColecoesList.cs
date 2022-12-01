﻿using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using Syste.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }
    class ColecoesList {
        public static void Executar() {
            var livro = new Produto(" God of War", 350);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto>() {
                new Produto(" Martelo", 45.9),
                new Produto(" Arco-Flexa", 158.3),
                new Produto(" Laminas do Caos", 999.9)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
               // Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}
