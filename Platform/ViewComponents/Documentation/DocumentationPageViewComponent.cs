namespace Platform.ViewComponents.Documentation
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    [ViewComponent(Name = "DocumentationPage")]
    public class DocumentationPageViewComponent : ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;
        AutherizationManager AutherizationManager;
        int UserId;

        public DocumentationPageViewComponent(RokonoControlContext context, IConfiguration configuration, IAutherizationManager autherizationManager, IHttpContextAccessor httpContextAccessor)
        {
            Context = context;
            Configuration = configuration;
            AutherizationManager = (AutherizationManager)autherizationManager;
            UserId = AutherizationManager.GetCurrentUser(UserId,httpContextAccessor.HttpContext.Request);
        }
        public IViewComponentResult Invoke(IncomingIdRequest request)
        {
            ViewData["ProjectId"] = request.ProjectId;
            using (var context = new UsersContext(Context, Configuration))
                ViewData["UserRights"] = AutherizationManager.ValidateUserRights(request.ProjectId, UserId, context);
            using(var context = new DocumentationContext(Context,Configuration))
            {
                if (request.Id == 0)
                    request.Id = context.GetDocumentationDefaultCategory(request.ProjectId);
                ViewData["PageData"] = context.GetDocumentationPages(request);
            }
            ViewData["CategoryId"] = request.Id;
            return View("/Views/Shared/Components/Documentation/DocumentationPage/Default.cshtml");
        }
 
         
    }
}