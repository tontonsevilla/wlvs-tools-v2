using System.ComponentModel.DataAnnotations;
using WLVSToolsV2.Web.Common.Models.Agents;

namespace WLVSToolsV2.Web.Areas.AIAgent.Models.Generates
{
    public class PersonalInfoViewModel
    {
        public PersonalInfoViewModel()
        {
            ChatResponse = new AgentResponse();
        }

        public bool IsSubmitted { get; set; }

        [Required]
        public string? Country { get; set; }

        public AgentResponse? ChatResponse { get; set; }
    }
}
