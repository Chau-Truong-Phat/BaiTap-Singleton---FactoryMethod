using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank viettin = BankFactory.getBank("ViettinBank", "ViettinBank", "ViettinBank", "dịch vụ viettin", "Khuyến mãi viettin");
            Bank sacom = BankFactory.getBank("Sacombank", "Sacombank", "Sacombank", "dịch vụ sacom", "Khuyến mãi sacom");
            Bank acb = BankFactory.getBank("ACB", "ACB", "ACB", "dịch vụ ACB", "Khuyến mãi ACB");

            Console.WriteLine("Factory viettin config: " + viettin.ToString());
            Console.WriteLine("Factory sacom config: " + sacom.ToString());
            Console.WriteLine("Factory acb config: " + acb.ToString());
        }
    }
}
