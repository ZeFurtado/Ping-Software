using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace Ping_Software
{
    public class Computadores
    {
        public List<string> enderecoIP = new List<string>();
        public List<string> nomeComputador = new List<string>();
    
        public string[] Lab103()
        {
            enderecoIP.Add("192.168.23.11");
            nomeComputador.Add("ROB01");

            enderecoIP.Add("192.168.23.12");
            nomeComputador.Add("ROB02");

            enderecoIP.Add("192.168.23.13");
            nomeComputador.Add("ROB03");

            enderecoIP.Add("192.168.23.14");
            nomeComputador.Add("ROB04");

            enderecoIP.Add("192.168.23.15");
            nomeComputador.Add("ROB05");

            
            return enderecoIP.ToArray();
        }

        public string[] Lab104() 
        {
            try 
            {
                var configCsv = new CsvConfiguration(CultureInfo.InvariantCulture);
                
                using (var arquivoCSV = new StreamReader(@"C:\Users\lukhas.furtado\Documents\Programming\Repositório\Ping-Software\Lab104.csv"))    
                using (var leitorCSV = new CsvReader(arquivoCSV, configCsv)) 
                {
                    var dados = leitorCSV.GetRecords<Laboratorios>();

                    foreach (var i in dados)
                    {
                        enderecoIP.Add(i.ip);
                        nomeComputador.Add(i.nome);
                    }
                    
                }

                return enderecoIP.ToArray();
            }
            catch 
            {
                return enderecoIP.ToArray();
            }
        }

        public void LimpaLista() 
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
