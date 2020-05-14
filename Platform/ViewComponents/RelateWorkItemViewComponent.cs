using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Rokono_Control.DatabaseHandlers;
using Rokono_Control.Models;

namespace Platform.ViewComponents
{
    public class RelateWorkItemViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public RelateWorkItemViewComponent(RokonoControlContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IViewComponentResult Invoke(IncomingIdRequest ids)
        {
            ViewData["WorkItemId"] = ids.Id;
            ViewData["ProjectsId"] = ids.WorkItemType;
            return View();
        }
    }
}