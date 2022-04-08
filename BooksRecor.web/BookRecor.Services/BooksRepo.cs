using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecor.Services
{
    public class BooksRepo
    {
        public readonly bookshelfEntities _dbContext;
        public BooksRepo(bookshelfEntities db)
        {
            _dbContext = db;
        }
        public List<BookRecord> GetBookRecord()
        {
            return _dbContext.BookRecords.ToList();
        }
        //
        public bool SaveBookInRecord(BookRecord br)
        {
            var entity = _dbContext.BookRecords.FirstOrDefault(i => i.id == br.id);
            if(entity != null)
            {
                entity.name = br.name;
                entity.Author = br.Author;
                entity.publishYear = br.publishYear;
                entity.preBooking = br.preBooking;
                _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                _dbContext.BookRecords.Add(br);
                _dbContext.SaveChanges();
            }
            return true;
        }
        //update
        public BookRecord Getbook(int id)
        {
            var book = _dbContext.BookRecords.Find(id);
            return book;
        }

        public bool RemoveBook(int id)
        {
            var book = _dbContext.BookRecords.Find(id);
            _dbContext.BookRecords.Remove(book);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
