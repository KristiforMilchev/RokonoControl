#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b2138aa8952ba2ff2ba8d8739711349ebb2210f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ProjectDetails), @"mvc.1.0.view", @"/Views/Dashboard/ProjectDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b2138aa8952ba2ff2ba8d8739711349ebb2210f", @"/Views/Dashboard/ProjectDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ProjectDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RokonoControl/Platform/Views/Dashboard/ProjectDetails.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b2138aa8952ba2ff2ba8d8739711349ebb2210f4458", async() => {
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
        <div class=""main-content"" id=""main-text"" >
            <div class=""sidebar-content"">
<div class=""control-section"">
    <div style=""padding:5px;text-align: right;"">
        <button id=""add"" class=""e-btn e-info"">Add Panel</button>
    </div>
    <div id=""defaultLayout"">
        <div id=""one"" class=""e-panel"" data-row=""0"" data-col=""0"" data-sizeX=""1"" data-sizeY=""1"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
                <div class=""text-align"">0</div>
            </div>
        </div>
        <div id=""two"" class=""e-panel"" data-row=""1"" data-col=""0"" data-sizeX=""1"" data-sizeY=""2"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
                <div class=""text-align"">1</div>
            </div>
        </div>
        <div id=""three"" class=""e-panel"" data-row=""0"" data-col=""1"" data-sizeX=""2""");
            WriteLiteral(@" data-sizeY=""2"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
                <div class=""text-align"">2</div>
            </div>
        </div>
        <div id=""four"" class=""e-panel"" data-row=""2"" data-col=""1"" data-sizeX=""1"" data-sizeY=""1"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
                <div class=""text-align"">3</div>
            </div>
        </div>
        <div id=""five"" class=""e-panel"" data-row=""2"" data-col=""2"" data-sizeX=""2"" data-sizeY=""1"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
                <div class=""text-align"">4</div>
            </div>
        </div>
        <div id=""six"" class=""e-panel"" data-row=""0"" data-col=""3"" data-sizeX=""1"" data-sizeY=""1"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
  ");
            WriteLiteral(@"              <div class=""text-align"">5</div>
            </div>
        </div>
        <div id=""seven"" class=""e-panel"" data-row=""1"" data-col=""3"" data-sizeX=""1"" data-sizeY=""1"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
                <div class=""text-align"">6</div>
            </div>
        </div>
        <div id=""eight"" class=""e-panel"" data-row=""0"" data-col=""4"" data-sizeX=""1"" data-sizeY=""3"">
            <span id=""close"" class=""e-template-icon e-clear-icon""></span>
            <div class=""e-panel-container"">
                <div class=""text-align"">7</div>
            </div>
        </div>
    </div>
    <div id=""headerTemplate"">
        <span id=""close"" class=""e-template-icon e-clear-icon""></span>
    </div>
    <div id=""content""></div>
</div>
<div id=""action-description"">
    <p>
        The following sample demonstrates the default functionalities of the DashboardLayout component. Click the <code>Add Panel</code> button to add pan");
            WriteLiteral(@"els dynamically to the dashboard layout.
    </p>
</div>

<div id=""description"">
    <p>
        The DashboardLayout component provides the capability to arrange, <a href=""https://ej2.syncfusion.com/javascript/documentation/api/dashboard-layout#allowresizing"" target=""_blank"">resize</a> and 
        reorder the panels within the dashboard layout.
    </p>

</div>

           </div>
        </div>

         <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b2138aa8952ba2ff2ba8d8739711349ebb2210f9924", async() => {
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
            WriteLiteral(@"
<style>
    #defaultLayout {
        padding: 10px;
    }
    
    .e-dashboardlayout.e-control .e-panel:hover span {
        display: block;
    }
    
    #defaultLayout .e-panel .e-panel-container .text-align {
        vertical-align: middle;
        font-weight: 600;
        font-size: 20px;
        text-align: center;
    }
    
    .e-template-icon {
        padding: 10px;
        float: right;
        display: none;
    }
    
    .e-clear-icon::before {
        content: '\e100';
        font-size: 12px;
        font-family: 'ej-icon';
    }

    ");
            WriteLiteral(@"@font-face {
        font-family: 'ej-icon';
        src:
        url(data:application/x-font-ttf;charset=utf-8;base64,AAEAAAAKAIAAAwAgT1MvMjdtQ/IAAAEoAAAAVmNtYXDhEOFVAAABiAAAADZnbHlmq8jV4gAAAcgAAAFQaGVhZBSREIsAAADQAAAANmhoZWEIUAQDAAAArAAAACRobXR4CAAAAAAAAYAAAAAIbG9jYQCoAAAAAAHAAAAABm1heHABDQCUAAABCAAAACBuYW1lWD3y/QAAAxgAAAIlcG9zdMl9cHoAAAVAAAAALwABAAAEAAAAAFwEAAAAAAAD8wABAAAAAAAAAAAAAAAAAAAAAgABAAAAAQAAjGeuW18PPPUACwQAAAAAANi/5c0AAAAA2L/lzQAAAAAD8wP0AAAACAACAAAAAAAAAAEAAAACAIgAAQAAAAAAAgAAAAoACgAAAP8AAAAAAAAAAQQAAZAABQAAAokCzAAAAI8CiQLMAAAB6wAyAQgAAAIABQMAAAAAAAAAAAAAAAAAAAAAAAAAAAAAUGZFZABA4QDhAAQAAAAAXAQAAAAAAAABAAAAAAAABAAAAAQAAAAAAAACAAAAAwAAABQAAwABAAAAFAAEACIAAAAEAAQAAQAA4QD//wAA4QD//wAAAAEABAAAAAEAAAAAAAAAqAAAAAEAAAAAA/MD9ACHAAAJAi8GKwEPDR0BHwYJAQ8GHQEfDTsBPwYJAR8GOwE/Di8HCQE/Bj0BLw0rAQ8FA3T+jP6MBQYHBgcHCAcHBwcHBwYGBgUFAwMDAgEBAgMDAwUFAXT+jAUFAwMDAgEBAgMDAwUFBgYGBwcHBwcHBwgGBwYHBQF0AXQFBgcGBwcIBwcHBwcHBgYGBQQEAwMBAQEBAQEDAwQEBf6MAXQFBQMDAwIBAQIDAwMFBQYGBgcHBwcHBwgHBwYHBgPe/owBdAUFAwMDAgEBAgMDAwUFBgYGB");
            WriteLiteral(@"wcHBwcHCAcGBwYHBf6M/owFBwYHBgcIBwcHBwcHBgYGBQUDBAICAQECAgQDBQUBdP6MBQUDBAICAQECAgQDBQUGBgYHBwcHBwcIBwYHBgcFAXQBdAYGBgcHBwcHBwcHBwcGBgYFBQMEAgIBAQIDAwMFAAAAEgDeAAEAAAAAAAAAAQAAAAEAAAAAAAEABwABAAEAAAAAAAIABwAIAAEAAAAAAAMABwAPAAEAAAAAAAQABwAWAAEAAAAAAAUACwAdAAEAAAAAAAYABwAoAAEAAAAAAAoALAAvAAEAAAAAAAsAEgBbAAMAAQQJAAAAAgBtAAMAAQQJAAEADgBvAAMAAQQJAAIADgB9AAMAAQQJAAMADgCLAAMAAQQJAAQADgCZAAMAAQQJAAUAFgCnAAMAAQQJAAYADgC9AAMAAQQJAAoAWADLAAMAAQQJAAsAJAEjIGVqLWljb25SZWd1bGFyZWotaWNvbmVqLWljb25WZXJzaW9uIDEuMGVqLWljb25Gb250IGdlbmVyYXRlZCB1c2luZyBTeW5jZnVzaW9uIE1ldHJvIFN0dWRpb3d3dy5zeW5jZnVzaW9uLmNvbQAgAGUAagAtAGkAYwBvAG4AUgBlAGcAdQBsAGEAcgBlAGoALQBpAGMAbwBuAGUAagAtAGkAYwBvAG4AVgBlAHIAcwBpAG8AbgAgADEALgAwAGUAagAtAGkAYwBvAG4ARgBvAG4AdAAgAGcAZQBuAGUAcgBhAHQAZQBkACAAdQBzAGkAbgBnACAAUwB5AG4AYwBmAHUAcwBpAG8AbgAgAE0AZQB0AHIAbwAgAFMAdAB1AGQAaQBvAHcAdwB3AC4AcwB5AG4AYwBmAHUAcwBpAG8AbgAuAGMAbwBtAAAAAAIAAAAAAAAACgAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAgECAQMABWNsb3NlAAAA) format('truetype');
        font-weight: normal;
        font-style: no");
            WriteLiteral(@"rmal;
    }
    
    .text-align {
        line-height: 160px;
    }
    
    .e-clear-icon {
        position: absolute;
        right: 0;
        cursor: pointer;
    }
    
    .sb-demo-section .container-fluid {
        background: #E5E5E5;
    }
</style>

<script>


 var dashboard = new ej.layouts.DashboardLayout({
        cellSpacing: [10, 10],
        columns: 5,
        allowResizing: true,
    });
dashboard.appendTo('#defaultLayout');
var dashboardObject = document.getElementById('defaultLayout').ej2_instances[0];
var count = 8;
document.getElementById('add').onclick = function (e) {
    var panel = [{
        'id': count.toString() + '_layout', 'sizeX': 1, 'sizeY': 1, 'row': 0, 'col': 0,
        content: '<span id=""close"" class=""e-template-icon e-clear-icon""></span><div class=""text-align"">' + count.toString() + '</div>'
    }];
    dashboardObject.addPanel(panel[0]);
    var closeIcon = document.getElementById(count.toString() + '_layout').querySelector('.e-clear-icon');
    closeIcon.addEventListen");
            WriteLiteral(@"er('click', onCloseIconHandler);
    count = count + 1;
};
function onCloseIconHandler(event) {
    if (event.target.offsetParent) {
        dashboardObject.removePanel(event.target.offsetParent.id);
    }

}
var closeElement = document.querySelectorAll('.e-clear-icon');
for (var i = 0; i < closeElement.length; i++) {
    closeElement[i].addEventListener('click', onCloseIconHandler);
}
</script>");
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
