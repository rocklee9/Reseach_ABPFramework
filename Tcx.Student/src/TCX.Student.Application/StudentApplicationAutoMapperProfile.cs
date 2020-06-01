using AutoMapper;
using TCX.Student.Schema;

namespace TCX.Student
{
    public class StudentApplicationAutoMapperProfile : Profile
    {
        public StudentApplicationAutoMapperProfile()
        {
            CreateMap<Class, ClassDto>();
            CreateMap<CreateUpdateClassDto, Class>();

            CreateMap<StudentOfClass, StudentOfClassDto>();
            CreateMap<CreateUpdateClassDto, StudentOfClass>();
        }
    }
}
