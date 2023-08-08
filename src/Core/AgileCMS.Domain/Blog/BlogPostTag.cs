

namespace AgileCMS.Domain.Blog
{
    /// <summary>
    ///  blog post tag
    /// </summary>
    public partial class BlogPostTag
    {


        /// <summary>
        /// Gets or sets the name of Tag
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the tagged product count
        /// </summary>
        public int BlogPostCount { get; set; }
    }
}
