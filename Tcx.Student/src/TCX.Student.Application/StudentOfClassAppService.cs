using System;
using System.Collections.Generic;
using System.Text;
using TCX.Student.Schema;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TCX.Student
{
    public class StudentOfClassAppService : ApplicationService
    {
        private readonly IRepository<StudentOfClass, Guid> _studentRepository;
    }
}
