﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    public struct SPonto {
        public int X;
        public int Y;
    }
    public class CPonto {
        public int X;
        public int Y;
    }
    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 2 };
            SPonto copiaPonto1 = ponto1; // Atribuição por VALOR!
            ponto1.X = 3;

            Console.WriteLine($"Ponto 1 X:{ponto1.X}");
            Console.WriteLine($"Copia Ponto 1 X:{copiaPonto1.X}");

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; // Atribuição por REFERÊNCIA!
            ponto2.X = 4;

            Console.WriteLine($"Ponto 2 X:{ponto2.X}");
            Console.WriteLine($"Copia Ponto 2 X:{copiaPonto2.X}");
        }
    }
}
