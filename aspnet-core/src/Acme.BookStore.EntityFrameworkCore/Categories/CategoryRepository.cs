using System;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Acme.BookStore.Categories;

public class CategoryRepository : EfCoreRepository<BookStoreDbContext, Category, Guid>, ICategoryRepository
{
    public CategoryRepository(IDbContextProvider<BookStoreDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Category>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}