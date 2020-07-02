#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ada6b39dd999ffe9fc817dba696d2086fe6eb5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_IterationManager_Default), @"mvc.1.0.view", @"/Views/Shared/Components/IterationManager/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ada6b39dd999ffe9fc817dba696d2086fe6eb5e", @"/Views/Shared/Components/IterationManager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_IterationManager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"] as int?;
    var Iterations =  ViewData["ProjectIterations"] as List<WorkItemIterations>;
    var CurrentIteration =   ViewData["CurrentIteration"] as int?;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    #main-text{
        height: 90vh;
    }
    .fa-bug:before{
        font-family: ""e-icons"" !important;
        content: '\e191';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-cog:before{
        font-family: ""e-icons"" !important;
        content: '\e679';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-tasks:before{
        font-family: ""e-icons"" !important;
        content: '\e728';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-vial:before{
        font-family: ""e-icons"" !important;
        content: '\e664';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-crown:before{
        font-family: ""e-icons"" !important;
        content: '\e824';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .fa-exclamation-triangle:before{
        font-family: ""e-icons"" !important;
        content: '\e74c';
        color: #1f818c;
        width: 30px;
      ");
            WriteLiteral(@"  height: 30px;
    }
    .fa-user-circle:before{
        font-family: ""e-icons"" !important;
        content: '\e193';
        color: #1f818c;
        width: 30px;
        height: 30px;
    }
    .IterationRow{
        cursor: pointer;
        font-size: 13;
        border: 2px solid #e3165b;
        border-radius: 5px;
        color: #000;
        opacity: 0.87;
        font-family: ""Roboto"", ""Segoe UI"", ""GeezaPro"", ""DejaVu Serif"", ""sans-serif"", ""-apple-system"", ""BlinkMacSystemFont"";

    }
    .IterationRow:hover{
        background-color: #e3165b;
        color: white;
        opacity: 0.87;
        border: 2px solid white;
        border-radius: 5px;
        font-family: ""Roboto"", ""Segoe UI"", ""GeezaPro"", ""DejaVu Serif"", ""sans-serif"", ""-apple-system"", ""BlinkMacSystemFont"";
    }
    
    .ActiveIteration{
        background-color: #e3165b;
        color: white;
        opacity: 0.87;
        font-family: ""Roboto"", ""Segoe UI"", ""GeezaPro"", ""DejaVu Serif"", ""sans-serif"", ""-apple-system"", ""BlinkMacSystemFont"";
");
            WriteLiteral(@"        text-align: center;
        margin: 0;

    }
    .ActiveIteration:hover{
        background-color: white; 
        color: #e3165b;
        opacity: 0.87;
        font-family: ""Roboto"", ""Segoe UI"", ""GeezaPro"", ""DejaVu Serif"", ""sans-serif"", ""-apple-system"", ""BlinkMacSystemFont"";
        text-align: center;
        margin: 0;
        
    }

    .alert {
  padding: 20px;
  height: 20px;
  background-color: #e3165b;
  color: white;
}

.closebtn {
  margin-left: 15px;
  color: white;
  font-weight: bold;
  float: right;
  font-size: 22px;
  line-height: 20px;
  cursor: pointer;
  transition: 0.3s;
}

.closebtn:hover {
  color: black;
}
</style>

<div class=""row"">
    <div class=""col-md-6"">
        <div class=""control-section"" style=""height:77vh;"">
            <div class=""content-wrapper"">
                <div id=""IterationWorkItems""></div>
            </div>
        </div>
    </div>
    <div class=""col-md-6"" style=""height: 650px;"">
");
#nullable restore
#line 130 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
         foreach (var iteration in @Iterations)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row IterationRow\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3303, "\"", 3351, 3);
            WriteAttributeValue("", 3313, "ChangeIterationSelected(", 3313, 24, true);
#nullable restore
#line 132 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
WriteAttributeValue("", 3337, iteration.Id, 3337, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3350, ")", 3350, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                <p style=\"padding:2%;\"> ");
#nullable restore
#line 133 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                                   Write(iteration.IterationName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                <hr/>\n");
#nullable restore
#line 135 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                 if(@iteration.IsActive == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"ActiveIteration\"");
            BeginWriteAttribute("id", " id=\"", 3556, "\"", 3581, 2);
            WriteAttributeValue("", 3561, "Active_", 3561, 7, true);
#nullable restore
#line 137 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
WriteAttributeValue("", 3568, iteration.Id, 3568, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        Active Iteration\n                    </p>\n");
#nullable restore
#line 140 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"ActiveIteration\" hidden");
            BeginWriteAttribute("id", " id=\"", 3760, "\"", 3785, 2);
            WriteAttributeValue("", 3765, "Active_", 3765, 7, true);
#nullable restore
#line 143 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
WriteAttributeValue("", 3772, iteration.Id, 3772, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                        Active Iteration\n                    </p>\n");
#nullable restore
#line 146 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n");
#nullable restore
#line 148 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
      

    </div>
  
</div>
  <div class=""row"" id=""AlertBox"">
        <div class=""alert"" >
            <span class=""closebtn"" onclick=""this.parentElement.style.display='none';"">&times;</span> 
            <strong>Danger!</strong> You're a bout to move all work items that haven't been marked a compleate to the next iteration!!!
        </div>
    </div>

<script>
    var activeElement = ");
#nullable restore
#line 163 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                   Write(CurrentIteration);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\n    var SelectedNewIteration;\n    $(\"#AlertBox\").hide();\n    var dto = {\n        \"id\": ");
#nullable restore
#line 167 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
         Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n        \"WorkItemType\":0,\n        \"Phase\" : \"\",\n        \"ProjectId\": ");
#nullable restore
#line 170 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                Write(CurrentIteration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    }
    $.ajax({
            type: 'POST',
            url: '/Backlogs/GetWorkItems',
            data: JSON.stringify(dto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                InitiliazeIterationItemGrid(response);
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
    });
    function ChangeIterationSelected(id)
    {
        $(""#AlertBox"").show();
        $(""#Rowbtn"").hide();
        $(""#Rowbtns"").show();
        $(""#Active_""+activeElement).hide();
        activeElement = id;
        $(""#Active_""+id).show();
        SelectedNewIteration = id;

    }

    function SaveNewIterationSettings()
    {
        ChangeIterationRequest(SelectedNewIteration);
    }
    function ChangeIterationRequest(id)
    {
         var dto = {
            ""Id"":id,
            ""ProjectId"": ");
#nullable restore
#line 205 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                    Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            \"WorkItemType\": ");
#nullable restore
#line 206 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/IterationManager/Default.cshtml"
                       Write(CurrentIteration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        }
        $.ajax({
                type: 'POST',
                url: '/Boards/CloseIteration',
                data: JSON.stringify(dto),
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (response) {
                    location.reload(); 
                },
                error: function (xhr, status, error) {
                    console.log(error);
                }
        });
    }
    function InitiliazeIterationItemGrid(data )
    {
        console.log(data);


        var IterationWorkItems = new ej.treegrid.TreeGrid({
            dataSource: data,
            allowSelection: true,
            allowFiltering: true,
            allowSorting: true,
            toolbar: ['Search'],
 
            enableVirtualization: true,
            filterSettings: { type: 'Menu' },
            queryCellInfo: customiseCell,
            selectionSettings: { persistSelection: true, type: ""Multiple"" },
            enableHover: fal");
            WriteLiteral(@"se,
            allowPaging: true,
            pageSettings: { pageSize: 20 },
            height:'450px',
            columns: [
                { type: ""checkbox"", field: """", allowFiltering: false, allowSorting: false, width: '20' , textAlign: 'center'},
                { field: 'workItemType.TypeName', headerText: 'Type', width: '10',customAttributes: {class: ""workItemIcon""}, textAlign: 'center' },
                { field: 'title', headerText: 'Title', width: 125 },
                { field: 'description', headerText: 'Description', width: 180 },
                { field: 'assignedTo', headerText: 'AssignedTo', width: 110 },
            ]
        });

        IterationWorkItems.appendTo('#IterationWorkItems');
        ShowContent();


    }

    function customiseCell(args) {
        if (args.column.headerText === 'Type' ){
            args.cell.setAttribute('class', args.data.workItemIcon);
        } 
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
