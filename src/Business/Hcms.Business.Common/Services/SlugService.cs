using Hcms.Business.Core.Interfaces;
using Hcms.Domain.Seo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcms.Business.Common.Services
{
    /// <summary>
    /// Provides information about Slug URL Entity
    /// </summary>
    public class SlugService : ISlugService
    {
        Task ISlugService.DeleteEntityUrl(EntityUrl entityUrl)
        {
            throw new NotImplementedException();
        }

        Task<EntityUrl> ISlugService.GetBySlug(string slug)
        {
            throw new NotImplementedException();
        }

        Task ISlugService.InsertEntityUrl(EntityUrl urlEntity)
        {
            throw new NotImplementedException();
        }

        Task ISlugService.UpdateEntityUrl(EntityUrl urlEntity)
        {
            throw new NotImplementedException();
        }
    }
}
