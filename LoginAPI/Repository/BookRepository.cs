using LoginAPI.Data;
using LoginAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LoginAPIContext _context;

        public BookRepository(LoginAPIContext context)
        {
            _context = context;
        }
        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var records = await _context.Books.Select(x=>new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Brand = x.Brand,
                Author = x.Author,
                Description = x.Description,
            } ).ToListAsync();

            return records;
        }

        public async Task<BookModel> GetBookById(int Id)
        {
            var record = await _context.Books.Where(x => x.Id == Id).Select(x=> new BookModel()
            {
                Id =x.Id, Title = x.Title,Author= x.Author,Brand= x.Brand,Description=x.Description
            }).FirstOrDefaultAsync();
            return record;
        }

        public async Task<int> AddBooksAsync(BookModel book)
        {
            var books = new Books()
            {
               // Id = book.Id,
                Title = book.Title,
                Brand = book.Brand,
                Author = book.Author,
                Description = book.Description

            };
            var result = _context.Books.Add(books);
            await _context.SaveChangesAsync();
            return books.Id;
            
        }

        public async Task  UpdateBookAsync(int id ,BookModel bookM)
        {
            var book = new Books()
            {
                Id = id,
                Title = bookM.Title,
                Brand = bookM.Brand,
                Author = bookM.Author,
                Description = bookM.Description,

            };
           _context.Books.Update(book);
            await _context.SaveChangesAsync();

        }


    }
}
