using Domain;
using Infrastructure.Implementation;
using Infrastructure.Interfaces;
using Infrastructure.Utils;
using Microsoft.AspNetCore.Mvc;

namespace my.project.Controllers
{
    [ApiController]
    [Route("api/")]
    public class BlogController : ControllerBase
    {
        private IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

		[HttpPost]
		[Route("BlogCreate")]
		public ResponseModel BlogCreate([FromBody] Blog blog)
		{
			if (!ModelState.IsValid)
			{
				return ResponseModel.UnprocessableEntity(new UnprocessableEntityObjectResult(ModelState));
			}
			var result = _blogRepository.BlogCreate(blog);
			if (result)
			{
				return ResponseModel.Created(blog, "Blog Created");
			}
			return ResponseModel.Failure("error while creating blog");
		}

		[HttpGet]
        [Route("BlogGetAll")]
        public ResponseModel BlogGetAll()
        {
            var blogs = _blogRepository.Blogs();
            if(blogs == null || blogs.Count() == 0) {
                return ResponseModel.NotFound("no blog found");
            }
            return ResponseModel.Success(blogs, "Blogst List");
        }


		//[HttpPut]
		//[Route("BlogEdit")]
		//public ResponseModel BlogEdit([FromBody] Blog blog)
		//{
		//	if (!ModelState.IsValid)
		//	{
		//		return ResponseModel.UnprocessableEntity(new UnprocessableEntityObjectResult(ModelState));
		//	}

		//	var existingBlog = _blogRepository.GetBlogById(blog.Id);
		//	if (existingBlog == null)
		//	{
		//		return ResponseModel.NotFound("Blog not found");
		//	}

		//	var result = _blogRepository.BlogEdit(blog);
		//	if (result)
		//	{
		//		return ResponseModel.Success(blog, "Blog updated successfully");
		//	}
		//	return ResponseModel.Failure("Error while updating blog");
		//}

	}
}
