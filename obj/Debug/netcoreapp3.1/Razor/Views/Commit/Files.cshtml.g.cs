#pragma checksum "D:\RokonoControl\Views\Commit\Files.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92c8c31e40c6f408f2c38750f7e601a3cfd652df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Commit_Files), @"mvc.1.0.view", @"/Views/Commit/Files.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c8c31e40c6f408f2c38750f7e601a3cfd652df", @"/Views/Commit/Files.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Commit_Files : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/material.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\RokonoControl\Views\Commit\Files.cshtml"
  
    ViewData["Title"] = "Files";
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var ProjectId = ViewData["ProjectId"];
    var BranchId = ViewData["BranchId"];
    var Branches = ViewData["Branches"] as List<Branches>; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n\r\n.TreeHolder {\r\n    display: block;\r\n    max-width: 100%;\r\n    max-height: 80vh;\r\n    margin: auto;\r\n    overflow: auto;\r\n    border: 1px solid #dddddd;\r\n    background-color: white;\r\n    border-radius: 3px;\r\n}\r\n\r\n</style>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "92c8c31e40c6f408f2c38750f7e601a3cfd652df4464", async() => {
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
<div class=""container-fluid"">
    <div class=""row card"">
        <div class=""control-wrapper"">
            <div id=""default"" style='padding:20px;'>
                <select id=""games""> 
");
#nullable restore
#line 32 "D:\RokonoControl\Views\Commit\Files.cshtml"
                      
                        foreach(var branch in Branches)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92c8c31e40c6f408f2c38750f7e601a3cfd652df6269", async() => {
#nullable restore
#line 35 "D:\RokonoControl\Views\Commit\Files.cshtml"
                                                  Write(branch.BranchName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "D:\RokonoControl\Views\Commit\Files.cshtml"
                               WriteLiteral(branch.Id);

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
            WriteLiteral("\r\n");
#nullable restore
#line 36 "D:\RokonoControl\Views\Commit\Files.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </select>
            </div>
        </div>
    </div>
    <div class=""card"">
        <div class=""row"">
            <div class=""col-md-3"">
                <div class=""TreeHolder"">
                    <div id=""tree""></div>
                </div>
            </div>
            <div class=""col-md-8"">
                <div id=""CodeHolder"" style=""height:80vh;width:100%;border:1px solid grey""></div>
            </div>
        </div>
    </div>
 </div>
    </div>
        </div>
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnju");
            WriteLiteral(@"UD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>

<script>
var editor;
var SelectedId;
var treeObj;
require.config({ paths: { 'vs': '/Syncfusion/node_modules/monaco-editor/min/vs' }});
	require(['vs/editor/editor.main'], function() {
	    editor = monaco.editor.create(document.getElementById('CodeHolder'), {
			value: [
				 ""Console.WriteLine(\""Works\"")""
			].join('\n'),
			language: 'csharp'
		});
	});

    
    var BindingData ;
    $( document ).ready(function() 
    {
        SelectedId = ");
#nullable restore
#line 79 "D:\RokonoControl\Views\Commit\Files.cshtml"
                Write(BranchId);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        InitBranches();\r\n        $.ajax({\r\n            type: \'GET\',\r\n            url: \'/Commit/GetBranchFiles?projectId=");
#nullable restore
#line 83 "D:\RokonoControl\Views\Commit\Files.cshtml"
                                              Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&&branchId='+SelectedId,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                console.log(response);
                LoadCommitHirarchy(response);
            },
            error: function (xhr, status, error) {
    
            }
        });
     
    });
    function InitBranches()
    {
                  // Initialize DropDownList component
        var listObj = new ej.dropdowns.DropDownList({
            // set the index value to select an item based on index at initial rendering
            index: 2,
            // set the placeholder to DropDownList input element
            placeholder: 'Select a branch',
            // set the height of the popup element
            popupHeight: '200px',
            // bind the change event
            change: BranchChanged
        });
        listObj.appendTo('#games');
        // call the change event's function after initialized the component.");
            WriteLiteral(@"
        
    }


    function BranchChanged(args)
    {
        console.log(args);
    }
    function LoadCommitHirarchy(data)
    {
        BindingData = data;
        treeObj = new ej.navigations.TreeView({
            fields: { dataSource: data, id: 'id', text: 'name', child: 'subChild', value: 1, IId: ""internalId"" },
            nodeClicked: ItemSelected

        });
        treeObj.appendTo('#tree');
            
    }
    
    function ItemSelected(args)
    {
        var data = treeObj.getTreeData(args.node);
      //  console.log(data);
        ShowSelectedFile(data);
    }

    function ShowSelectedFile(file)
    {
     //   console.log(file[0]);
        $(""#CodeHolder"").html("""");
           $.ajax({
            type: 'GET',
            url: '/Commit/GetSelectedFile?fileName='+file[0].fullPathName+""&projectId=");
#nullable restore
#line 144 "D:\RokonoControl\Views\Commit\Files.cshtml"
                                                                                 Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"&branch=""+SelectedId,
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
              //  console.log(response);
                editor = monaco.editor.create(document.getElementById('CodeHolder'), {
                    value:  response.data,
                    language:  response.languageType
                });
             
            },
            error: function (xhr, status, error) {
                console.log(xhr);
            }
        });
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
