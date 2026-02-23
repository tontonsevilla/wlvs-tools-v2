using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WLVSToolsV2.Web.WebInfrastructure.Filters
{
    public class NullModelFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Not needed for this scenario
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.Result is ViewResult viewResult)
            {
                if (viewResult.Model == null)
                { 
                    // Option A: Redirect to a global error page
                    // context.Result = new RedirectToActionResult("ModelNotFound", "Error", null); 
                    
                    // Option B: Throw a controlled exception 
                    throw new Exception("Model is null"); 
                    
                    // Option C: Replace with a default model 
                    // viewResult.Model = Activator.CreateInstance(viewResult.ViewData.ModelMetadata.ModelType);
                } 
            }
        }
    }
}
