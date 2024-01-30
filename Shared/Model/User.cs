using System.ComponentModel.DataAnnotations;

namespace duanxetnghiem.Data.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public bool Gioitinh { get; set; }
        public int Tuoi {  get; set; }
    }
}
