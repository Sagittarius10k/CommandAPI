namespace dotnet_rpg.Data
{
    public class PostService : IPostService
    {
        private readonly HttpClient _httpClient;

        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Post>> AllPosts()
        {
            return await _httpClient.GetFromJsonAsync<List<Post>>("/posts");
        }
    }
}