using AgileCMS.Business.Core.Interfaces;
using AgileCMS.Domain.Data;
using AgileCMS.Domain.Seo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AgileCMS.Business.Common.Services
{
    /// <summary>
    /// Provides information about Slug URL Entity
    /// </summary>
    public class SlugService : ISlugService
    {
        private readonly IRepository<EntityUrl> _urlEntityRepository;
        public SlugService(IRepository<EntityUrl> urlEntityRepository)
        {
            _urlEntityRepository = urlEntityRepository;
        }

        /// <summary>
        /// Deletes an URL Entity
        /// </summary>
        /// <param name="urlEntity">URL Entity</param>
        public virtual async Task DeleteEntityUrl(EntityUrl entityUrl)
        {
            if (entityUrl == null)
                throw new ArgumentNullException(nameof(entityUrl));

            await _urlEntityRepository.DeleteAsync(entityUrl);
        }
        /// <summary>
        /// Find URL Entity
        /// </summary>
        /// <param name="slug">Slug</param>
        /// <returns>Found URL Entity</returns>
        public virtual async Task<EntityUrl> GetBySlug(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return null;

            slug = slug.ToLowerInvariant();

            var query = from ur in _urlEntityRepository.Table
                        where ur.Slug == slug
                        orderby ur.IsActive
                        select ur;
            return await Task.FromResult(query.FirstOrDefault());
        }
        /// <summary>
        /// Inserts an URL Entity
        /// </summary>
        /// <param name="urlEntity">URL Entity</param>
        public virtual async Task InsertEntityUrl(EntityUrl urlEntity)
        {
            if (urlEntity == null)
                throw new ArgumentNullException(nameof(urlEntity));

            await _urlEntityRepository.InsertAsync(urlEntity);

       
        }
        /// <summary>
        /// Updates the URL Entity
        /// </summary>
        /// <param name="urlEntity">URL Entity</param>
        public virtual async Task UpdateEntityUrl(EntityUrl urlEntity)
        {
            if (urlEntity == null)
                throw new ArgumentNullException(nameof(urlEntity));

            await _urlEntityRepository.UpdateAsync(urlEntity);

          
        }
    }
}
