using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Categories.Dtos;

[Serializable]
public class CategoryDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }
}