using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ThongTinCongDan
    {
        private string hoten;
        private string gioitinh;
        private string cccd;
        private DateTime ngaysinh;
        private string noisinh;
        private bool tinhtranghonnhan;
        private string quoctich;
        private string dantoc;
        private string tongiao;
        private string noiothuongtru;
        private string quequan;
        private string choohientai;
        private string sdt;
        private string email;

        public string Hoten { get { return hoten; } }
        public string Gioitinh { get { return gioitinh; } }
        public string Cccd { get { return cccd; } }
        public DateTime Ngaysinh { get { return ngaysinh; } }
        public string Noisinh { get { return noisinh; } }
        public bool Tinhtranghonnhan { get { return tinhtranghonnhan; } }
        public string Quoctich { get { return quoctich; } }

        public string Dantoc { get { return dantoc; } }

        public string Tongiao { get { return tongiao; } }
        public string Noiothuongtru { get { return noiothuongtru; } }
        public string Quequan { get { return quequan; } }
        public string Choohientai { get { return choohientai; } }
        public string Sdt { get { return sdt; } }
        public string Email { get { return email; } }

        public ThongTinCongDan(string hoten, string gioitinh, string cccd, DateTime ngaysinh, string noisinh, bool tinhtranghonnhan, string quoctich, string dantoc, string tongiao, string noiothuongtru, string quequan, string choohientai, string sdt, string email)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.cccd = cccd;
            this.ngaysinh = ngaysinh;
            this.noisinh = noisinh;
            this.tinhtranghonnhan = tinhtranghonnhan;
            this.quoctich = quoctich;
            this.dantoc = dantoc;
            this.tongiao = tongiao;
            this.noiothuongtru = noiothuongtru;
            this.quequan = quequan;
            this.choohientai = choohientai;
            this.sdt = sdt;
            this.email = email;
        }
    }
}
