using System.Net.NetworkInformation;

namespace Ping_Software
{
    class Program
    {
        static void Main(string[] args) 
        {
            Computadores labs = new Computadores();
            labs.Lab103();
           
            Console.WriteLine("Em qual dos laboratório você gostaria de fazer Ping: ");
            Console.WriteLine("1) 103   2) 104   3) 106   4) 107   ");
            string opcao = Console.ReadLine();

            switch (opcao) 
            {
                case "1":
                    try
                    {
                        for (int i = 0; i <= labs.lab103.Count - 1; i++)
                        {
                            Ping ping = new Ping();
                            PingReply resposta = ping.Send(labs.lab103[i], 1000);
                            if (resposta.Status == IPStatus.Success)
                            {
                                Console.WriteLine("O computador está ligado!");
                            }
                            else
                            {
                                Console.WriteLine("O computador está desligado");
                            }
                        }

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
