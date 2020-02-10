#pragma checksum "D:\RokonoControl\Views\Dashboard\WorkItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5d25737676b7367a7692a6ecd1fe06f3a09d6dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_WorkItems), @"mvc.1.0.view", @"/Views/Dashboard/WorkItems.cshtml")]
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
#line 1 "D:\RokonoControl\Views\_ViewImports.cshtml"
using Rokono_Control;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RokonoControl\Views\_ViewImports.cshtml"
using Rokono_Control.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5d25737676b7367a7692a6ecd1fe06f3a09d6dc", @"/Views/Dashboard/WorkItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_WorkItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\RokonoControl\Views\Dashboard\WorkItems.cshtml"
  
    ViewData["Title"] = "Backlog";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var result = ViewData["ProjectId"] as int?;
    var BoardId = ViewData["BoardId"] as int?;
 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5d25737676b7367a7692a6ecd1fe06f3a09d6dc4476", async() => {
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
<style>
.image {
    height: 55px;
    width: 55px;
    border-radius: 50px;
    box-shadow: inset 0 0 1px #000000, inset 0 0 14px rgba(0, 0, 0, 0.2);
    margin-left: 30%;
    margin-right: 30%;
}
</style>

<!-- end of sidebar element -->
        <!-- main-content declaration -->
        <div class=""main-content"" id=""main-text"" style=""height: 94vh;"">
            <div class=""sidebar-content"">
<div class=""row"" style=""margin:0px;"">
<div class=""col-md-12"">
  <div class=""main-card mb-3 card"">
        <div class=""card-body"">
           <div class=""row"" style=""margin-left:10px;"">
                <div class=""dropdown d-inline-block"">
                    <button type=""button"" aria-haspopup=""true"" aria-expanded=""false"" data-toggle=""dropdown"" class=""mb-2 mr-2 dropdown-toggle btn btn-outline-info"">New Work Item</button>
                    <div tabindex=""-1"" role=""menu"" aria-hidden=""true"" class=""dropdown-menu"">
                        <button type=""button"" tabindex=""0"" class=""dropdown-item"" oncl");
            WriteLiteral(@"ick=""CreateNewWorkItem(5)"">Epic</button>
                        <button type=""button"" tabindex=""0"" class=""dropdown-item"" onclick=""CreateNewWorkItem(2)"">Feature</button>
                        <button type=""button"" tabindex=""0"" class=""dropdown-item"" onclick=""CreateNewWorkItem(7)"">User Story</button>
                        <button type=""button"" tabindex=""0"" class=""dropdown-item"" onclick=""CreateNewWorkItem(3)"">Task</button>
                        <button type=""button"" tabindex=""0"" class=""dropdown-item"" onclick=""CreateNewWorkItem(1)"">Bug</button>
                        <button type=""button"" tabindex=""0"" class=""dropdown-item"" onclick=""CreateNewWorkItem(6)"">Issue</button>
                        <button type=""button"" tabindex=""0"" class=""dropdown-item"" onclick=""CreateNewWorkItem(7)"">Test</button>
                    </div>
                </div>
            </div>
           <div class=""control-section"">
                <div class=""content-wrapper"">
                    <div id=""TreeGrid"" style=""heig");
            WriteLiteral(@"ht:80vh;""></div>
                </div>
            </div>
        </div>
    </div>
</div>
</div>
   </div>
        </div>
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
 
 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5d25737676b7367a7692a6ecd1fe06f3a09d6dc8548", async() => {
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
            WriteLiteral("\r\n<script id=\"template\" type=\"text/x-template\">\r\n    <div class=\"image\">\r\n        <i class=\"${workItemIcon}\" style=\"padding: 10px;font-size: xx-large;color: cadetblue;\"></i>\r\n \r\n    </div>\r\n</script>\r\n <script>\r\n     var ProjectId = ");
#nullable restore
#line 66 "D:\RokonoControl\Views\Dashboard\WorkItems.cshtml"
                Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    function OpenWorkItem(id)\r\n    {\r\n        console.log(id);\r\n    }\r\n    $( document ).ready(function() \r\n    {\r\n        var id = ");
#nullable restore
#line 73 "D:\RokonoControl\Views\Dashboard\WorkItems.cshtml"
            Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        
          var dto = {
            ""id"": id,
            ""WorkItemType"":5
        }
        console.log(dto);
        $.ajax({
            type: 'POST',
            url: '/Backlogs/GetWorkItems',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                InitiliazeGrid(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
        });
        
    });
    function InitiliazeGrid(data )
    {
        console.log(data);
        var grid = new ej.grids.Grid({
        dataSource: data,
        recordDoubleClick: recordDoubleClick,

        columns: [
                {
                    headerText: 'Icon', textAlign: 'Center',
                    template: '#template', width: 150
                },
                { field: 'WorkItemType.TypeName', headerText: 'Type Name',");
            WriteLiteral(@" width: 125 },
                { field: 'title', headerText: 'Title', width: 125 },
                { field: 'description', headerText: 'Description', width: 180 },
                { field: 'assignedAccountNavigation.Email', headerText: 'AssignedTo', width: 110 },
            ]
        });
        grid.appendTo('#TreeGrid');
 
    }
    function CreateNewWorkItem(id){
        ProjectId = ");
#nullable restore
#line 117 "D:\RokonoControl\Views\Dashboard\WorkItems.cshtml"
               Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        boardId = ");
#nullable restore
#line 118 "D:\RokonoControl\Views\Dashboard\WorkItems.cshtml"
             Write(BoardId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        window.location.href = ""/Dashboard/AddNewWorkItem?projectId=""+ProjectId+""&workItemType=""+id+""&parentId=0"";
    }
    function WorkItemSelected(args){
        console.log(args);
    }
    function load(args) {
        this.parentDetails.parentKeyFieldValue = this.parentDetails.parentRowData['id'];
    }

    function recordDoubleClick(args)
    {
        console.log(args);
 //       args.rowData.id
        window.location.href = ""/Dashboard/EditWorkItem?projectId=");
#nullable restore
#line 132 "D:\RokonoControl\Views\Dashboard\WorkItems.cshtml"
                                                             Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("&&workItem=\"+args.rowData.id;\r\n    }\r\n </script>\r\n\r\n\r\n");
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
