using Acme.BookStore.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Categories
{
    public class Category :  AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

  

    protected Category()
    {
    }

    public Category(
        Guid id,
        string name
    ) : base(id)
    {
        Name = name;
    }
    }
}
