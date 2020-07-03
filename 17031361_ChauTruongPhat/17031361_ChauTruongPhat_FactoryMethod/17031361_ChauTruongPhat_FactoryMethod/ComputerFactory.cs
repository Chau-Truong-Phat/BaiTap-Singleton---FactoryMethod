using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_FactoryMethod
{
    public class ComputerFactory
    {
        public static Computer getComputer(string type, string ram, string hdd, string cpu)
        {
            if ("PC".Equals(type))
                return new PC(ram, hdd, cpu);
            else if ("Server".Equals(type))
                return new Server(ram, hdd, cpu);

            return null;
        }
    }
}
