using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang
{
    public abstract class Bank
    {
        public abstract string getMaNganHang();
        public abstract string getTen();
        public abstract string getDichVu();
        public abstract string getKhuyenMai();
        public override string ToString()
        {
            return "Ma: " + this.getMaNganHang() + ", Ten: " + this.getTen() + ", DichVu: " + 
                this.getDichVu() + "KhuyenMai: " + this.getKhuyenMai();
        }
    }
}
