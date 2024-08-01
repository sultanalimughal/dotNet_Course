using System.ComponentModel.DataAnnotations;

namespace my.project.ViewModels
{
    public class Blog
    {
        //[Required]
        //[Range(1, int.MaxValue)]
        public int Id { get; set; }
        [Required(ErrorMessage ="Title is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }
        public string? ImgName { get; set; }
    }
    public class BlogUpdateVM
    {
        public int BlogIndex { get; set; }
        [Required(ErrorMessage = "Title is required!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required!")]
        public string Description { get; set; }
        public string? ImgName { get; set; }
    }
}
