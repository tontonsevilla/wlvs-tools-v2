namespace WLVSToolsV2.Web.Infrastructure.Services
{
    public interface ILocalModelClient
    {
        Task<string> GenerateAsync(string prompt, CancellationToken ct = default);
    }
}
