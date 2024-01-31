using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.form
{
    public class donXNform
    {
        public string Hoten { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public bool Gioitinh { get; set; }
        public int Tuoi { get; set; }
        public int idgoixetnghiem {  get; set; }
        public DateTime Ngaydat { get; set; }
        public string giolaymau { get; set; }
        public string ghiChu { get; set; }

    }
}
