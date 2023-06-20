using Hcms.Domain.Seo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcms.Business.Core.Interfaces
{
    /// <summary>
    /// Provides information for URLs 
    /// </summary>
    public interface ISlugService
    {  
        
        /// <summary>
       /// Inserts an URL Entity
       /// </summary>
       /// <param name="urlEntity">URL Entity</param>
        Task InsertEntityUrl(EntityUrl urlEntity);

        /// <summary>
        /// Edit the URL Entity
        /// </summary>
        /// <param name="urlEntity">URL Entity</param>
        Task UpdateEntityUrl(EntityUrl urlEntity);

        /// <summary>
        /// Deletes an Entity url
        /// </summary>
        /// <param name="entityUrl">URL Entity</param>
        Task DeleteEntityUrl(EntityUrl entityUrl);

        /// <summary>
        /// Find URL Entity
        /// </summary>
        /// <param name="slug">Slug</param>
        /// <returns>Found URL Entity</returns>
        Task<EntityUrl> GetBySlug(string slug);
    }
}
