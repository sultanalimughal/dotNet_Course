using Domain;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Implementation
{
    public class BlogRepository : IBlogRepository
    {
        private List<Blog> _blogs;

        public BlogRepository()
        {
            _blogs = new List<Blog>();
        }
        public IEnumerable<Blog> Blogs()
        {
            return _blogs;
        }
        public bool BlogCreate(Blog blog)
        {
            _blogs.Add(blog);
            return true;
        }
    }
}
