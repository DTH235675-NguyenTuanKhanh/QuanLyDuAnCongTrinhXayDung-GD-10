using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class PhanPhoiChiTiet
    {
            public int ID { get; set; }
            public int PhanPhoiID { get; set; }
            public virtual PhanPhoi PhanPhoi { get; set; } = null!;
    
            public int VatTuID { get; set; }
            public virtual VatTu VatTu { get; set; } = null!;
    
            public int SoLuong { get; set; }
    }
    [NotMapped]
    public class DanhSachPhanPhoiChiTiet
    {
        public int ID { get; set; }
        public int PhanPhoiID { get; set; }
        public int VatTuID { get; set; }
        public string TenVatTu { get; set; } = null!;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal TongChiPhi { get; set; }
    }
}
