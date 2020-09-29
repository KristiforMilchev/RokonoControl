namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;
    
    [ViewComponent(Name = "PublicFeedback")]

    public class PublicFeedbackViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public PublicFeedbackViewComponent(RokonoControlContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(int projectId)
        {
            using(var context = new DatabaseController(Context,Configuration))
            {
                ViewData["ProjectName"] = context.GetProjectName(projectId);
            }
           
            return View("/Views/Shared/Components/OutboundComponents/PublicFeedback/Default.cshtml");
        }
    }
}