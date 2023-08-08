using AgileCMS.Domain;
using AgileCMS.Infrastructure.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCMS.Infrastructure.Extensions
{
    public static class EventPublisherExtensions
    {
        public static async Task EntityInserted<T>(this IMediator eventPublisher, T entity) where T : BaseEntity
        {
            await eventPublisher.Publish(new EntityInserted<T>(entity));
        }

        public static async Task EntityUpdated<T>(this IMediator eventPublisher, T entity) where T : BaseEntity
        {
            await eventPublisher.Publish(new EntityUpdated<T>(entity));
        }

        public static async Task EntityDeleted<T>(this IMediator eventPublisher, T entity) where T : BaseEntity
        {
            await eventPublisher.Publish(new EntityDeleted<T>(entity));
        }

    }
}
