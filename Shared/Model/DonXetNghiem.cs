using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class DonXetNghiem
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int? BacSiId { get; set; }
        public int GoiXetNghiemId { get; set; }
        public GoiXetNghiem GoiXetNghiem { get; set; }
        public DateTime Ngaydat {  get; set; }
        public string? ghiChu {  get; set; }
        public string Trangthai {  get; set; }
        public string giolaymau { get; set; }
        public DateTime ngaytaodon { get; set; }
    }
}
