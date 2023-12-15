using System;

namespace Acme.BookStore.Categories.Dtos;

[Serializable]
public class CreateUpdateCategoryDto
{
    public string Name { get; set; }
}