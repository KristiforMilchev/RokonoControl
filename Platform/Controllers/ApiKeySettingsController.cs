namespace Platform.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;
    
    public class ApiKeySettingsController : Controller
    {
        RokonoControlContext Context;
        IConfiguration Configuration;

        public ApiKeySettingsController(RokonoControlContext context, IConfiguration config)
        {
            Context = context;
            Configuration = config;
        }

        public IActionResult ProjectApiKeys(int projectId)
        {
            ViewData["ProjectId"] = projectId;
            return View();
        }

        [HttpGet]
        public List<ApiKeys> GetProjectFeatures(int projectId)
        {
            var result = new List<ApiKeys>();
            using (var context = new ApiKeysContext(Context,Configuration))
            {
                 result = context.GetProjectApiKeys(projectId);
            }
            return result;
        }

        [HttpPost]
        public OutgoingJsonData EnableProjectFeature([FromBody] IncomignFeatureRequest request)
        {
         
            using(var context = new ApiKeysContext(Context,Configuration))
            {
                // if()
                //TODO Implement user right check

                context.EnableProjectFeature(request);
            }
            return new OutgoingJsonData{};
        }

        
  
        [HttpPost]
        public List<PublicMessages> GetAllFeedback([FromBody] IncomingIdRequest request)
        {
            var result = new List<PublicMessages>();
            using(var context = new ApiKeysContext(Context,Configuration))
            {   
                result = context.GetAllFeedback(request.Id);
            }
            return result;
        }

        
    }
}