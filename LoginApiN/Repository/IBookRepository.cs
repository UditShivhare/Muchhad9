using LoginApiN.Models;

namespace LoginApiN.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAppBookAsync();
    }
}
