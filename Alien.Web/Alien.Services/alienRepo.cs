using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien.Services
{
   public class alienRepo
    {
        public readonly AlienEntities _dbContext;
        public alienRepo(AlienEntities db)
        {
            _dbContext = db;
        }
        public List<alien> GetAllAlientRecord()
        {

            return _dbContext.aliens.ToList();
        }

        public bool SaveAlienRecord(alien a) { 
            var entity = _dbContext.aliens.FirstOrDefault(m => m.id == a.id);
        
            if (entity != null)
            {
            entity.AlienBreed = a.AlienBreed.Trim();
            entity.AlienExpectedAge = a.AlienExpectedAge;
            entity.AlienMission = a.AlienMission.Trim();
            entity.AlienPlanet = a.AlienPlanet.Trim();
            _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _dbContext.SaveChanges();
            return true;
            }

            else
            {
                _dbContext.aliens.Add(a);
                _dbContext.SaveChanges();
            }
            return true;
        }
        // Update
        public alien GetOneRecord(int id)
        {
            var al = _dbContext.aliens.Find(id);
            return al;
        }
        //Delete
        public bool RemoveFromRecord(int id)
        {
            var hold = _dbContext.aliens.Find(id);
            _dbContext.aliens.Remove(hold);
            _dbContext.SaveChanges();
            return true;
           
        }

    }
}
