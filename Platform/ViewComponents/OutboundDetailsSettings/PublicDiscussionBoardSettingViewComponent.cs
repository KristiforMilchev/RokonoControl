
namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;
    
    [ViewComponent(Name = "PublicDiscussionBoardSetting")]

    public class PublicDiscussionBoardSettingViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public PublicDiscussionBoardSettingViewComponent(RokonoControlContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(int projectId)
        {
            using(var context = new OutboundDetailsContext(Context,Configuration))
                ViewData["RuleValuePublicMessage"] = context.GetProjectActiveRule(projectId,"PublicMessage");

            using(var context = new ApiKeysContext(Context, Configuration))
            {
                var result = context.GetProjectApiKey(projectId, "PublicMessage");
                ViewData["ProjectKeyPublicMessage"] = result;
                if(result == null)
                    return View("/Home/Error");
            }
            ViewData["ProjectId"] = projectId;
            return View("/Views/Shared/Components/OutboundDetailsSettings/PublicDiscussionBoardSetting/Default.cshtml");
        }
    }
}