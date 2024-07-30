using Microsoft.AspNetCore.Mvc;
using my.project.ViewModels;

namespace my.project.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blogs()
        {
            var Blogs = new List<Blog>();

            Blogs.Add(new Blog()
            {
                Title = "abc",
                Description = "123",
                ImgName = "bruce_lee_avatar_icon_263129.ico",
                Id = 1
            });
            Blogs.Add(new Blog()
            {
                Title = "abc",
                Description = "123",
                ImgName = "bruce_lee_avatar_icon_263129.ico",
                Id = 2
            });
            Blogs.Add(new Blog()
            {
                Title = "abc",
                Description = "123",
                ImgName = "bruce_lee_avatar_icon_263129.ico",
                Id = 3
            });
            return View(Blogs);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if(ModelState.IsValid)
            {
                //Create logic

                ModelState.AddModelError("", "Blog Created");
                return View();

            }
            return View();
        }
    }
}
