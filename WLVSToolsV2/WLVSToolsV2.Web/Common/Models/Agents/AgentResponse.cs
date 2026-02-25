namespace WLVSToolsV2.Web.Common.Models.Agents
{
    public class AgentResponse
    {
        public string? ToolName { get; set; }
        public string? Result { get; set; }

        public bool HasResult
        {
            get
            {
                return !string.IsNullOrWhiteSpace(Result);
            }
        }
    }
}
