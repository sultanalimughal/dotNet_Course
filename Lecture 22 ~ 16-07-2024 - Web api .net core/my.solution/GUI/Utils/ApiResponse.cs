namespace GUI.Utils
{
    public class Blog
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
    }

    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
        public string? Status { get; set; }
        public T? Data { get; set; }
    }
}
