namespace Platform.ViewComponents.Widgets
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;
 
    [ViewComponent(Name = "AssignedItems")]
    public class AssignedItemsViewComponent : ViewComponent
    {
 
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public AssignedItemsViewComponent(RokonoControlContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }
        public IViewComponentResult Invoke(IncomingIdRequest request)
        {
            ViewData["ProjectId"] = request.ProjectId;
            ViewData["DashboardId"] = request.Id;
            ViewData["Height"] = request.Phase;
            ViewData["ContainerId"] = request.WorkItemType;
            return View("/Views/Shared/Components/Widgets/AssignedItems/Default.cshtml");
        }
    }
}