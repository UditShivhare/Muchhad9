using LoginApiN.Data;
using LoginApiN.Models;
using Microsoft.AspNetCore.JsonPatch;
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
            var records = await _context.Books.Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Author = x.Author,
                Brand = x.Brand

            }).ToListAsync();

            return records;
        }

        public async Task<BookModel> GetBookByIdAsync(int id)
        {
            var book = await _context.Books.Where(x => x.Id == id).Select(x => new BookModel()
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Author = x.Author,
                Brand = x.Brand

            }).FirstOrDefaultAsync();
            return book;


        }

        public async Task<int> AddBookAsync(BookModel book)
        {
            var books = new Books()
            {
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Brand = book.Brand


            };
            var id = await _context.Books.AddAsync(books);
            _context.SaveChanges();
            return books.Id;
        }

        public async Task UpdateBookAsync(BookModel bookModel,int id)
        {
            var book = new Books()
            {
                Id= id,
                Title = bookModel.Title,
                Description = bookModel.Description,
                Author = bookModel.Author,
                Brand = bookModel.Brand
            };
            _context.Books.Update(book);
             await _context.SaveChangesAsync();
        }

        public async Task UpdateBookPatchAsync(int id,JsonPatchDocument bookModel)
        {
            var book = _context.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (book != null)
            {
                bookModel.ApplyTo(book);
                await _context.SaveChangesAsync();

            }
        }

    }


}





