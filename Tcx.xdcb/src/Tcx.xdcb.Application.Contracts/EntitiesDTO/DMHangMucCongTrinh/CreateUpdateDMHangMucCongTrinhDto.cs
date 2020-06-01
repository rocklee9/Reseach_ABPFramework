using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tcx.xdcb.EntitiesDTO.DMHangMucCongTrinh
{
    public class CreateUpdateDMHangMucCongTrinhDto
    {
        [StringLength(10)]
        public string MaHangMucCT { get; set; }
        [StringLength(225)]
        public string TenHangMucCT { get; set; }
        [StringLength(225)]
        public string GhiChu { get; set; }
    }
}
