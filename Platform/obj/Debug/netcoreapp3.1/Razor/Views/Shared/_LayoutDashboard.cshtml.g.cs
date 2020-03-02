#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95967a17fd45652174580e8d88e0fa2af39fa4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutDashboard), @"mvc.1.0.view", @"/Views/Shared/_LayoutDashboard.cshtml")]
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95967a17fd45652174580e8d88e0fa2af39fa4a", @"/Views/Shared/_LayoutDashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutDashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Shared/_LayoutDashboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Logo/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50%;height:59%; margin-left:25%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
  
    var builds = ViewData["Builds"] as List<Builds>;
    var relationships = ViewData["Relationships"] as List<WorkItemRelations>;
    var ProjectId = ViewData["ProjectId"];
    var Projects = ViewData["Projects"] as List<Projects>;
    var defaultIteration = ViewData["DefaultIteration"] as int?;
    var IsAdmin = ViewData["IsAdmin"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!doctype html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f95967a17fd45652174580e8d88e0fa2af39fa4a5892", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f95967a17fd45652174580e8d88e0fa2af39fa4a6150", async() => {
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


    <script src=""https://cdn.syncfusion.com/ej2/dist/ej2.min.js"" type=""text/javascript""></script>
    <link href=""https://cdn.syncfusion.com/ej2/material.css"" rel=""stylesheet"">
    <link href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f95967a17fd45652174580e8d88e0fa2af39fa4a8297", async() => {
                WriteLiteral(@"
    <style>
        .table-content {
            padding: 0;
        }
    </style>
    <div class=""stackblitz-container material"">
        <div class=""control-section"">

            <!-- sample level element  -->
            <div id=""wrapper"">

                <!--header-section  declaration -->
                <div class=""main-header"" id=""header-section"">
                    <ul class=""header-list"">
                        <li class=""float-left header-style icon-menu"" id=""hamburger""></li>
                        <li class=""float-left header-style nav-pane"">
                            <b>Rokono Control</b>
                        </li>
                        <li class=""header-style float-right support border-left""><b>Support</b></li>
                    </ul>
                </div>
                <!-- end of header-section -->
                <!-- sidebar element declaration -->
                <aside id=""sidebar-treeview"">
                    <div class=""main-menu"">
                        <div class=""t");
                WriteLiteral("able-content\" style=\"padding:0;\">\n");
#nullable restore
#line 47 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                             if (IsAdmin == 1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <button  type=\"button\" id=\"Persons\" class=\"btn btn-primary\" style=\"margin-top:2px; width:100%\" onclick=\"CallUrl(\'/Dashboard/AddNewProject?user=\')\">Add new project</button>\n");
#nullable restore
#line 50 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div id=\"default\" style=\'padding-top:75px;\'>\n                                <select id=\"projects\">\n");
#nullable restore
#line 54 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                     foreach (var project in Projects)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f95967a17fd45652174580e8d88e0fa2af39fa4a10914", async() => {
#nullable restore
#line 56 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                               Write(project.ProjectName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                           WriteLiteral(project.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
#nullable restore
#line 57 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                </select>\n                            </div>\n                            <div class=\"row\" style=\"background-color:#4fb9fc; margin:0;\">\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f95967a17fd45652174580e8d88e0fa2af39fa4a13294", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>

                            <div class=""row"" style=""margin:0;"">
                                <input type=""text"" placeholder=""Search..."" style=""width:100%;"" class=""search-icon"">
                            </div>
                            <div class=""row"" style=""margin:0;"">
                                <p class=""main-menu-header"">Navigation</p>

                            </div>
                            <div class=""row"" style=""margin:0;"">
                                <div>
                                    <ul id=""main-treeview"">
                                    </ul>
                                </div>
                            </div>

                        </div>



                    </div>
                </aside>


                ");
#nullable restore
#line 87 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            </div>


        </div>

    </div>

    <script>
        ej.base.enableRipple(true);

         var Persons = new ej.buttons.Button({ cssClass: 'e-outline', isPrimary: true });
        Persons.appendTo('#Persons');

        var projects = new ej.dropdowns.DropDownList({

        // set the placeholder to DropDownList input element
        placeholder: 'Select Project',
        // set the height of the popup element
        popupHeight: '200px',
        index: 0,
        // bind the change event
        change: ProjectChanged
    });
    projects.appendTo('#projects');
    var data;
    // Sidebar Initialization
    var sidebarMenu = new ej.navigations.Sidebar({
        width: '290px',
        target: '.main-content',
        mediaQuery: '(min-width: 600px)',
    });
    sidebarMenu.appendTo('#sidebar-treeview');
    //end of Sidebar initialization

    // Toggle the Sidebar
    document.getElementById('hamburger').addEventListener('click', function () {
        sidebarMenu.toggle();
    });
    ");
                WriteLiteral(@"// open new tab
    var URL = location.href.replace(location.search, '');
  //  document.getElementById('newTab').setAttribute('href', URL.split('#')[0] + 'sidebar/responsive-panel/index.html');
    data = [

        {
            nodeId: '01', nodeText: 'Dashboard', iconCss: 'icon-th icon',
            nodeChild: [
                { nodeId: '01-01', nodeText: 'Home', iconCss: 'icon-circle-thin icon', link:'/Dashboard/ProjectDashboard?id=");
#nullable restore
#line 135 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                       Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' },
                { nodeId: '01-02', nodeText: 'Project Details', iconCss: 'icon-circle-thin icon', link:'/Dashboard/ProjectDetails' },
                { nodeId: '01-03', nodeText: 'Manage Accounts', iconCss: 'icon-circle-thin icon', link:'/Dashboard/ManageAccounts?id=");
#nullable restore
#line 137 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                                Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' },\n                { nodeId: \'01-04\', nodeText: \'Generate Changelog\', iconCss: \'icon-circle-thin icon\', link:\'/Dashboard/ChangelogGenerator?projectId=");
#nullable restore
#line 138 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                                              Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' },
            ]
        },
        {
            nodeId: '02', nodeText: 'Backlog', iconCss: 'icon-code icon',
            nodeChild: [
                { nodeId: '02-01', nodeText: 'Work Items', iconCss: 'icon-circle-thin icon', link: '/Backlogs/Index?projectId=");
#nullable restore
#line 144 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                         Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral("&&boardId\' },\n                { nodeId: \'02-02\', nodeText: \'Planning Boards\', iconCss: \'icon-circle-thin icon\', link: \'/Boards/Index?projectId=");
#nullable restore
#line 145 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                            Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\' },\n                { nodeId: \'02-03\', nodeText: \'Backlog\', iconCss: \'icon-circle-thin icon\', link: \'/Boards/ProjectBacklog?projectId=");
#nullable restore
#line 146 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                             Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral("&&workItemType=5\' },\n                { nodeId: \'02-04\', nodeText: \'Sprints\', iconCss: \'icon-circle-thin icon\', link: \'/Boards/Sprints?projectId=");
#nullable restore
#line 147 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                      Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral("&&workItemType=7&&iteration=");
#nullable restore
#line 147 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                                                            Write(defaultIteration);

#line default
#line hidden
#nullable disable
                WriteLiteral("&&person=0\' },\n                { nodeId: \'02-05\', nodeText: \'View Changelogs\', iconCss: \'icon-circle-thin icon\', link: \'/Changelog/ViewChangelogs?projectId=");
#nullable restore
#line 148 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Shared/_LayoutDashboard.cshtml"
                                                                                                                                        Write(ProjectId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"' },

            ]
        },

    ];
    console.log(data);
    // TreeView  initialization
    var mainTreeView= new ej.navigations.TreeView({
        fields: { dataSource: data, id: 'nodeId', text: 'nodeText', child: 'nodeChild' },nodeSelected: LinkSelected, expandOn: 'Click'
    });

    mainTreeView.appendTo('#main-treeview');

    function LinkSelected(args)
    {
        console.log(args);
        data.forEach(element =>
        {
            console.log(element);
            element.nodeChild.forEach(child =>
            {
                if(child.nodeId === args.nodeData.id)
                    window.location.href = child.link;
            });
        });

      // console.log(data.find(x => x.nodeChild.nodeId === args.nodeData.id));
    }

            function ProjectChanged(args) {
                console.log(args);
                window.location.href = ""/Dashboard/ProjectDashboard?id="" + parseInt(args.value);
            }

            function CallUrl(url)
            {
                window.");
                WriteLiteral("location.href = url;\n            }\n    </script>\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n\n\n");
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
