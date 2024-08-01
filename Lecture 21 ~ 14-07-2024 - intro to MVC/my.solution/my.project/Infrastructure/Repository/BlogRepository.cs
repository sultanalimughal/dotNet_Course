using my.project.Infrastructure.Interface;
using my.project.ViewModels;

namespace my.project.Infrastructure.Repository
{
    public class BlogRepository : IBlogRepository
    {
        public BlogRepository()
        {
            _blogs = new List<Blog>();
        }

        public List<Blog> _blogs { get; }

        public IEnumerable<Blog> blogsGetAll()
        {
            return _blogs;
        }

        public bool BlogCreate(Blog blog)
        {
            _blogs.Add(blog);
            return true;
        }

        public Blog BlogGetById(int blogIndex)
        {
            return _blogs[blogIndex];
        }

        public BlogUpdateVM BlogUpdate(BlogUpdateVM model)
        {
            _blogs[model.BlogIndex] = new Blog()
            {
                Description = model.Description,
                ImgName = model.ImgName,
                Title = model.Title,
                Id = 0
            };
            return model;
        }

        public bool BlogDelete(int blogIndex)
        {
            if (blogIndex >= 0 && blogIndex < _blogs.Count)
            {
                _blogs.RemoveAt(blogIndex);
                return true;
            }
            return false;
        }
    }
}
