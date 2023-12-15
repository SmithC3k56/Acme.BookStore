using Acme.BookStore.Books;
using Acme.BookStore.Books.Dtos;
using Acme.BookStore.Categories;
using Acme.BookStore.Categories.Dtos;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>(MemberList.Source);
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>(MemberList.Source);
    }
}
