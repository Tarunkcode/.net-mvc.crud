using Hello.core.training.Services.ContextDataModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hello.core.training.Services.IRepository
{
    public interface IRepository
    {
        Task<List<CoreTable>> getAll();
        Task<bool> SaveProject(CoreTable ctab);
    }
}
