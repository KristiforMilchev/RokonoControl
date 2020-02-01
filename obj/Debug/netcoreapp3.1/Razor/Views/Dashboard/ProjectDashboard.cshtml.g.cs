#pragma checksum "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58cd2c3ebeb62971f8ac2db00c43747cc1ac8590"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ProjectDashboard), @"mvc.1.0.view", @"/Views/Dashboard/ProjectDashboard.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58cd2c3ebeb62971f8ac2db00c43747cc1ac8590", @"/Views/Dashboard/ProjectDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ProjectDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/dist/ej2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
  
   
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    ViewData["Title"] = $"Add New User";
    var Project = ViewData["Project"] as Projects;
    var ProjectMembers = ViewData["ProjectMembers"] as List<BindingUserAccount>;
    var ProjectId = ViewData["ProjectId"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\n    object[type=\"image/svg+xml\"] {\n  vertical-align:middle;\n  display:inline-block;\n}\n\n\n</style>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "58cd2c3ebeb62971f8ac2db00c43747cc1ac85904750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
 
<!-- end of sidebar element -->
        <!-- main-content declaration -->
        <div class=""main-content"" id=""main-text"" style=""height: 94vh;"">
            <div class=""sidebar-content"">
<div class=""row"" style=""margin:0px;"">
    <div class=""col-md-3"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body text-center"">
                <div class=""row"">
                    <h3 class=""center"">About the Project</h3>
                </div>
                 <hr/>
                <div class=""row"">
                    <p style=""word-break: break-word; word-wrap: break-word;""> ");
#nullable restore
#line 32 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
                                                                          Write(Project.ProjectDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-md-5"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body text-center"">
                <div class=""row text-center"">
                    <h3 class=""center"">Project Stats</h3>
                </div>
                <hr/>
                <div class=""row"">
                  <div class=""control-section"">
                      <div id=""line-container"" align=""center""></div>
                  </div>
                </div>
                <div class=""row"">
                    <p> ");
#nullable restore
#line 50 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
                   Write(Project.Branches.Sum(x=>x.AssociatedBranchCommits.Count()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
    </div>
     <div class=""col-md-3"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body text-center"">
                <div class=""row"">
                    <h3 class=""center"">Project Members</h3>
                </div>
                <hr/>
                <div class=""row"">
");
#nullable restore
#line 63 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
                      
                        foreach(var member in ProjectMembers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"circle\">\n                                <a href=\"#\">");
#nullable restore
#line 67 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
                                       Write(member.AliasName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </div>\n");
#nullable restore
#line 69 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n                <hr/>\n                <div class=\"row\">\n                    <p>Project members count: ");
#nullable restore
#line 74 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
                                         Write(ProjectMembers.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
    </div>
</div>
   </div>
        </div>
<script src=""https://code.jquery.com/jquery-3.4.1.min.js"" ></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58cd2c3ebeb62971f8ac2db00c43747cc1ac859010001", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n <script>\n\n$(document).ready(function() {\n\n\n      var id = ");
#nullable restore
#line 92 "/home/kristifor/Projects/Webplatforms/RokonoControl/Views/Dashboard/ProjectDashboard.cshtml"
          Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        
          var dto = {
            ""id"": id,
            
        }
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Dashboard/GetCommitChartBindingData',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                InitChart(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
});

function InitChart(data)
{
    console.log(data);
    var bindingSeries = [];
    data.forEach(function(element) {
        console.log(element);
        var bindingItem =  
        { 
            ""x"": element.DateOfCommit, 
            ""y"": element.dayCount 
        }
        bindingSeries.push(bindingItem);
    });
   
     var chart = new ej.charts.Chart({
        //Initializing Primary X Axis
        primaryXAxis: {
            valueType: 'DateTime',
            labelFor");
            WriteLiteral(@"mat: 'y',
            edgeLabelPlacement: 'Shift',
            majorGridLines: { width: 0 }
        },
        //Initializing Primary X Axis
        primaryYAxis: {
            labelFormat: '{value}%',
            rangePadding: 'None',
            minimum: 0,
            maximum: 100,
            interval: 20,
            lineStyle: { width: 0 },
            majorTickLines: { width: 0 },
            minorTickLines: { width: 0 }
        },
        chartArea: {
            border: {
                width: 0
            }
        },
        //Initializing Chart Series
        series: [
            {
                type: 'Line',
                dataSource:  bindingSeries,
                xName: 'x', width: 2, marker: {
                    visible: true,
                    width: 10,
                    height: 10
                },
                yName: 'y', name: 'Commits Per day',
            }
        ],
        //Initializing Chart Title
        title: 'Commit tracker',
        //Initializing Tooltip
     ");
            WriteLiteral("   tooltip: {\n            enable: true\n        },\n        width: ej.base.Browser.isDevice ? \'100%\' : \'60%\',\n\n    });\n  //  chart.appendTo(\'#line-container\');\n}\n </script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
