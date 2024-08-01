using Microsoft.AspNetCore.Mvc;
using my.project.Infrastructure.Interface;
using my.project.Infrastructure.Repository;
using my.project.ViewModels;
using System.Reflection.Metadata;

namespace my.project.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public IActionResult Blogs(bool isDeleteRoute = false)
        {
            ViewData["isDeleteRoute"] = isDeleteRoute;
            return View(_blogRepository.blogsGetAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                //Create logic

                ModelState.AddModelError("", "Blog Created");
                _blogRepository.BlogCreate(blog);
                return View();

            }
            return View();
        }
        public IActionResult EditBlog(int blogIndex)
        {
            var blog = _blogRepository.BlogGetById(blogIndex);
            var BlogVM = new BlogUpdateVM()
            {
                BlogIndex = blogIndex,
                Description = blog.Description,
                ImgName = blog.ImgName,
                Title = blog.Title,
            };
            return View(BlogVM);
        }
        [HttpPost]
        public IActionResult EditBlog(BlogUpdateVM model)
        {
            if (ModelState.IsValid)
            {
                //update logic

                ModelState.AddModelError("", "Blog Updated");
                return View(_blogRepository.BlogUpdate(model));

            }
            return View(model);
        }

        public IActionResult DeleteBlog(int blogIndex)
        {
            _blogRepository.BlogDelete(blogIndex);
            return RedirectToAction("Blogs", new { Controller = "Blog", Area = "", isDeleteRoute = true });
        }
    }
}
