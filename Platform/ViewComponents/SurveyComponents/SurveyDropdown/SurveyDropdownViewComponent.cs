namespace Platform.ViewComponents.SurveyComponents.SurveyDropdown
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Newtonsoft.Json;
    using Rokono_Control.Models;
    using TransportLayer.Models;

    [ViewComponent(Name = "SurveyDropdown")]
    public class SurveyDropdownViewComponent: ViewComponent
    {
        private readonly RokonoControlContext Context;
        private readonly IConfiguration Configuration;

        public SurveyDropdownViewComponent(RokonoControlContext context, IConfiguration configuration)
        {
            Context = context;
            Configuration = configuration;
        }
        public IViewComponentResult Invoke(GenericIdRequest current)
        {
            ViewData["Id"] = current.Data[0];
            ViewData["QuestionId"] = current.Data[1];
            ViewData["ComponentId"] = current.Data[2];
            if(current.Data[3] != null)
                ViewData["DataSource"] = JsonConvert.DeserializeObject<BindingDynamicSource>(current.Data[3].ToString());
            else
                ViewData["DataSource"] = null;

            return View("/Views/Shared/Components/Survey/SurveyDropdown/Default.cshtml");
        }
    }
}