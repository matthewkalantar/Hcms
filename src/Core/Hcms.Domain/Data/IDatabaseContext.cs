using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcms.Domain.Data
{
    public interface IDatabaseContext
    {
        void SetConnection(string connectionString);
        IQueryable<T> Table<T>(string collectionName);
    }
}
