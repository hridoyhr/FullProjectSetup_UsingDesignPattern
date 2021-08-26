using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceDemo.Data
{
    public class Repository<T> : IRepository<T>
    {
        protected readonly DbContext _dbcontext;

        public Repository(DbContext context)
        {
            _dbcontext = context;
        }
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
