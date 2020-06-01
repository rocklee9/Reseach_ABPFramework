using AutoMapper;
using Tcx.xdcb.Entities;
using Tcx.xdcb.EntitiesDTO.DMHangMucCongTrinh;

namespace Tcx.xdcb
{
    public class xdcbApplicationAutoMapperProfile : Profile
    {
        public xdcbApplicationAutoMapperProfile()
        {
            CreateMap<DMHangMucCongTrinh, DMHangMucCongTrinhDto>();
            CreateMap<CreateUpdateDMHangMucCongTrinhDto, DMHangMucCongTrinh>();
        }
    }
}
