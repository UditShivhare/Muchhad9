using LoginApiN.Data;
using LoginApiN.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginApiN.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LoginAPINContext _context;

        public BookRepository(LoginAPINContext context)
        {
            _context = context;
        }

        public async Task<List<BookModel>> GetAppBookAsync()
            {
             var records =await _context.Books.Select(x=>new BookModel()
             {
                 Id = x.Id,
                 Title= x.Title,
                 Description = x.Description,
                 Author = x.Author,
                 Brand = x.Brand
               
             }).ToListAsync();

            return records;
            }
        
    }
}
