using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganHang
{
    public class SacomBank : Bank
    {
        private string ma;
        private string ten;
        private string dichVu;
        private string khuyenMai;

        public SacomBank(string ma, string ten, string dichVu, string khuyenMai)
        {
            this.ma = ma;
            this.ten = ten;
            this.dichVu = dichVu;
            this.khuyenMai = khuyenMai;
        }

        public override string getDichVu()
        {
            throw new NotImplementedException();
        }

        public override string getKhuyenMai()
        {
            throw new NotImplementedException();
        }

        public override string getMaNganHang()
        {
            throw new NotImplementedException();
        }

        public override string getTen()
        {
            throw new NotImplementedException();
        }
    }
}
