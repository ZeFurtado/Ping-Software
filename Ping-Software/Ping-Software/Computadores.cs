using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ping_Software
{
    public class Computadores
    {
        public List<string> lab103 = new List<string>();
        List<string> lab104 = new List<string>();
        List<string> lab106 = new List<string>();
        List<string> lab107 = new List<string>();



        public string[] Lab103()
        {
            lab103.Add("192.168.23.11");
            lab103.Add("192.168.23.12");
            lab103.Add("192.168.23.13");
            lab103.Add("192.168.23.14");
            lab103.Add("192.168.23.15");

            return lab103.ToArray();
        }

    }

}
