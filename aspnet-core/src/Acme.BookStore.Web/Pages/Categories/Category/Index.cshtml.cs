using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.BookStore.Web.Pages.Categories.Category;

public class IndexModel : BookStorePageModel
{
    public CategoryFilterInput CategoryFilter { get; set; }
    
    public virtual async Task OnGetAsync()
    {
        await Task.CompletedTask;
    }
}

public class CategoryFilterInput
{
    [FormControlSize(AbpFormControlSize.Small)]
    [Display(Name = "CategoryName")]
    public string? Name { get; set; }
}
