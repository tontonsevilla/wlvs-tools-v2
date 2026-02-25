using WLVSToolsV2.Web.Common.Models.Agents;

namespace WLVSToolsV2.Web.Infrastructure.Services
{
    public interface IAgentService
    {
        Task<AgentResponse> ProcessAsync(string userMessage, CancellationToken ct = default);
    }
}
