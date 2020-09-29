namespace Platform.ViewComponents.SurveyComponents.SurveyInput
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    [ViewComponent(Name = "SurveyInput")]
    public class SurveyInputViewComponent : ViewComponent
    {
        
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public SurveyInputViewComponent(RokonoControlContext context, IConfiguration configuration)
        {
            Context = context;
            Configuration = configuration;
        }
        public IViewComponentResult Invoke(int id)
        {
            ViewData["Id"] = IdGenerator.GetRandomId();
            return View("/Views/Shared/Components/Survey/SurveyInput/Default.cshtml");
        }
    }
}