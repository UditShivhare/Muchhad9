using LoginApiN.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace LoginApiN.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAppBookAsync();
        Task<BookModel> GetBookByIdAsync(int id);
        Task<int> AddBookAsync(BookModel book);
        Task UpdateBookPatchAsync(int id,JsonPatchDocument bookModel);
    }
}
