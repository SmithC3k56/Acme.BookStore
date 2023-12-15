using Acme.BookStore.Books.Dtos;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Acme.BookStore.Blazor.Services
{
    public class BookService
    {
        private readonly HttpClient _httpClient;
        public BookService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<List<BookDto>?> GetListBooks()
        {
            var rs = new List<BookDto>();
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<BookDto>>("/app/book");
              
                return rs;
            }
            catch (AccessTokenNotAvailableException ex)
            {
                ex.Redirect();
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }
    }
}
