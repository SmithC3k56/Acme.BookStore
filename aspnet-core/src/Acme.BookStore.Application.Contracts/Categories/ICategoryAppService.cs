using System;
using Acme.BookStore.Categories.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Categories;


public interface ICategoryAppService :
    ICrudAppService< 
        CategoryDto, 
        Guid, 
        CategoryGetListInput,
        CreateUpdateCategoryDto,
        CreateUpdateCategoryDto>
{

}