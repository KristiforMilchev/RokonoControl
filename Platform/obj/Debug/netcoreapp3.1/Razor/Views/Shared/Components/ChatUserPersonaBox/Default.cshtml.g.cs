#pragma checksum "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b62091075119c416b033100362d29fd169be27c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ChatUserPersonaBox_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b62091075119c416b033100362d29fd169be27c", @"/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a3d88b77ca5ff650022e07aede809867a9af767", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ChatUserPersonaBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
  
    var channelRights = ViewData["UserAdministrativeRights"] as bool?;   
    var InputName = $"ChatInputSession{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Millisecond}"; 
    var UserId = ViewData["UserId"] as int?;
    var UserRights = ViewData["UserRights"] as List<ChatRoomRights>;
    var ProjectId = ViewData["ProjectId"] as int?;
    var AdministrativeRights = ViewData["ProjectRight"] as UserRights;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
 .ChipTag{
    background: red;
    border-radius: 15px;
    padding: 4px;
    color: white;
 }
 .ChipTag:hover{
    background: red;
    border-radius: 15px;
    padding: 4px;
    color: white;
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.22);
 }

.ChipCloseBtn:before{
    content:'\e7e9';
    font-family: e-icons;
    padding:3px;
    font-size: 13px;
}
.AddNewRoleTag{
    cursor: pointer;
}
.AddNewRoleTag:before
{
    content:'\e823';
    font-family: e-icons;
    padding:3px;
    font-size: 13px;
    cursor: pointer;
}
.AddNewRoleTag:hover{
    color: red;
}
</style>

<div class=""row"">
    <input");
            BeginWriteAttribute("id", " id=\"", 1056, "\"", 1071, 1);
#nullable restore
#line 48 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
WriteAttributeValue("", 1061, InputName, 1061, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  style=\"margin: 5px;\"/>\n</div>\n");
#nullable restore
#line 50 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
 if(AdministrativeRights.ChatChannelsRule == 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" style=\"text-align: center;\">\n    <span class=\"AddNewRoleTag\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1231, "\"", 1270, 3);
            WriteAttributeValue("", 1241, "OpenChatAssignRights(", 1241, 21, true);
#nullable restore
#line 53 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
WriteAttributeValue("", 1262, UserId, 1262, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1269, ")", 1269, 1, true);
            EndWriteAttribute();
            WriteLiteral(">New Role</span>\n</div>\n");
#nullable restore
#line 55 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\" style=\"padding: 15px;\" id=\"ActiveTags\">\n");
#nullable restore
#line 57 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
     foreach (var right in UserRights)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
         if(AdministrativeRights.ChatChannelsRule == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"ChipTag\"");
            BeginWriteAttribute("id", " id=\"", 1498, "\"", 1516, 2);
            WriteAttributeValue("", 1503, "Tag_", 1503, 4, true);
#nullable restore
#line 61 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
WriteAttributeValue("", 1507, right.Id, 1507, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
                                                Write(right.RightName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span");
            BeginWriteAttribute("onclick", " onclick=\"", 1540, "\"", 1572, 3);
            WriteAttributeValue("", 1550, "DeletingTag(", 1550, 12, true);
#nullable restore
#line 61 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
WriteAttributeValue("", 1562, right.Id, 1562, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1571, ")", 1571, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"ChipCloseBtn\" ></span></span>\n");
#nullable restore
#line 62 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"ChipTag\"");
            BeginWriteAttribute("id", " id=\"", 1677, "\"", 1695, 2);
            WriteAttributeValue("", 1682, "Tag_", 1682, 4, true);
#nullable restore
#line 65 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
WriteAttributeValue("", 1686, right.Id, 1686, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 65 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
                                                Write(right.RightName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"     

</div>
<div class=""row"">
    <button class=""btn btn-primary e-control e-btn e-lib e-outline e-primary"" style=""width: 100%;"" onclick=""CloseChatUserPreview()"">Close</button>
</div>
<script>
var UserControlChatInput = new ej.inputs.TextBox({
    placeholder: ""What's on your mind"",
    floatLabelType: 'Auto'
});
UserControlChatInput.appendTo('#");
#nullable restore
#line 79 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
                           Write(InputName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\n\n\n");
            WriteLiteral("\nfunction DeletingTag(currentTag)\n{\n    console.log(currentTag);\n    $(\"#Tag_\"+currentTag).html(\"\");\n     var messagesDto = {\n        \"Id\": currentTag,\n        \"UserId\" : ActiveQueryUser,\n        \"ProjectId\" : ");
#nullable restore
#line 91 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
                 Write(ProjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    }

    $.ajax({
            type: 'POST',
            url: '/Chat/DeleteUserTag',
            data: JSON.stringify(messagesDto),
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            
            success: function (response) {
                 
            },
            error: function (xhr, status, error) {
                console.log(error);
            }
    });


    var dto = {
        ""Id"": ");
#nullable restore
#line 111 "/home/dwarfdevelopment/Projects/GitClones/RC/RokonoControl/Platform/Views/Shared/Components/ChatUserPersonaBox/Default.cshtml"
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
    CloseChatUserPreview();
}
</script>

");
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