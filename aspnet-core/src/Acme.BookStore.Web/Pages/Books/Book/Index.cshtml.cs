using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.BookStore.Web.Pages.Books.Book;

public class IndexModel : BookStorePageModel
{
    public BookFilterInput BookFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class BookFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "BookName")]
    public string? Name { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "BookType")]
    public BookType? Type { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "BookPublishDate")]
    public DateTime? PublishDate { get; set; }

    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "BookPrice")]
    public float? Price { get; set; }
}
