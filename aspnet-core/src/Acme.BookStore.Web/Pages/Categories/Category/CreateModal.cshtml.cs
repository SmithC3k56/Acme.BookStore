using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.BookStore.Categories;
using Acme.BookStore.Categories.Dtos;
using Acme.BookStore.Web.Pages.Categories.Category.ViewModels;

namespace Acme.BookStore.Web.Pages.Categories.Category;

public class CreateModalModel : BookStorePageModel
{
    [BindProperty]
    public CreateEditCategoryViewModel ViewModel { get; set; }

    private readonly ICategoryAppService _service;

    public CreateModalModel(ICategoryAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditCategoryViewModel, CreateUpdateCategoryDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}