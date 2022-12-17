using System;
using System.Collection.Generic;
using System.Text
using CursoCSahrp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? coisa : valor;
        }

        public T GetValor()
        {
            reuturn valorPrivado;
        }
    }
    
    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0) { }
    }
    
    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto())
        {

        }
    }

    class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("Construtor");
            Console.WrtieLine(caixa2.metodoGenerico("Método"));
            Console.WriteLine(caixa2.coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.coisa.GetType());
        }
    }
}
