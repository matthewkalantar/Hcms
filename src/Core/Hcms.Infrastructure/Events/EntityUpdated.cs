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
    /// A container for entities that are updated.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EntityUpdated<T> : INotification where T : BaseEntity
    {
        public EntityUpdated(T entity)
        {
            Entity = entity;
        }

        public T Entity { get; private set; }
    }
}
