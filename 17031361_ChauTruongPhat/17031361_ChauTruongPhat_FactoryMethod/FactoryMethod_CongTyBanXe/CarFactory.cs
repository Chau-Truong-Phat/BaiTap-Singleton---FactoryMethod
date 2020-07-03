using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_CongTyBanXe
{
    public class CarFactory
    {
        public static Car getCar(string type, string maXe, string tenXe, string cauHinh, string nhaSanXuat, string tinhNangKyThuat)
        {
            if ("Honda".Equals(type))
                return new Honda(maXe, tenXe, cauHinh, nhaSanXuat, tinhNangKyThuat);
            else if ("Nexus".Equals(type))
                return new Nexus(maXe, tenXe, cauHinh, nhaSanXuat, tinhNangKyThuat);
            else if ("Toyota".Equals(type))
                return new Toyota(maXe, tenXe, cauHinh, nhaSanXuat, tinhNangKyThuat);

            return null;
        }
    }
}
