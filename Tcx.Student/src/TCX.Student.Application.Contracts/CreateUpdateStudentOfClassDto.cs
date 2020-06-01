using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TCX.Student
{
    public class CreateUpdateStudentOfClassDto
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
    }
}
