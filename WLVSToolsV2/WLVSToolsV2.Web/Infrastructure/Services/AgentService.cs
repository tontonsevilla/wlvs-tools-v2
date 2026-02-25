using System.Text;
using WLVSToolsV2.Web.Common.Models.Agents;

namespace WLVSToolsV2.Web.Infrastructure.Services
{
    public class AgentService : IAgentService 
    { 
        private readonly ILocalModelClient _model; 
        private readonly IToolRegistry _tools;
        private readonly PromptLoader _promptLoader;

        public AgentService(ILocalModelClient model, 
            IToolRegistry tools,
            PromptLoader promptLoader) 
        { 
            _model = model; 
            _tools = tools;
            _promptLoader = promptLoader;
        } 
        
        public async Task<AgentResponse> ProcessAsync(string userMessage, 
            CancellationToken ct = default) 
        { 
            var system = _promptLoader.LoadPrompt("agent", "services"); 
            var prompt = new StringBuilder(); 
            
            prompt.AppendLine(system); 
            prompt.AppendLine($"User: {userMessage}"); 
            prompt.Append("Agent:"); 
            
            var raw = (await _model.GenerateAsync(prompt.ToString(), ct)).Trim(); 
            
            if (raw.StartsWith("TOOL:", StringComparison.OrdinalIgnoreCase)) 
            { 
                var lines = raw.Split('\n', StringSplitOptions.RemoveEmptyEntries); 
                var toolLine = lines[0]; 
                var toolName = toolLine.Replace("TOOL:", "", StringComparison.OrdinalIgnoreCase).Trim(); 
                var result = string.Empty;

                if (toolName == "GENERATE_BIODATA")
                {
                    var resultLine = lines.Length > 1 ? string.Join("\r\n", lines) : "RESULT:";

                    result = resultLine.Split("RESULT:")[1];
                }
                else
                {
                    var argsLine = lines.Length > 1 ? lines[1] : "ARGS:";
                    var args = argsLine.Replace("ARGS:", "", StringComparison.OrdinalIgnoreCase).Trim();

                    result = _tools.Execute(toolName, args);
                }
                
                return new AgentResponse
                {
                    ToolName = toolName,
                    Result = result
                }; 
            } 
            
            return new AgentResponse
            {
                ToolName = "Unknown"
            }; 
        } 
    }
}
