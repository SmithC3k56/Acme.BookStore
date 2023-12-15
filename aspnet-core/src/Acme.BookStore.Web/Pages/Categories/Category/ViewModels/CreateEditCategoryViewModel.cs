using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Web.Pages.Categories.Category.ViewModels;

public class CreateEditCategoryViewModel
{
    [Display(Name = "CategoryName")]
    public string Name { get; set; }
}
