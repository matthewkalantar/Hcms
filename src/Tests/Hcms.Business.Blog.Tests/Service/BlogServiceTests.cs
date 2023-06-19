using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Hcms.Business.Blog.Service;
using Hcms.Domain.Blog;
using Hcms.Domain.Data;
using Hcms.Infrastructure;
using Hcms.Infrastructure.Events;
using MediatR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Hcms.Business.Blog.Tests.Service
{
    [TestClass()]
    public class BlogServiceTests
    {
        private Mock<IRepository<BlogPost>> _blogPostRepositoryMock;
        private Mock<IRepository<BlogComment>> _blogCommentRepositoryMock;
        private Mock<IRepository<BlogCategory>> _blogCategoryRepositoryMock;
        private Mock<IMediator> _mediatorMock;

        private BlogService _blogService;


        [TestInitialize()]
        public void Init()
        {
            _blogPostRepositoryMock = new Mock<IRepository<BlogPost>>();
            _blogCommentRepositoryMock = new Mock<IRepository<BlogComment>>();
            _blogCategoryRepositoryMock = new Mock<IRepository<BlogCategory>>();
          
            _mediatorMock = new Mock<IMediator>();
         
            _blogService = new BlogService(
                _blogPostRepositoryMock.Object, 
                _blogCommentRepositoryMock.Object,
                _blogCategoryRepositoryMock.Object, _mediatorMock.Object);
        }
        [TestMethod()]
        public async Task DeleteBlogPost_ValidArgument()
        {
            await _blogService.DeleteBlogPost(new BlogPost());


            _blogPostRepositoryMock.Verify(c => c.DeleteAsync(It.IsAny<BlogPost>()), Times.Once);


        
        }
        [TestMethod()]
        public void DeleteBlogPost_NullInput_ThrowException()
        {
            Assert.ThrowsExceptionAsync<ArgumentNullException>(async () => await _blogService.DeleteBlogPost(null), "blogPost");
        }

        [TestMethod()]
        public async Task GetBlogPostById()
        {
          
        }

        [TestMethod()]
        public void InsertBlogPost_NullArgument_ThrowException()
        {
            Assert.ThrowsExceptionAsync<ArgumentNullException>(async () => await _blogService.InsertBlogPost(null), "blogPost");
        }

        [TestMethod()]
        public async Task InsertBlogPost_ValiArgument__InvokeRepository()
        {
          
        
        }

        [TestMethod()]
        public async Task UpdateBlogCategory_ValiArgument_InvokeRepository()
        {
           
        }

        [TestMethod()]
        public void UpdateBlogCategory_NullArgument_ThrowException()
        {
            
        }

        [TestMethod()]
        public async Task DeleteBlogCategory_ValidArgument_InvokeRepository()
        {
            
        }

        [TestMethod()]
        public void DeleteBlogCategory_NullArgument_ThrowException()
        {
           
        }

        [TestMethod()]
        public async Task DeleteBlogComments_ValidArgument_InvokeRepository()
        {

        }

        [TestMethod()]
        public async Task InsertBlogComment_ValiArgument__InvokeRepository()
        {
         
        }

    }
}
