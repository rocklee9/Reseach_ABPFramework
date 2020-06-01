using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Tcx.BookStore.Class
{
    public class ClassOfStudent : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string MSSV { get; set; }

   

        protected ClassOfStudent()
        {

        }

       
    }
}
