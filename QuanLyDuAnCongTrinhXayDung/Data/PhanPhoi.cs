using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace QuanLyDuAnCongTrinhXayDung.Data
{
    public class PhanPhoi
    {
        public int ID { get; set; }
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public int DuAnID { get; set; }
        public virtual DuAn DuAn { get; set; } = null!;

        public string? GhiChu { get; set; }

        // Liên kết đến các dòng vật tư chi tiết
        public virtual ObservableCollectionListSource<PhanPhoiChiTiet> ChiTietPhanPhoi { get; } = new();
    }
    [NotMapped]
    public class DanhSachPhanPhoi
    {
        public int ID { get; set; }
        public DateTime NgayLap { get; set; }
        public int DuAnID { get; set; }
        public string TenDuAn { get; set; } = null!;
        public string? GhiChu { get; set; }
    }
}
