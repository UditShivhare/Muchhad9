using LoginAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoginAPI.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooksAsync();
        Task<BookModel> GetBookById(int Id);

        Task<int> AddBooksAsync(BookModel book);
        Task UpdateBookAsync(int id, BookModel bookM);

    }
}
