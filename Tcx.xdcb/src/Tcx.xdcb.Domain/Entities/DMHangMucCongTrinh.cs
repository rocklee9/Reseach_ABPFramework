using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Tcx.xdcb.Entities
{
    public class DMHangMucCongTrinh: AuditedEntity<Guid>
    {
        public string MaHangMucCT { get; set; }
        public string TenHangMucCT { get; set; }
        public string GhiChu { get; set; }

    }
}
