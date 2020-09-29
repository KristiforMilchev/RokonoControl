
namespace Platform.ViewComponents
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    public class NotesViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;
        private  AutherizationManager AutherizationManager;
        private int UserId;
 
        public NotesViewComponent(RokonoControlContext context, IConfiguration config, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = config;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }
        public IViewComponentResult Invoke(int projectId)
        {
    
            using(var context = new NotesContext(Context,Configuration))
            {
                var Notes =  context.GetUserNotes(UserId, projectId);
                ViewData["Notes"] = Notes;
                
            }
            return View();
        }
        
    }
}