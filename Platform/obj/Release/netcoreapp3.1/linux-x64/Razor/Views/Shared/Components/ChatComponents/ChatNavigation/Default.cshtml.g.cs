#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc7a94b55dd9251bc5f214f6b73d7369a1de9fd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ChatComponents_ChatNavigation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc7a94b55dd9251bc5f214f6b73d7369a1de9fd3", @"/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ChatComponents_ChatNavigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
  
    var ProjectId = ViewData["ProjectId"] as int?;
    var defaultIteration = ViewData["DefaultIteration"] as int?;
    var CurrentUser = ViewData["User"];
    var UserRights = ViewData["GetChatRights"]as UserRights;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    

    .CategoryRemove:before{
        padding:3px;
        content:'\e7a7';
        font-family: e-icons;
        font-size: 13px;
    }
    .CategoryIcon:hover{
        color:rgb(230, 50, 111);
    }
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
   ");
            WriteLiteral(@"     text-align: initial;
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

     #chat-treeview .e-treecell
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
   ");
            WriteLiteral(" <div id=\"ChatTreeViewHolder\">\n");
            WriteLiteral("                <div id=\"chat-treeview\"></div>\n    </div>\n</div>\n\n\n");
#nullable restore
#line 115 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
 if(@UserRights.ChatChannelsRule == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script id=""chatRowTemplate"" type=""text/x-template"" >
<tr >
    <td>
     ${if(isParent)}
        <div class=""nodetextHeading"">
            <div class=""row"" style=""padding:5px; margin:0;"" >
                <div class=""col-md-9"">
                    <span class=""CategoryIcon""></span><span class=""ChatTreeMainText"">${nodeText}</span>
                </div>
                <div class=""col-md-2"" style=""display:flex;"" >
                    <span onclick=""AddNewChannelModal(${internalId})"" class=""TreeNewItem""></span>
                    <span onclick=""RemoveCategory(${internalId})"" class=""CategoryRemove""></span>

                </div>
            </div>
        </div>   
     ${else if(isPersonal)}
     <div class=""row"">
         <div class=""col-md-8"">
            <div class=""nodetext"" id=""ChatChannel_${internalId}"" onclick=""OpenChannel(${internalId},1)"">
                <span class=""ChatChannelIcon""></span> <span class=""ChatTreeMainText"" >${nodeText}</span>
            </div>
        </div>
        <div class=""col");
            WriteLiteral(@"-md-4"">
            <span onclick=""RemovePersonal(${internalId})"" class=""CategoryRemove""></span>
        </div>
    </div>
    ${else}
     <div class=""row"">
         <div class=""col-md-8"">
            <div class=""nodetext"" id=""ChatChannel_${internalId}"" onclick=""OpenChannel(${internalId},10)"">
                <span class=""ChatChannelIcon""></span> <span class=""ChatTreeMainText"" >${nodeText}</span>
            </div>
        </div>
        <div class=""col-md-4"">
            <span onclick=""RemoveRoom(${internalId})"" class=""CategoryRemove""></span>
        </div>
    </div>
         
    ${/if}
    </td>
</tr>
</script>
");
#nullable restore
#line 160 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script id=""chatRowTemplate"" type=""text/x-template"" >
<tr>
    <td>
     ${if(isParent)}
        <div class=""nodetextHeading"">
            <div class=""row"" style=""padding:5px; margin:0;"" >
                <div class=""col-md-12"">
                    <span class=""CategoryIcon""></span><span class=""ChatTreeMainText"">${nodeText}</span>
                </div>
                
            </div>
        </div>   
     ${else if(isPersonal)}
        <div class=""nodetext"" id=""ChatChannel_${internalId}"" onclick=""OpenChannel(${internalId},1)"">
            <span class=""ChatChannelIcon""></span> <span class=""ChatTreeMainText"" >${nodeText}</span>
        </div>
    ${else}
        <div class=""nodetext"" id=""ChatChannel_${internalId}"" onclick=""OpenChannel(${internalId}, 0)"">
            <span class=""ChatChannelIcon""></span> <span class=""ChatTreeMainText"" >${nodeText}</span>
        </div>
    ${/if}
    </td>
</tr>
</script>
");
#nullable restore
#line 187 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<script>\n\n$( document ).ready(function() {\n    var dtoNotifications = {\n        \"Id\":");
#nullable restore
#line 193 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
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
#line 217 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
         
    }
    $.ajax({
        type: 'POST',
        url: '/Chat/GetChatChannelsNavigation',
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
                { ");
            WriteLiteral(@"field: 'nodeText',  width: 220 },
              
            ]
        });
        chatMenuGridObj.appendTo('#chat-treeview');
    }
     
    function OpenChannel(id, isPersonal)
    {
        $( ""#ChatChannel_""+id ).removeClass(""NewMessage"");
        ActiveUser.ActiveRoom = id;
        console.log(""in"");
        console.log(id);
        $(""#MainChatContent"").load('/Chat/GetChatRoom?id='+id+'&&projectId='+");
#nullable restore
#line 266 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
                                                                        Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("+\'&&isPersonal=\'+isPersonal);\n");
            WriteLiteral("    }\n\n    function RemoveCategory(id,isPersonal)\n    {\n        $(\"#MainChatContent\").load(\'/Chat/RemoveCategory?id=\'+id+\'&&projectId=\'+");
#nullable restore
#line 281 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
                                                                           Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("+\'&&isPersonal=\'+isPersonal);\n        window.location.reload(true);\n    }\n\n    function RemovePersonal(Id)\n    {\n        $(\"#MainChatContent\").load(\'/Chat/RemovePersonal?id=\'+id+\'&&projectId=\'+");
#nullable restore
#line 287 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
                                                                           Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("+\'&&isPersonal=0\');\n        window.location.reload(true);\n    }\n\n    function RemoveRoom(id)\n    {\n        $(\"#MainChatContent\").load(\'/Chat/RemoveRoom?id=\'+id+\'&&projectId=\'+");
#nullable restore
#line 293 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatComponents/ChatNavigation/Default.cshtml"
                                                                       Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("+\'&&isPersonal=0\');\n        window.location.reload(true);\n    }\n</script>");
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