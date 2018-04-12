using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSHHRMCNTTT.VO
{
    class ChucVuInfor
    {   [Key]
        [Required]
        public string b_macv { get; set; }
        public string b_tencv { get; set; }
        public string b_ghichu { get; set; }

    }
}
