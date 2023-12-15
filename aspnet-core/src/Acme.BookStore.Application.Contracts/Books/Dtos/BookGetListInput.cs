using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books.Dtos;

[Serializable]
public class BookGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }

    public BookType? Type { get; set; }

    public DateTime? PublishDate { get; set; }

    public float? Price { get; set; }
}