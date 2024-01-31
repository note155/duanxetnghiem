using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class KetQuaXetNghiem
    {
        [Key]
        public int Id { get; set; }
        public int DonXetNghiemId { get; set; }
        public DonXetNghiem DonXetNghiem { get; set; }
        public string Anhketqua { get; set; }
        public string KetQua { get; set; }
        public string ghiChu { get; set; }
        public DateTime ngaycoKQ { get; set; }
    }
}
