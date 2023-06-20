using Hcms.Domain;
using Hcms.Domain.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hcms.Business.Core.Interfaces
{
    /// <summary>
    /// Blog service interface
    /// </summary>
    public interface IBlogService
    {

        /// <summary>
        /// Gets a blog post
        /// </summary>
        /// <param name="blogPostId">Blog post identifier</param>
        /// <returns>Blog post</returns>
        Task<BlogPost> GetBlogPostById(string blogPostId);  

        /// <summary>
        /// Gets all blog posts
        /// </summary>
       
        /// <param name="dateTo">Filter by created date; null if you want to get all records</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <param name="tag">Tag</param>
        /// <param name="blogPostName">Blog post name</param>
        /// <param name="categoryId">Category id</param>
        /// <returns>Blog posts</returns>
        Task<IPagedList<BlogPost>> GetAllBlogPosts(
            DateTime? dateFrom = null, DateTime? dateTo = null,
            int pageIndex = 0, int pageSize = int.MaxValue, bool showHidden = false, string tag = null, string blogPostName = "", string categoryId = "");

        /// <summary>
        /// Gets all blog posts
        /// </summary>
        /// <param name="tag">Tag</param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>Blog posts</returns>
        Task<IPagedList<BlogPost>> GetAllBlogPostsByTag(
            string tag = "",
            int pageIndex = 0, int pageSize = int.MaxValue, bool showHidden = false);

        /// <summary>
        /// Gets all blog post tags
        /// </summary>

        /// <param name="showHidden">A value indicating whether to show hidden records</param>
        /// <returns>Blog post tags</returns>
        Task<IList<BlogPostTag>> GetAllBlogPostTags( bool showHidden = false);

        /// <summary>
        /// Inserts an blog post
        /// </summary>
        /// <param name="blogPost">Blog post</param>
        Task InsertBlogPost(BlogPost blogPost);

        /// <summary>
        /// Updates the blog post
        /// </summary>
        /// <param name="blogPost">Blog post</param>
        Task UpdateBlogPost(BlogPost blogPost);
        /// <summary>
        /// Deletes a blog post
        /// </summary>
        /// <param name="blogPost">Blog post</param>
        Task DeleteBlogPost(BlogPost blogPost);

        /// <summary>
        /// Gets all comments
        /// </summary>
        /// <param name="customerId">Customer identifier; "" to load all records</param>
     
        /// <returns>Comments</returns>
        Task<IList<BlogComment>> GetAllComments(string customerId);

        /// <summary>
        /// Gets a blog comment
        /// </summary>
        /// <param name="blogCommentId">Blog comment identifier</param>
        /// <returns>Blog comment</returns>
        Task<BlogComment> GetBlogCommentById(string blogCommentId);

        Task<IList<BlogComment>> GetBlogCommentsByBlogPostId(string blogPostId);

        /// <summary>
        /// Inserts a blog post comment
        /// </summary>
        /// <param name="blogComment">Blog post comment</param>
        Task InsertBlogComment(BlogComment blogComment);

        Task DeleteBlogComment(BlogComment blogComment);

        /// <summary>
        /// Get category by id
        /// </summary>
        /// <param name="blogCategoryId">Blog category id</param>
        /// <returns></returns>
        Task<BlogCategory> GetBlogCategoryById(string blogCategoryId);

        /// <summary>
        /// Get categories by post id
        /// </summary>
        /// <param name="blogPostId">Blog post id</param>
        /// <returns></returns>
        Task<IList<BlogCategory>> GetBlogCategoryByPostId(string blogPostId);

        /// <summary>
        /// Get category by se name
        /// </summary>
        /// <param name="blogCategorySeName">Blog category se name</param>
        /// <returns></returns>
        Task<BlogCategory> GetBlogCategoryBySeName(string blogCategorySeName);

        /// <summary>
        /// Get all blog categories
        /// </summary>
        /// <returns></returns>
        Task<IList<BlogCategory>> GetAllBlogCategories(string storeId = "");

        /// <summary>
        /// Inserts an blog category
        /// </summary>
        /// <param name="blogCategory">Blog category</param>
        Task<BlogCategory> InsertBlogCategory(BlogCategory blogCategory);

        /// <summary>
        /// Updates the blog category
        /// </summary>
        /// <param name="blogCategory">Blog category</param>
        Task<BlogCategory> UpdateBlogCategory(BlogCategory blogCategory);

        /// <summary>
        /// Delete blog category
        /// </summary>
        /// <param name="blogCategory">Blog category</param>
        Task DeleteBlogCategory(BlogCategory blogCategory);


    }
}
