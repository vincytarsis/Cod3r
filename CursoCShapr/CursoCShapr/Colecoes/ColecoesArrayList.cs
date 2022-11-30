using System;
using System.Collections;


namespace CursoCSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arraylist = new ArrayList {
                "Silaba",
                4,
                false
            };

            arraylist.Add(3.14);

            foreach(var item in arraylist) {
                Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}
