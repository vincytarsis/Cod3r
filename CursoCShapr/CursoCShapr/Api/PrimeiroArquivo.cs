using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CursoCSharp.Api
{
    class PrimeiroArquivo
    {

        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso ");
                    sw.WriteLine("Primeiro");
                    sw.WriteLine("arquivo");
                }
            }
            using (StreamWriter sw = FIle.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possivel");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
}
