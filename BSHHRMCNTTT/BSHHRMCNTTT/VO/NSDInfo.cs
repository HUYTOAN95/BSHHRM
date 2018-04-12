using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHHRMCNTTT.VO
{
    class NSDInfo
    {
        [Required]
        [Key]
        public string b_madv { get; set; }
        [Key]
        public string b_nsd { get; set; }
        public string b_matkhau { get; set; }
        public string b_manv { get; set; }
        public DateTime b_ngaydk { get; set; }
        public DateTime b_ngayhh { get; set; }
        public DateTime ? b_tgdn { get; set; }
     
        public string b_quyendn { get; set; }
        public string b_email { get; set; }
        public string KeyCode { get; set; }
    }
}
