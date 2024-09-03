using GUI.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GUI.Controllers
{
    public class BlogController : Controller
    {
        private ApiService _apiService;

        public BlogController(ApiService  apiService)
        {
            
            _apiService = apiService;
        }
        public async Task<IActionResult> Blogs()
        {
			 ApiResponse < IEnumerable < Blog >> blogs;
			try
            {
				blogs = await _apiService.GetAllBlogsAsync();
			}
            catch(Exception ex) {
                return BadRequest(ex.Message);
            }
			return View(blogs.Data);
        }

	}
}
