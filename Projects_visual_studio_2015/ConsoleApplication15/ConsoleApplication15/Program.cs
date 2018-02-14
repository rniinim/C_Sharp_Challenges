using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean netti = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (netti == true)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=F_4Kut9WkT8&feature=youtu.be&t=39");
            }
            else
            {
                break;
            }

        }
    }
}
