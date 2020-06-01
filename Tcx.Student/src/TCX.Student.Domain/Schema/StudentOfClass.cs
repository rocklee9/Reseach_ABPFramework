using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace TCX.Student.Schema
{
    public class StudentOfClass : AuditedAggregateRoot<Guid>
    {
        [Required]
        [StringLength(9)]
        public string MSSV { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }
        public Guid Id_Class { get; set; }
        [ForeignKey("Id_Class")]
        public virtual ICollection<Class> Classes { get; set; }
    }
}
