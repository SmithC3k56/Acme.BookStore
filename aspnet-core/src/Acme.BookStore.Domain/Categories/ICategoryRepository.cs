using System;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Categories;

public interface ICategoryRepository : IRepository<Category, Guid>
{
}
