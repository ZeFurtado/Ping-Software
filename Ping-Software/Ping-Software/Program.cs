

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

                    labs.DispararPacote(@"C:\Users\lukhas.furtado\Documents\Programming\Repositório\Ping-Software\Lab103.csv");
                 
                    break;

                case "2":

                    labs.DispararPacote(@"C:\Users\lukhas.furtado\Documents\Programming\Repositório\Ping-Software\Lab104.csv");

                    break;



                case "3":

                    labs.DispararPacote(@"C:\Users\lukhas.furtado\Documents\Programming\Repositório\Ping-Software\Lab106.csv");

                    break;

                case "4":

                    break;

                case "5":

                    break;

            }

        }

        public void Ping(string filePath) 
        {
            
        }
    }
}
