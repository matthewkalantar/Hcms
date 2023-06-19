using Hcms.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcms.Infrastructure.Events
{
    /// <summary>
    /// A container for passing entities that have been deleted. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityDeleted<T> : INotification where T : BaseEntity

    {
        public EntityDeleted(T entity)
        {
            Entity = entity;
        }
        public T Entity { get; private set; }
    }
}
