using Domain;

namespace GUI.Utils
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7002/");
        }
		//Get All Blogs
		public async Task<ApiResponse<IEnumerable<Blog>>> GetAllBlogsAsync()
		{
			HttpResponseMessage response = await _httpClient.GetAsync("api/BlogGetAll");
			response.EnsureSuccessStatusCode();

			var result = await response.Content.ReadFromJsonAsync<ApiResponse<IEnumerable<Blog>>>();
			if (result == null)
			{
				throw new InvalidOperationException("The response content is null.");
			}

			return result;
		}

		//Create Blogs
		
		
		//public async Task<ApiResponse<Blog[]>> GetAllBlogsAsync()
		//{
		//    HttpResponseMessage response = await _httpClient.GetAsync("api/BlogGetAll");
		//    response.EnsureSuccessStatusCode();

		//    return await response.Content.ReadFromJsonAsync<ApiResponse<Blog[]>>();
		//}
	}
}
