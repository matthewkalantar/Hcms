
using AgileCMS.Business.Core.Interfaces;
using AgileCMS.Domain.Blog;
using AgileCMS.Infrastructure.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCMS.Business.Blog.Events
{
   
    public class BlogPostDeletedEventHandler : INotificationHandler<EntityDeleted<BlogPost>>
    {
        private readonly ISlugService _slugService;

        public BlogPostDeletedEventHandler(ISlugService slugService)
        {
            _slugService = slugService;
        }
        public async Task Handle(EntityDeleted<BlogPost> notification, CancellationToken cancellationToken)
        {
            //Delete Slug for Deleted blogPost
            var urlToDelete = await _slugService.GetBySlug(notification.Entity.SeName);
            await _slugService.DeleteEntityUrl(urlToDelete);
        }
    }
}
