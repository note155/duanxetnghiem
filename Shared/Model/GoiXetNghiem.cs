using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class GoiXetNghiem
    {
        [Key]
        public int Id { get; set; }
        public string TenGoi { get; set; }
        public long Gia { get; set; }
        public String ThoiGian { get; set; }
        public string Mota { get; set; }
        public string Anh { get; set; }

    }
}
