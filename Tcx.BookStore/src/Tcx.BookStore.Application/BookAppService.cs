using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcx.BookStore.Users;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Tcx.BookStore
{
    //public class BookAppService :
    //    CrudAppService<Book, BookDto, Guid, PageBookDto,
    //                   CreateUpdateBookDto, CreateUpdateBookDto>,
    //    IBookAppService
    //{
    //    private readonly IRepository<Book, Guid> _bookRepository;
    //    public BookAppService(IRepository<Book, Guid> repository)
    //        : base(repository)
    //    {
    //        _bookRepository = repository;
    //    }

    //    //public override List<BookDto> GetListAsync()
    //    //{
    //    //    var book = _bookRepository
    //    //        .Where(p => (p.Name == null) || (p.Name != null && p.Name.Contains(page.Name)))
    //    //        .ToList();

    //    //    return book
    //    //        .Select(p => new BookDto { Id = p.Id, Name = p.Name, Type = p.Type, Price = p.Price, PublishDate = p.PublishDate })
    //    //        .ToList();
    //    //}

    //}

    public class BookAppService : ApplicationService
    {
        private readonly IRepository<Book, Guid> _bookRepository;
        private readonly IRepository<AppUser> _userRepository;
        public BookAppService(IRepository<Book, Guid> personRepository, IRepository<AppUser> userRepository)
        {
            _bookRepository = personRepository;
            _userRepository = userRepository;
        }

        public async Task Create(CreateUpdateBookDto input)
        {
            var book = new Book(GuidGenerator.Create(), input.Name, input.Type, input.PublishDate, input.Price);

            await _bookRepository.InsertAsync(book);
        }

        public List<BookDto> GetList(string nameFilter)
        {
            var book = _bookRepository
                .Where(p => (p.Name == null) || (p.Name != null && p.Name.Contains(nameFilter)))
                .ToList();

            return book
                .Select(p => new BookDto { Id = p.Id, Name = p.Name, Type = p.Type, Price = p.Price, PublishDate = p.PublishDate })
                .ToList();
        }

        public async Task Update(CreateUpdateBookDto input,Guid id)
        {
            var book = _bookRepository
                .Where(p =>  p.Id==id).FirstOrDefault();
            book.Name = input.Name;
            book.Type = input.Type;
            book.PublishDate = input.PublishDate;
            book.Price = input.Price;

            await _bookRepository.UpdateAsync(book);
        }
    }
}
