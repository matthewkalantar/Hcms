using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileCMS.Domain.Blog
{
    public partial class BlogComment:BaseEntity
    {
        /// <summary>
        /// Gets or sets the UserID
        /// </summary>
        public string UserId { get; set; }


        /// <summary>
        /// Gets or sets the comment text
        /// </summary>
        public string CommentBody { get; set; }

      

        /// <summary>
        /// Gets or sets the blog post identifier
        /// </summary>
        public string BlogPostId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }
    }
}
