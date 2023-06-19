using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcms.Domain.Blog
{
    public partial class BlogCategory : BaseEntity
    {
        public BlogCategory() { }

        /// <summary>
        /// Gets or sets the blog category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the blog category sename
        /// </summary>
        public string SeName { get; set; }

        /// <summary>
        /// Gets or sets display order
        /// </summary>
        public int DisplayOrder { get; set; }


        /// <summary>
        /// Blog list
        /// </summary>
        public IList<BlogCategoryPost> BlogPosts { get; set; }
    }
}
