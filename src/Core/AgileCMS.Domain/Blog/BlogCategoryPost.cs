using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCMS.Domain.Blog
{
    /// <summary>
    /// A SubBase CLass
    /// </summary>
    public partial class BlogCategoryPost:BaseEntity
    {
        /// <summary>
        /// list of selected postIds for the a Category
        /// </summary>
        public string BlogPostId { get; set; }
    }
}
