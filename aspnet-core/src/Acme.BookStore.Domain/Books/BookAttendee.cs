using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Auditing;

namespace Acme.BookStore.Books
{
    public class BookAttendee : IHasCreationTime
    {
        public Guid UserId { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
