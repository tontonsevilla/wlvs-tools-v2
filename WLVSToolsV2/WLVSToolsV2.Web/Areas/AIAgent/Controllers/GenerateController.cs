using Microsoft.AspNetCore.Mvc;
using WLVSToolsV2.Web.Areas.AIAgent.Models.Generates;
using WLVSToolsV2.Web.Common.Models.Chats;
using WLVSToolsV2.Web.Infrastructure.Services;

namespace WLVSToolsV2.Web.Areas.AIAgent.Controllers
{
    [Area("AIAgent")]
    public class GenerateController : Controller
    {
        private readonly IAgentService _agentService;
        private readonly PromptLoader _promptLoader;

        public GenerateController(IAgentService agentService,
            PromptLoader promptLoader)
        {
            _agentService = agentService;
            _promptLoader = promptLoader;
        }

        [HttpGet]
        public IActionResult PersonalInfo()
        {
            return View(new PersonalInfoViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> PersonalInfo(PersonalInfoViewModel viewModel, CancellationToken ct)
        {

            if (ModelState.IsValid)
            {
                var request = new ChatRequest
                {
                    Message = _promptLoader.LoadPrompt("biodata", "controllers/generates") + "\r\n"
                };
                
                request.Message = request.Message.Replace("[country]", viewModel.Country);
                viewModel.ChatResponse = await _agentService.ProcessAsync(request.Message, ct);
            }

            return View(viewModel);
        }
    }
}
