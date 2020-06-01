using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCX.Student.Schema;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TCX.Student
{
    public class ClassAppService :ApplicationService
    {
        private readonly IRepository<Class, Guid> _classRepository;
        public ClassAppService(IRepository<Class, Guid> classRepository)
        {
            _classRepository = classRepository;
            
        }

        public async Task Create(CreateUpdateClassDto input)
        {
            var book = new Class(GuidGenerator.Create(), input.Name);

            await _classRepository.InsertAsync(book);
        }

        public List<ClassDto> GetList(string nameFilter)
        {
            var classs = _classRepository
                .Where(p => (p.Name == null) || (p.Name != null && p.Name.Contains(nameFilter)))
                .ToList();

            return classs
                .Select(p => new ClassDto {  Name = p.Name})
                .ToList();
        }

        public async Task Update(CreateUpdateClassDto input, Guid id)
        {
            var classs = _classRepository
                .Where(p => p.Id == id).FirstOrDefault();
            classs.Name = input.Name;
           

            await _classRepository.UpdateAsync(classs);
        }


    }
}
