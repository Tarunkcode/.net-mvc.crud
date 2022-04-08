using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent.Traning.Service
{
    public class ExcellentServices
    {
        public readonly EXCEntities _dbContext;
        public ExcellentServices(EXCEntities db)
        {
            _dbContext = db;
        }
        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }
        public bool SaveEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
