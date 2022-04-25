using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


    public class Tratamento_do_arquivo
    {
        public Tratamento_do_arquivo(string local)
        {
            Tratar(local);            
        }
        public List<double> Tratar(string local_do_arquivo)
        {
            //variaveis
            string[] dados;
            int controle_de_erros = 0;
            List<double> dados_tratos = new List<double>();

            //
            dados = File.ReadAllText(local_do_arquivo).Split(' ');

            foreach (var numero in dados)
            {
                try
                {
                    dados_tratos.Add(double.Parse(numero));
                    Console.WriteLine(numero);
                }
                catch (Exception)
                {
                    controle_de_erros++;
                    throw;
                }
            }
            Console.ReadLine();

            return dados_tratos;
        }
    }

