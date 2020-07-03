using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_CongTyBanXe
{
    class Program
    {
        static void Main(string[] args)
        {
            Car nexus = CarFactory.getCar("Nexus", "nexus", "nexus", "cauHinh Nexus", "nhaSanXuat Nexus", "tinhNangKyThuat"); 
            Car toyota = CarFactory.getCar("Toyota", "toyota", "Toyota", "cauHinh Toyota", "nhaSanXuat Toyota", "tinhNangKyThuat"); 
            Car honda = CarFactory.getCar("Honda", "honda", "Honda", "cauHinh Honda", "nhaSanXuat Honda", "tinhNangKyThuat");

            Console.WriteLine("Factory Nexus config: " + nexus.ToString());
            Console.WriteLine("Factory Toyota config: " + toyota.ToString());
            Console.WriteLine("Factory Honda config: " + honda.ToString());
        }
    }
}
