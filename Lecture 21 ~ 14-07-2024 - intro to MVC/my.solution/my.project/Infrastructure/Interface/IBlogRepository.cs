using my.project.ViewModels;

namespace my.project.Infrastructure.Interface
{
    public interface IBlogRepository
    {
        IEnumerable<Blog> blogsGetAll();
        bool BlogCreate(Blog blog);
        Blog BlogGetById(int blogIndex);
        BlogUpdateVM BlogUpdate(BlogUpdateVM model);
        bool BlogDelete(int blogIndex);
    }
}
