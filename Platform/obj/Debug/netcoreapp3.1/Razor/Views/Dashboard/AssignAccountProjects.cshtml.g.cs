#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/AssignAccountProjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da269e41b74b82dc3788905f790cbba238a66eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_AssignAccountProjects), @"mvc.1.0.view", @"/Views/Dashboard/AssignAccountProjects.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da269e41b74b82dc3788905f790cbba238a66eca", @"/Views/Dashboard/AssignAccountProjects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_AssignAccountProjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/dist/ej2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/AssignAccountProjects.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/AssignAccountProjects.cshtml"
  
   
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var result = ViewData["UserAccount"] as OutgoingAccountManagment;
    var User = ViewData["UserId"] as int?;
    ViewData["Title"] = $"Editing {result.Name}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da269e41b74b82dc3788905f790cbba238a66eca5044", async() => {
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
 
<div class=""row"" style=""margin:0px;"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body text-center"">
         
               <div class=""row"" style=""padding:50px;"">
                   <div class=""col-md-6"" id=""ProjSettings"">
                       <div class=""row"">
                           <h3 class=""text-center""> Project Rights </h3>
                       </div>
                       <div class=""row"" style=""padding:10px;"">
                           <div class=""col-md-6"">
                                <div id=""commit"">
                                    <label for=""PCanCommit"" style=""padding: 10px 70px 10px 0""> Can Commit </label>
                                    <input id=""PCanCommit"" type=""checkbox"" />
                                </div>
                           </div>
                            <div class=""col-md-6"">
                                <div id=""clone"">
                                ");
            WriteLiteral(@"    <label for=""PCanClone"" style=""padding: 10px 70px 10px 0""> Can Clone </label>
                                    <input id=""PCanClone"" type=""checkbox"" />
                                </div>
                           </div>
                       </div>
                       <div class=""row"" style=""padding:10px;"">
                           <div class=""col-md-6"">
                                <div class=""InnerPadding"" id=""create"">
                                    <label for=""PCanCreateWork"" style=""padding: 10px 70px 10px 0""> Can Create Work Items </label>
                                    <input id=""PCanCreateWork"" type=""checkbox"" />
                                </div>
                           </div>
                            <div class=""col-md-6"">
                                <div id=""delete"">
                                    <label for=""PCanDeleteWork"" style=""padding: 10px 70px 10px 0""> Can Delete Work Items</label>
                                    <input id=""PCanDeleteWork"" t");
            WriteLiteral(@"ype=""checkbox"" />
                                </div>
                           </div>
                       </div>
                       <div class=""row"" style=""padding:10px;"">
                           <div class=""col-md-6"">
                                <div id=""view"">
                                    <label for=""PCanViewWork"" style=""padding: 10px 70px 10px 0""> Can View Work </label>
                                    <input id=""PCanViewWork"" type=""checkbox"" />
                                </div>
                           </div>
                       </div>
                   </div>
                    <div class=""col-md-6"">
                        <div class=""row"" style=""padding:10px;"">
                            <h4>Projects</h4>
                            <a href=""#"" class=""btn btn-block btn-info"" data-toggle=""modal"" data-target=""#ProjectsModal"" onclick=""OpenProjects()"" ><span class=""glyphicon glyphicon-file""></span> Assign to new project</a>
                        </div>
          ");
            WriteLiteral(@"              <div class=""row"" style=""padding:10px;"">
                             <div class=""control-section"">
                                <div class=""content-wrapper"">
                                    <div id=""Grid"">
                                    </div>
                                </div>
                            </div>
                        </div>
                   </div> 
               </div>
               <div class=""row"">
                    <a href=""#"" class=""btn btn-block btn-info"" onclick=""Close()""><span class=""glyphicon glyphicon-file"" ></span> Save Changes</a>
               </div>
            </div>
        </div>
    </div>
</div>

          
        <!-- end of main-content -->
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft");
            WriteLiteral(@"+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM"" crossorigin=""anonymous""></script>

 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da269e41b74b82dc3788905f790cbba238a66eca10912", async() => {
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
            WriteLiteral("\n <script>\nvar UserId = ");
#nullable restore
#line 91 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/AssignAccountProjects.cshtml"
        Write(User);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\nvar projectsRaw = \'");
#nullable restore
#line 92 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/AssignAccountProjects.cshtml"
              Write(result.Projects);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\nvar projects = JSON.parse(projectsRaw.replace(/&quot;/g, \'\"\'));\nvar CProject;\n    \n</script>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da269e41b74b82dc3788905f790cbba238a66eca12583", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
