using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acme.BookStore.Books;
using Acme.BookStore.Books.Dtos;
using Acme.BookStore.Web.Pages.Books.Book.ViewModels;

namespace Acme.BookStore.Web.Pages.Books.Book;

public class CreateModalModel : BookStorePageModel
{
    [BindProperty]
    public CreateEditBookViewModel ViewModel { get; set; }

    private readonly IBookAppService _service;

    public CreateModalModel(IBookAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditBookViewModel, CreateUpdateBookDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}