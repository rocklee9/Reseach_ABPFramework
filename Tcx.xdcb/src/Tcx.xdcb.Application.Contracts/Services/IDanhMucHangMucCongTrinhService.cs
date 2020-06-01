using System;
using System.Collections.Generic;
using System.Text;
using Tcx.xdcb.EntitiesDTO.DMHangMucCongTrinh;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Tcx.xdcb.Services
{
    public interface IDanhMucHangMucCongTrinhService :
        ICrudAppService<
            DMHangMucCongTrinhDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateDMHangMucCongTrinhDto,
            CreateUpdateDMHangMucCongTrinhDto>
    {
    }
}
