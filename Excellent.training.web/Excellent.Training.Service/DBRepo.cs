using System;
using System.Collections.Generic;
using System.Linq;

namespace Excellent.Training.Service
{
    public class Repository
    {
        public readonly KKTrainingEntities1 _dbContext;
        public Repository(KKTrainingEntities1 db)
        {
            _dbContext = db;
        }
        public List<PlayerRecord> GetPlayers()
        {
            return _dbContext.PlayerRecords.ToList();
        }
        public bool SavePlayerRecord(PlayerRecord pr)
        {

            var entity = _dbContext.PlayerRecords.FirstOrDefault(k=>k.PlayerRank==pr.PlayerRank);
            if (entity !=null)
            {

                entity.PlayerName = pr.PlayerName.Trim();
                
                entity.PlayerScore = pr.PlayerScore;
                entity.PlayerTeam = pr.PlayerTeam.Trim();
                entity.PlayerSport = pr.PlayerSport.Trim();
                entity.playerJurseyNo = pr.playerJurseyNo;
                _dbContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _dbContext.SaveChanges();
                return true;
            }
            else
            {
                _dbContext.PlayerRecords.Add(pr);
                _dbContext.SaveChanges();
            }
            return true;
        }

        //update
        public PlayerRecord GetPlayer(int rk)
        {
            var result = _dbContext.PlayerRecords.Find(rk);

            return result;
        }
        //delete
        public bool DeleteEmployee(int pr)
        {
            var result = _dbContext.PlayerRecords.Find(pr);
            _dbContext.PlayerRecords.Remove(result);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
