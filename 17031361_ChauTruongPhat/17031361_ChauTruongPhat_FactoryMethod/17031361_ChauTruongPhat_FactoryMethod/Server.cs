using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_FactoryMethod
{
    public class Server : Computer
    {
        private string ram;
        private string hdd;
        private string cpu;

        public Server(string ram, string hdd, string cpu)
        {
            this.ram = ram;
            this.hdd = hdd;
            this.cpu = cpu;
        }

        public override string getRAM()
        {
            return this.ram;
        }

        public override string getHDD()
        {
            return this.hdd;
        }

        public override string getCPU()
        {
            return this.cpu;
        }
    }
}
