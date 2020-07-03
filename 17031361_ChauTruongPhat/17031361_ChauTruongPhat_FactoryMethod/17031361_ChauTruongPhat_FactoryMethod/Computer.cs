using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_FactoryMethod
{
    public abstract class Computer
    {
        public abstract string getRAM();
        public abstract string getHDD();
        public abstract string getCPU();

        public override string ToString()
        {
            return "RAM= " + this.getRAM() + ", HDD=" + this.getHDD() + ",CPU = "+this.getCPU();
        }
    }
}
