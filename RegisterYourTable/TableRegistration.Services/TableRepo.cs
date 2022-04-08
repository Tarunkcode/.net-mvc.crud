using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableRegistration.Services
{
    public class TableRepo
    {
        public readonly BookATableEntities1 _dbContext;
        public TableRepo(BookATableEntities1 db)
        {
            _dbContext = db;
        }
        public List<BookTable> GetAllBookings()
        {
            return _dbContext.BookTables.ToList();
        }

      
       public bool SaveFormData(BookTable bt)
        {
            var entity = _dbContext.BookTables.FirstOrDefault(m => m.tableId == bt.tableId);

            if(entity!= null)
            {
                entity.YourName = bt.YourName.Trim();
                entity.Venue = bt.Venue.Trim();
                entity.Agreed = bt.Agreed;
                entity.NumberOfPleople = bt.NumberOfPleople;
                entity.ChoosenServices = bt.ChoosenServices.Trim();
                entity.SecurityCode = bt.SecurityCode;
                entity.ReachingTime = bt.ReachingTime;
                entity.Bookingdate = bt.Bookingdate;
                _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                _dbContext.BookTables.Add(bt);
                _dbContext.SaveChanges();
            }
            return true;
        }

        // Update
        public BookTable GetOneBooking(int id)
        {
            var btt = _dbContext.BookTables.Find(id);
            return btt;
        }
        //Delete
        public bool RemoveFromRecord(int id)
        {
            var hold = _dbContext.BookTables.Find(id);
            _dbContext.BookTables.Remove(hold);
            _dbContext.SaveChanges();
            return true;

        }

    }
}
