using Acme.BookStore.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{

    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
        //public ICollection<BookAttendee> Attendees { get; set; }

        //[ForeignKey("Category")]
        //public Guid CategoryID { get; set; }
        //public Category? Category{ get; set; }



    protected Book()
    {
    }


    public Book(
        Guid id,
        string name,
        BookType type,
        DateTime publishDate,
        float price
    ) : base(id)
    {
        Name = name;
        Type = type;
        PublishDate = publishDate;
        Price = price;
    }
    }
}
