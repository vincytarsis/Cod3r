using System;
using System.Collections;
using System.Colletction.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach(var pessoa in flia)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14)
        }
    }
}
