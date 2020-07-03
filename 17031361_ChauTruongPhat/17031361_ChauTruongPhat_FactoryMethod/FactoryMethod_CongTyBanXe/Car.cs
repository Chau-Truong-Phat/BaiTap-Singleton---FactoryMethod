using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_CongTyBanXe
{
    public abstract class Car
    {
        public abstract string getMaXe();
        public abstract string getTenXe();
        public abstract string getCauHinh();
        public abstract string getNhaSanXuat();
        public abstract string getTinhNangKyThuat();

        public override string ToString()
        {
            return "MaXe: " + this.getMaXe() + ", TenXe: " + this.getTenXe() + ", CauHinh: " + this.getCauHinh() 
                + ", NhaSanXuat: " + this.getNhaSanXuat() + ", TinhNangKyThuat: " + this.getTinhNangKyThuat() ;
        }
    }
}
