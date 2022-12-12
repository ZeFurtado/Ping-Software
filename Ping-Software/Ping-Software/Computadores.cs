using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Net.NetworkInformation;

namespace Ping_Software
{
    public class Computadores
    {
        public List<string> enderecoIP = new List<string>();
        public List<string> nomeComputador = new List<string>();
        

        public void DispararPacote(string filePath)
        {
            LerArquivo(filePath);
            Ping ping = new Ping();
            PingReply reply;

            for (int i = 0; i <= enderecoIP.Count - 1; i++)
            {
                try
                {
                    reply = ping.Send(enderecoIP[i], 1);
                    if (reply.Status == IPStatus.Success)
                    {
                        Console.WriteLine($"{nomeComputador[i]} está ligado  [{enderecoIP[i]}]");
                    }
                    else 
                    {
                        
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
  
        }


        public void LerArquivo(string caminhoArquivo) 
        {
            try
            {
                var configCsv = new CsvConfiguration(CultureInfo.InvariantCulture);

                using (var arquivoCsv = new StreamReader(caminhoArquivo))
                using (var leitorCsv = new CsvReader(arquivoCsv, configCsv)) 
                {
                    var dados = leitorCsv.GetRecords<Laboratorios>();

                    foreach (var campo in dados) 
                    {
                        enderecoIP.Add(campo.ip);
                        nomeComputador.Add(campo.nome);
                    }
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void LimpaCampos() 
        {
            enderecoIP.Clear();
            nomeComputador.Clear();
        }

    }

    class Laboratorios
    {
        [Name("Nome")]
        public string nome { get; set;}

        [Name("IP")]
        public string ip { get; set; }
    }

}
