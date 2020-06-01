using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Tcx.BookStore
{
    public interface IBookAppService :
        ICrudAppService<
            BookDto,
            Guid,
            PageBookDto,
            CreateUpdateBookDto,
            CreateUpdateBookDto>
    {

    }


}
