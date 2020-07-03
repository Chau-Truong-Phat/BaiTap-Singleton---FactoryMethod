using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang
{
    public class BankFactory
    {
        public static Bank getBank(string type, string ma, string ten, string dichVu, string khuyenMai)
        {
            if ("ViettinBank".Equals(type))
                return new ViettinBank(ma, ten, dichVu, khuyenMai);
            else if ("ACB".Equals(type))
                return new SacomBank(ma, ten, dichVu, khuyenMai);
            else if ("Sacombank".Equals(type))
                return new ACB(ma, ten, dichVu, khuyenMai);

            return null;
        }
    }
}
