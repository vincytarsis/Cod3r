﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {
            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;


            raio = 5.5;
            // PI = 3.1415

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area + 1000);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45; // só aceita valores positivos
            Console.WriteLine("Idade " + idade );

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gosl " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue; // só armazena valores inteiros
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_000_000_000;
            Console.WriteLine("População Mundial" + populacaoMundial);

            float precoComputador = 1299.99F;
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorDeMercadoApple = 1_000_000_000_000_000.00;  // Mais usado dos reais!
            Console.WriteLine("Valor Apple " + valorDeMercadoApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Bora Bil!!!";
            Console.WriteLine(texto);



        }
    }
}
