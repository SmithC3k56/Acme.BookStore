using System;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.Permissions;
using Acme.BookStore.Books.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;


public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {

    }
}

//public class BookAppService : CrudAppService<Book, BookDto, Guid, BookGetListInput, CreateUpdateBookDto, CreateUpdateBookDto>,
//    IBookAppService
//{
//    protected override string GetPolicyName { get; set; } = BookStorePermissions.Book.Default;
//    protected override string GetListPolicyName { get; set; } = BookStorePermissions.Book.Default;
//    protected override string CreatePolicyName { get; set; } = BookStorePermissions.Book.Create;
//    protected override string UpdatePolicyName { get; set; } = BookStorePermissions.Book.Update;
//    protected override string DeletePolicyName { get; set; } = BookStorePermissions.Book.Delete;

//    private readonly IBookRepository _repository;

//    public BookAppService(IBookRepository repository) : base(repository)
//    {
//        _repository = repository;
//    }

//    protected override async Task<IQueryable<Book>> CreateFilteredQueryAsync(BookGetListInput input)
//    {
//        // TODO: AbpHelper generated
//        return (await base.CreateFilteredQueryAsync(input))
//            .WhereIf(!input.Name.IsNullOrWhiteSpace(), x => x.Name.Contains(input.Name))
//            .WhereIf(input.Type != null, x => x.Type == input.Type)
//            .WhereIf(input.PublishDate != null, x => x.PublishDate == input.PublishDate)
//            .WhereIf(input.Price != null, x => x.Price == input.Price)
//            ;
//    }

//    public Task<PagedResultDto<BookDto>> GetListAsync(PagedAndSortedResultRequestDto input)
//    {
//        throw new NotImplementedException();
//    }
//}
