using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang
{
    public class ACB : Bank
    {
        private string maXe;
        private string tenXe;
        private string dichVu;
        private string khuyenMai;

        public override string getDichVu()
        {
            return dichVu;
        }

        public override string getKhuyenMai()
        {
            return khuyenMai;
        }

        public override string getMaNganHang()
        {
            return maXe;
        }

        public override string getTen()
        {
            return tenXe;
        }

        public ACB(string ma, string ten, string dichVu, string khuyenMai)
        {
            this.maXe = ma;
            this.tenXe = ten;
            this.dichVu = dichVu;
            this.khuyenMai = khuyenMai;
        }
    }
}
