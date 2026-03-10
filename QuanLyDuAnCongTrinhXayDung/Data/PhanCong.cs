using Microsoft.EntityFrameworkCore.ChangeTracking;
namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class PhanCong
    {
        public int ID { get; set; } 
        public int DuAnID { get; set; } 
        public int NhanVienID { get; set; }
        public int CongViecID { get; set; }
        public string VaiTro { get; set; } // Ví dụ: Kỹ sư trưởng, Giám sát
        public decimal? PhuCap { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int PhanTramHoanThanh { get; set; } // Tiến độ công việc (0-100)

       
        public virtual CongViec CongViec { get; set; } = null!;
        public virtual DuAn DuAn { get; set; } = null!; 
        public virtual NhanVien NhanVien { get; set; } = null!; 
    }
    public class DanhSachPhanCong
    {
        // Các thuộc tính định danh
        public int ID { get; set; }

        // Khóa ngoại ID để hỗ trợ Binding ComboBox
        public int DuAnID { get; set; }
        public int NhanVienID { get; set; }
        public int CongViecID { get; set; }

        // Các thuộc tính tên để hiển thị lên DataGridView
        public string TenDuAn { get; set; }
        public string TenNhanVien { get; set; }
        public string TenCongViec { get; set; }

        // Các thông tin chi tiết khác
        public string VaiTro { get; set; }
        public decimal PhuCap { get; set; } // Nên để decimal để tránh lỗi tính toán
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public int PhanTramHoanThanh { get; set; }
    }
}