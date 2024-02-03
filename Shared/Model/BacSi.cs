using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class BacSi
    {
        [Key]
        public int Id { get; set; }
        public string Hoten { get; set; }
        public string Chucvu { get; set; }
        public string? Anh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}
