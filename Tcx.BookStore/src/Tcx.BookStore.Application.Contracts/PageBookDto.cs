using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Tcx.BookStore
{
    public class PageBookDto : PagedResultRequestDto, IPagedResultRequest, ILimitedResultRequest
    {
        public PageBookDto() { }
        public string Name { get; set; }
       
        
    }
}
