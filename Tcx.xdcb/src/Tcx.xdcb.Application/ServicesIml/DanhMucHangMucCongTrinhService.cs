using System;
using System.Collections.Generic;
using System.Text;
using Tcx.xdcb.Entities;
using Tcx.xdcb.EntitiesDTO.DMHangMucCongTrinh;
using Tcx.xdcb.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Tcx.xdcb.ServicesIml
{
    public class DanhMucHangMucCongTrinhService :
        CrudAppService<DMHangMucCongTrinh, DMHangMucCongTrinhDto, Guid, PagedAndSortedResultRequestDto,
                       CreateUpdateDMHangMucCongTrinhDto, CreateUpdateDMHangMucCongTrinhDto>,
        IDanhMucHangMucCongTrinhService
    {
        public DanhMucHangMucCongTrinhService(IRepository<DMHangMucCongTrinh, Guid> repository)
            : base(repository)
        {

        }
    }
}
