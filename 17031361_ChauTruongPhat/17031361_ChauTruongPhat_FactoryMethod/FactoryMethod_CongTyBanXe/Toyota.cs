using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_CongTyBanXe
{
    public class Toyota : Car
    {
        private string maXe;
        private string tenXe;
        private string cauHinh;
        private string nhaSanXuat;
        private string tinhNangKyThuat;
        
        public override string getCauHinh()
        {
            return cauHinh;
        }

        public override string getMaXe()
        {
            return maXe;
        }

        public override string getNhaSanXuat()
        {
            return nhaSanXuat;
        }

        public override string getTenXe()
        {
            return tenXe;
        }

        public override string getTinhNangKyThuat()
        {
            return tinhNangKyThuat;
        }

        public Toyota(string maXe, string tenXe, string cauHinh, string nhaSanXuat, string tinhNangKyThuat)
        {
            this.maXe = maXe;
            this.tenXe = tenXe;
            this.cauHinh = cauHinh;
            this.nhaSanXuat = nhaSanXuat;
            this.tinhNangKyThuat = tinhNangKyThuat;
        }
    }
}
