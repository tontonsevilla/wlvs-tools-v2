using System.Text.Json;

namespace WLVSToolsV2.Web.Infrastructure.Services
{
    public class LocalModelClient : ILocalModelClient
    {
        private readonly HttpClient _http; 
        
        public LocalModelClient(HttpClient http) 
        { 
            _http = http; 
        }
        
        public async Task<string> GenerateAsync(string prompt, CancellationToken ct = default)
        {
            var payload = new
            {
                model = "llama3", // adjust to your local model name
                prompt = prompt, 
                stream = false 
            }; 
            
            using var response = await _http.PostAsJsonAsync("/api/generate", payload, ct); 
            response.EnsureSuccessStatusCode(); 
            using var stream = await response.Content.ReadAsStreamAsync(ct); 
            using var doc = await JsonDocument.ParseAsync(stream, cancellationToken: ct); 
            return doc.RootElement.GetProperty("response").GetString() ?? ""; 
        } 
    }
}
