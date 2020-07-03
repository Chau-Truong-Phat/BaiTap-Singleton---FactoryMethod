using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer PC = ComputerFactory.getComputer("pc", "2 GB", "500 GB", "2.4 GHz");
            Computer server = ComputerFactory.getComputer("server", "16 GB", "1 TB", "2.9 GHz");

            Console.WriteLine("Factory PC Config: " + PC.ToString());
            Console.WriteLine("Factory Server Config: " + server.ToString());
        }
    }
}
