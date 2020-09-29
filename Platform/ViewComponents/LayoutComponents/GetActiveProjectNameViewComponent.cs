namespace Platform.ViewComponents.LayoutComponents
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    [ViewComponent(Name = "GetProjectName")]
    public class GetActiveProjectNameViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public GetActiveProjectNameViewComponent(RokonoControlContext context, IConfiguration configuration)
        {
            Context = context;
            Configuration = configuration;
        }

        public IViewComponentResult Invoke(int id)
        {
            using(var context = new DatabaseController(Context,Configuration))
            ViewData["ProjectName"] = context.GetProjectName(id);
            return View("/Views/Shared/Components/LayoutComponents/ProjectSpecific/ProjectName.cshtml");
        }
    }
}