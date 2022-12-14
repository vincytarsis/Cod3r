using System;
using System.IO;

namespace CursoCSharp.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"~/lendo_arquivo.txt".ParseHome();

            if (!File.Exists(path)) { 
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preço;Qtde");
                    sw.WriteLine("Caneta Bic;1.9;10");
                    sw.WriteLine("Folha Sufite;10.3;5");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }catch(Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
