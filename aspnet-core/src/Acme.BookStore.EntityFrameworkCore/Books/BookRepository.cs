using System;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.Books;

public class BookRepository : EfCoreRepository<BookStoreDbContext, Book, Guid>, IBookRepository
{
    public BookRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Book>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}