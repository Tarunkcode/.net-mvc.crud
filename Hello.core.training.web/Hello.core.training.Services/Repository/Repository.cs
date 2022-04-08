using Hello.core.training.Services.ContextDataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello.core.training.Services.Repository
{
    public class Repository
    {
        private readonly CoreTrainingDemoBaseContext _db;
        public Repository(CoreTrainingDemoBaseContext db)
        {
            _db = db;
        }

        public async Task<List<CoreTable>> getAll()
        {
            var entity = await _db.CoreTables.ToListAsync();
            return entity;
        }

        public async Task<bool> SaveProject(CoreTable coretable)
        {
            var entity = _db.CoreTables.FirstOrDefault(k => k.ProjId == coretable.ProjId);
            if (entity != null)
            {
                entity.ProjName = coretable.ProjName.Trim();
                entity.ProjAim = coretable.ProjAim.Trim();
                entity.ProjStartDate = coretable.ProjStartDate;
                entity.ProjEndDate = coretable.ProjEndDate;
                entity.AssignedBy = coretable.AssignedBy.Trim();
                _db.Entry(entity).State = EntityState.Modified;
                await _db.SaveChangesAsync();
                return true;

            }
            else
            {
                _db.CoreTables.Add(coretable);
                await _db.SaveChangesAsync();
            }
            return true;
        }
        
    }
}
