using System;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books;

public interface IBookRepository : IRepository<Book, Guid>
{
}
