using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace TCX.Student.Schema
{
    public class Class : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public virtual StudentOfClass Student { get; set; }

        public Class() { }
        public Class(Guid id, string name) :
            base(id)
        {
            Name = name;
        }
    }
}
