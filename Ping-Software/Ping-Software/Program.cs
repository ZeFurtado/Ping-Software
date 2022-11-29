using System.Net.NetworkInformation;

namespace Ping_Software
{
    class Program
    {
        static void Main(string[] args) 
        {
            Computadores labs = new Computadores();
            
            Console.WriteLine("Em qual dos laboratório você gostaria de fazer Ping: ");
            Console.WriteLine("1) 103   2) 104   3) 106   4) 107   ");
            string opcao = Console.ReadLine();

            switch (opcao) 
            {
                case "1":
                    labs.Lab103();
                    try
                    {
                        for (int i = 0; i <= labs.enderecoIP.Count - 1; i++)
                        {
                            Ping ping = new Ping();
                            PingReply resposta = ping.Send(labs.enderecoIP[i], 1000);
                            if (resposta.Status == IPStatus.Success)
                            {
                                Console.WriteLine($"{labs.nomeComputador[i]} está ligado!");
                            }
                            else
                            {
                                Console.WriteLine($"{labs.nomeComputador[i]} está desligado");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case "2":

                    labs.Lab104();
                    try
                    {
                        for (int i = 0; i <= labs.enderecoIP.Count -1; i++) 
                        {
                            Ping ping = new Ping();
                            PingReply resposta = ping.Send(labs.enderecoIP[i], 1000);
                            if (resposta.Status == IPStatus.Success)
                            {
                                Console.WriteLine($"{labs.nomeComputador[i]} está ligado!");
                            }
                            else
                            {
                                Console.WriteLine($"{labs.nomeComputador[i]} está desligado");
                            }
                        }

                        labs.LimpaLista();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }               
                    break;

            }

        }
    }
}
