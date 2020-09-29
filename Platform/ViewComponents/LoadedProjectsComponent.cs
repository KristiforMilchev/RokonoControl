namespace Platform.ViewComponents
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    public class LoadedProjectsViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;
        private  AutherizationManager AutherizationManager;
        private int UserId;
 
        public LoadedProjectsViewComponent(RokonoControlContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }

        public IViewComponentResult Invoke(int projectId)
        {
              var projects = new List<Projects>();
             using(var context = new UsersContext(Context,Configuration))
                projects =  context.GetUserProjects(UserId);
            using(var context = new DatabaseController(Context,Configuration))
            {
                var current = projects.FirstOrDefault(x=>x.Id == projectId);
                ViewData["Projects"] = projects;
                ViewData["SelectedIndex"] = projects.IndexOf(current);
     
            }
           
            return View();
        }
    }
}