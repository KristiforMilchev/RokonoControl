#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/AddNewAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abbbe823a386ff263c6e08e8fabe955ba1ea5192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_AddNewAccount), @"mvc.1.0.view", @"/Views/Dashboard/AddNewAccount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abbbe823a386ff263c6e08e8fabe955ba1ea5192", @"/Views/Dashboard/AddNewAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_AddNewAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Syncfusion/ej2/dist/ej2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Dashboard/AddNewAccount.cshtml"
  
   
    Layout = "~/Views/Shared/_LayoutDashboard.cshtml";
    var result = ViewData["UserAccount"] as OutgoingAccountManagment;
    var User = ViewData["UserId"] as int?;
    ViewData["Title"] = $"Add New User";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n \n  <!-- end of sidebar element -->\n<<<<<<<");
            BeginWriteAttribute("HEAD:Platform/Views/Dashboard/AddNewAccount.cshtml", " HEAD:Platform/Views/Dashboard/AddNewAccount.cshtml\n \n=", 262, "", 317, 0);
            EndWriteAttribute();
            WriteLiteral(@"======
        <!-- main-content declaration -->
        <div class=""main-content"" id=""main-text"" style=""height: 94vh;"">
            <div class=""sidebar-content"">
>>>>>>> changing the UI interface to use only controls due to copyright issues with the last template as it can't be redustributed under MIT, adding base logic for linking work items. Removing a bug causing work items to be duplicated. Upgrading the kahaban board to v2 syncfusion:Views/Dashboard/AddNewAccount.cshtml
<div class=""row"" style=""margin:0px;"">
    <div class=""col-md-12"">
        <div class=""main-card mb-3 card"">
            <div class=""card-body text-center"">
               <div class=""row"" style=""padding:50px;"">
                    <div class=""col-md-4"">
                        <input id=""Email"" />
                    </div>
                    <div class=""col-md-4"">
                        <input id=""Password"" />

                    </div>
                    <div class=""col-md-4"">
                        <div>
                         ");
            WriteLiteral(@"   <label for=""PRights"" style=""padding: 10px 70px 10px 0""> Project Rights </label>
                            <input id=""PRights"" type=""checkbox"" />
                        </div>

                    </div>
               </div>
                <div class=""row"" style=""padding:50px;"">
                    <div class=""col-md-4"">
                        <input id=""FirstName"" />
                    </div>
                    <div class=""col-md-4"">
                        <input id=""MiddleName"" />

                    </div>
                    <div class=""col-md-4"">
                        <input id=""LastName"" />

                    </div>
               </div>
              
               <div class=""row"">
                    <a href=""#"" class=""btn btn-block btn-info"" onclick=""SaveChanges()""><span class=""glyphicon glyphicon-file"" ></span> Save Changes </a>
               </div>
            </div>
        </div>
    </div>
</div>
<<<<<<<");
            BeginWriteAttribute("HEAD:Platform/Views/Dashboard/AddNewAccount.cshtml", " HEAD:Platform/Views/Dashboard/AddNewAccount.cshtml\n          \n=", 2291, "", 2355, 0);
            EndWriteAttribute();
            WriteLiteral(@"======
            </div>
        </div>
>>>>>>> changing the UI interface to use only controls due to copyright issues with the last template as it can't be redustributed under MIT, adding base logic for linking work items. Removing a bug causing work items to be duplicated. Upgrading the kahaban board to v2 syncfusion:Views/Dashboard/AddNewAccount.cshtml
        <!-- end of main-content -->
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abbbe823a386ff263c6e08e8fabe955ba1ea51927492", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

 <script>
     var cProjectRights;
$(document).ready(function() {
    var ProjectRights = new ejs.buttons.Switch({ change: ProjectRightsChanged, checked: false });
    ProjectRights.appendTo('#PRights');
    var email = new ej.inputs.TextBox({
        placeholder: 'Email',
        floatLabelType: 'Auto'
    });
    email.appendTo('#Email');

    var password = new ej.inputs.TextBox({
        placeholder: 'Password',
        floatLabelType: 'Auto'
    });
    password.appendTo('#Password');

    var firstName = new ej.inputs.TextBox({
        placeholder: 'First Name',
        floatLabelType: 'Auto'
    });
    firstName.appendTo('#FirstName');

    var middleName = new ej.inputs.TextBox({
        placeholder: 'Middle Name',
        floatLabelType: 'Auto'
    });
    middleName.appendTo('#MiddleName');

    var lastName = new ej.inputs.TextBox({
        placeholder: 'Last Name',
        floatLabelType: 'Auto'
    });
    lastName.appendTo('#LastName');

});


function ProjectRightsChanged(args) {

   cProjec");
            WriteLiteral(@"tRights = args.checked;

}

function SaveChanges()
{
    console.log(""In Save Changes"");
    var dto = {
        ""Email"": $(""#Email"").val(),
        ""Password"": $(""#Password"").val(),
        ""FirstName"": $(""#FirstName"").val(),
        ""LastName"": $(""#LastName"").val(),
        ""ProjectRights"" : cProjectRights 
    }

    $.ajax({
        type: 'POST',
        url: '/Authenication/AddNewUserAccount',
        data: JSON.stringify(dto),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function(response) {
            window.location.href = ""/Dashboard/AssignAccountProjects?id=""+response;
        },
        error: function(xhr, status, error) {
            console.log(error);
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