using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BSHHRMCNTTT.VO
{
    class PhongBanInfo
    {   [Required]
        [Key]
        public string b_mapb { get; set; }
        [Required]
        public string b_tenpb { get; set; }
        public string b_ghichu { get; set; }

    }
}
