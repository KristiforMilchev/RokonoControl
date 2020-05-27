#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatNavigation/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c64768fb997e927e91b740daa9cf69424418bb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ChatNavigation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ChatNavigation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c64768fb997e927e91b740daa9cf69424418bb2", @"/Views/Shared/Components/ChatNavigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ChatNavigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatNavigation/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"] as int?;
    var defaultIteration = ViewData["DefaultIteration"] as int?;
    var CurrentUser = ViewData["User"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .ChatChannelIcon:before{
        content:'\e99a';
        font-family: e-icons;
        padding:3px;
        font-size: 13px;
    }
    .TreeNewItem:before{
        padding:3px;
        content:'\e7f9';
        font-family: e-icons;
        font-size: 13px;
    }
    .CategoryIcon:before{
        padding:3px;
        content:'\e714';
        font-family: e-icons;
        font-size: 13px;
    }
    .CategoryIcon:hover{
        color:rgb(230, 50, 111);
    }
    .TreeNewItem:hover{
        color:rgb(230, 50, 111);
    }
    .ChatChannelIcon:hover{
        color:rgb(230, 50, 111);
        
    }
    #chat-treeview .e-list-parent .e-ul
    {
        padding: 0;
        margin:  0;
    } 
    #chat-treeview .e-text-content
    {
        padding: 0;
    }

    #chat-treeview  .e-text-content
    {
        text-align: initial;
    }
    #chat-treeview .e-list-text
    {
        width: 80%;
    }
    #chat-treeview  .e-gridheader
    {
        height:0px;
        display: none;
    }

     #chat-treeview");
            WriteLiteral(@" .e-treecell
     {
         width: 100%;
     }
    .nodetext{
        font-family: ""Helvetica Neue"",Helvetica,Arial,sans-serif;
        padding: 2%;
        font-size: 16px;
        text-align: left;
        padding-left: 5px;
        cursor: pointer;
    }
    .nodetext:hover{
        background-color: #fff;
        border-color: #000;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
    }
    .nodetextHeading{
        cursor: pointer;
    }
     .nodetextHeading:hover{
        background-color: #fff;
        border-color: #000;
        box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
    }
    .nodetextHeading
    {
        ont-family: ""Helvetica Neue"",Helvetica,Arial,sans-serif;
        padding: 2%;
        font-size: 18px;
        text-align: left;
    }
</style>
<div class=""row"" style=""margin:0;"">
    <div id=""ChatTreeViewHolder"">
");
            WriteLiteral(@"                <div id=""chat-treeview""></div>
    </div>
</div>



<script id=""chatRowTemplate"" type=""text/x-template"" >
<tr>
    <td>
     ${if(isParent)}
        <div class=""nodetextHeading"">
            <div class=""row"" style=""padding:5px; margin:0;"" >
                <div class=""col-md-9"">
                    <span class=""CategoryIcon""></span><span class=""ChatTreeMainText"">${nodeText}</span>
                </div>
                <div class=""col-md-2""   >
                    <span onclick=""AddNewChannelModal(${internalId})"" class=""TreeNewItem""></span>
                </div>
            </div>
        </div>   
    ${else}
        <div class=""nodetext"" id=""ChatChannel_${internalId}"" onclick=""OpenChannel(${internalId})"">
            <span class=""ChatChannelIcon""></span> <span class=""ChatTreeMainText"" >${nodeText}</span>
        </div>
    ${/if}
    </td>
</tr>
</script>


<script>

$( document ).ready(function() {
    var dtoNotifications = {
        ""Id"":");
#nullable restore
#line 131 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatNavigation/Default.cshtml"
        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
         
    }
    $.ajax({
        type: 'POST',
        url: '/Chat/GetChannelNotifications',
        data: JSON.stringify(dtoNotifications),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            response.forEach(x=>{
                console.log(x);
                SetRoomNewMessage(x.chatChannelId);
            });
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    }); 
});
    var chatMenuGridObj;
    
    
    var dto = {
        ""Id"":");
#nullable restore
#line 155 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatNavigation/Default.cshtml"
        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
         
    }
    $.ajax({
        type: 'POST',
        url: '/Chat/GetChatChannels',
        data: JSON.stringify(dto),
        contentType: ""application/json; charset=utf-8"",
        dataType: ""json"",
        success: function (response) {
            InitializeChatItems(response);
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });

    var URL = location.href.replace(location.search, '');
    
     
    function InitializeChatItems(incomingData)
    {
        chatMenuGridObj = null;
        $(""#ChatTreeViewHolder"").html("""");
        $(""#ChatTreeViewHolder"").html(""<div id=\""chat-treeview\""></div>"");
 
        console.log(incomingData);

        chatMenuGridObj= new ej.treegrid.TreeGrid({
            dataSource: incomingData,
            childMapping: 'nodeChild',
            treeColumnIndex: 0,
            rowTemplate:'#chatRowTemplate',
            allowPaging: false,
            rowHeight: 83,
            columns: [
                { field: 'no");
            WriteLiteral(@"deText',  width: 220 },
              
            ]
        });
        chatMenuGridObj.appendTo('#chat-treeview');
    }
     
    function OpenChannel(id)
    {
        $( ""#ChatChannel_""+id ).removeClass(""NewMessage"");
        ActiveUser.ActiveRoom = id;
        console.log(""in"");
        console.log(id);
        $(""#MainChatContent"").load('/Chat/GetChatRoom?id='+id+'&&projectId=");
#nullable restore
#line 204 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatNavigation/Default.cshtml"
                                                                      Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\n");
            WriteLiteral("    }\n</script>");
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
