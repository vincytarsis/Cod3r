using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace CursoCSharp.Api
{
    public static class ExtensaoString {

        public static string ParseHome(this string path) {
            string home = (Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%"));
            return path.Replace("~", home);
        }
    }

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
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("É possivel");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto!");
            }
        }
    }
}

