#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc735e228eaadf43506b177227973392a279050f"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\JetBrainsRider\Sep3IlearningClient1\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Notice")]
    public partial class Notice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "notice");
            __builder.AddAttribute(3, "style", " display: flex; flex-direction: row; width: 100%; height: 75vh");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "flex-direction: column; display: flex; text-align: center; top: 0; bottom: 0; left: 0; right: 0; margin: auto");
            __builder.OpenElement(6, "ul");
            __builder.AddAttribute(7, "style", "list-style-type: none");
            __builder.OpenElement(8, "li");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                              getMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "notice-button1");
            __builder.AddContent(12, "Message box");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "li");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                              getFriendRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "notice-button1");
            __builder.AddAttribute(18, "style", "margin-top: 20%");
            __builder.AddContent(19, "Friend request");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "li");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                              getGroupRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "class", "notice-button1");
            __builder.AddAttribute(25, "style", "margin-top: 20%");
            __builder.AddContent(26, "Group request");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "li");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                              getAnnouncement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "notice-button1");
            __builder.AddAttribute(32, "style", "margin-top: 20%");
            __builder.AddContent(33, "Announcement");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "notice-text");
            __builder.AddAttribute(37, "style", "position: relative; width: 100%; height: 100%; background-color: rgba(255,255,255,0.7); color: black; margin-left: 5%");
#nullable restore
#line 21 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                 if (type.Equals("Message"))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "table");
            __builder.AddAttribute(39, "class", "table table-hover");
            __builder.AddAttribute(40, "style", "width: 100%;");
            __builder.AddMarkupContent(41, @"<thead><tr style=""text-align: center""><th><span>Username</span></th>
                                        <th><span>Message</span></th>
                                        <th><span>Travel through time</span></th></tr></thead>
                                ");
            __builder.OpenElement(42, "tbody");
#nullable restore
#line 33 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                 foreach (var message in _messages)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "tr");
            __builder.AddAttribute(44, "style", "text-align: center");
            __builder.OpenElement(45, "td");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", "/profile");
            __builder.AddAttribute(48, "style", "font-size: 1vw; font-weight: bolder; color: #0f6674");
            __builder.AddContent(49, 
#nullable restore
#line 36 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                                                                                                                    message.senderName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                                                ");
            __builder.OpenElement(51, "td");
            __builder.OpenElement(52, "span");
            __builder.AddAttribute(53, "style", "font-size: 1vw; font-weight: bolder");
            __builder.AddContent(54, 
#nullable restore
#line 37 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                                                                                       message.chatMessages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                                ");
            __builder.AddMarkupContent(56, "<td><button style=\"outline: none; background: transparent; border: none\"><a href=\"/wechat\"><img src=\"css/image/WEchat.png\" width=\"30%\" height=\"30%\"></a></button></td>");
            __builder.CloseElement();
#nullable restore
#line 40 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                }
                else if (type.Equals("FriendRequest"))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "table");
            __builder.AddAttribute(58, "class", "table table-striped");
            __builder.AddAttribute(59, "style", "width: 100%");
            __builder.AddMarkupContent(60, @"<thead><tr style=""text-align: center""><th><span>Name(Username)</span></th>
                                        <th><span>Comment(System)</span></th>
                                        <th><span>Accept</span></th>
                                        <th><span>Refuse</span></th>
                                        <th><span>Information</span></th></tr></thead>
                                ");
            __builder.OpenElement(61, "tbody");
#nullable restore
#line 57 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                 foreach (var request in _requests)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "tr");
            __builder.AddAttribute(63, "style", "text-align: center");
            __builder.OpenElement(64, "td");
            __builder.OpenElement(65, "span");
            __builder.AddAttribute(66, "style", "font-weight: bolder; font-size: 2vw;");
            __builder.AddContent(67, 
#nullable restore
#line 60 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                                                                                        request.sender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                                                ");
            __builder.OpenElement(69, "td");
            __builder.OpenElement(70, "span");
            __builder.AddAttribute(71, "style", "font-weight: bolder; font-size: 2vw;");
            __builder.AddContent(72, 
#nullable restore
#line 61 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                                                                                        request.comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                                ");
            __builder.OpenElement(74, "td");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                                                      () =>accept(request.sender,request.receiver) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "class", "notice-button2");
            __builder.AddMarkupContent(78, "<img src=\"css/image/GreenBingo.png\" width=\"30%\" height=\"30%\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                                ");
            __builder.AddMarkupContent(80, "<td><button class=\"notice-button2\"><img src=\"css/image/RedCross.png\" width=\"30%\" height=\"30%\"></button></td>\r\n                                                ");
            __builder.AddMarkupContent(81, "<td><button class=\"notice-button2\"><img src=\"css/image/BlueInformation.png\" width=\"30%\" height=\"30%\"></button></td>");
            __builder.CloseElement();
#nullable restore
#line 66 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 69 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                }
                else if (type.Equals("GroupRequest"))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "table");
            __builder.AddAttribute(83, "class", "table table-striped");
            __builder.AddAttribute(84, "style", "width: 100%");
            __builder.AddMarkupContent(85, @"<thead><tr style=""text-align: center""><th><span></span></th>
                                        <th><span>Groupname</span></th>
                                        <th><span>Accept</span></th>
                                        <th><span>Refuse</span></th>
                                        <th><span>Information</span></th></tr></thead>
                                ");
            __builder.OpenElement(86, "tbody");
#nullable restore
#line 83 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                 foreach (var request in _requests)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, @"<tr style=""text-align: center""><td><label><img src=""css/image/GroupRequest.png"" width=""30%"" height=""30%""></label></td>
                                                <td><span style=""font-weight: bolder; font-size: 2vw;""></span></td>
                                                <td><button class=""notice-button2""><img src=""css/image/GreenBingo.png"" width=""30%"" height=""30%""></button></td>
                                                <td><button class=""notice-button2""><img src=""css/image/RedCross.png"" width=""30%"" height=""30%""></button></td>
                                                <td><button class=""notice-button2""><img src=""css/image/BlueInformation.png"" width=""30%"" height=""30%""></button></td></tr>");
#nullable restore
#line 92 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                }
                else if (type.Equals("Announcement"))
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(88, "<p style=\"font-size: 30px; margin-left: 3%; margin-top: 1%\"><img src=\"css/image/trumpet.png\" width=\"4%\" height=\"4%\" style=\"margin-right: 1%\">New announcement available in <a></a><a></a>by teacher</p>");
#nullable restore
#line 99 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n<br>\r\n<hr style=\" border: 2px solid white\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
 
        private String type = "";
        private UserData _userData = new UserDataService();
        private IList<Request> _requests = new List<Request>();
        private IList<Message> _messages = new List<Message>();
        private IList<User> friends = new List<User>();
        private IList<Request> requests = new List<Request>();

        protected override async Task OnInitializedAsync()
        {
                _requests = await _userData.getRequest(_service.getName());
                _messages = await _userData.getAllMessages(_service.getName());
                friends = await _userData.getAllFriends(_service.getName());
                requests = await _userData.getRequest(_service.getName());
        }

        public async void getRequest()
        {
                _requests = await _userData.getRequest(_service.getName());
        }

        public void getFriendRequest()
        {
              type = "FriendRequest";  
        }

        public void getGroupRequest()
        {
                type = "GroupRequest";
        }

        public void getMessage()
        {
                type = "Message";
        }


        public void getAnnouncement()
        {
                type = "Announcement";
        }

        public void accept(string sender,string receiver)
        {
                for (int i = 0; i < friends.Count; i++)
                {
                        if (!friends[i].Username.Equals(sender))
                        {
                                _userData.addFriend(receiver, sender);
                        }
                }
                _userData.deleteRequest(sender, receiver);
                
                getRequest();
                
                Console.WriteLine("add friend");

        }

        public void refuse()
        {
                
        }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
