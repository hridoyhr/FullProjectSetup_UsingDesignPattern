using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceDemo.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
