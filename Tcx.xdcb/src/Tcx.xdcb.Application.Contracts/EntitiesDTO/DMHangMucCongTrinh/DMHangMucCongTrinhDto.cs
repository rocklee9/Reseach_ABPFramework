using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Tcx.xdcb.EntitiesDTO.DMHangMucCongTrinh
{
    public class DMHangMucCongTrinhDto: AuditedEntityDto<Guid>
    {
        public string MaHangMucCT { get; set; }
        public string TenHangMucCT { get; set; }
        public string GhiChu { get; set; }
    }
}
