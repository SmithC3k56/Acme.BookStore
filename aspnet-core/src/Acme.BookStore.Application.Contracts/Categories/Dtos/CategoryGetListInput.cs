using System;
using System.ComponentModel;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Categories.Dtos;

[Serializable]
public class CategoryGetListInput : PagedAndSortedResultRequestDto
{
    public string? Name { get; set; }
}