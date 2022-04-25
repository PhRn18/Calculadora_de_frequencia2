using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_frequencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            string local_do_arquivo;

            Console.WriteLine("A calculadora foi iniciada. Digite o local do arquivo: ");
            local_do_arquivo = Console.ReadLine();

            Tratamento_do_arquivo conversao = new Tratamento_do_arquivo(local_do_arquivo);
        }
    }
}
