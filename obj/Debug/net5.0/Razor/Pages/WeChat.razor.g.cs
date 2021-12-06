#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ef8ecc0fe2eac9b4350722f5cde3ccd14fd1a1"
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
#line 1 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/WeChat")]
    public partial class WeChat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n        <br>");
#nullable restore
#line 11 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
     if (_users == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "wechat-main");
            __builder.AddAttribute(4, "style", "border: 3px solid white; width: 905px; height: auto; background-color: rgba(0,0,0,0.5); display: flex; flex-direction: row");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "wechat table-hover");
            __builder.AddAttribute(7, "style", "flex-direction: column; margin-bottom: auto; width: 300px; margin-top: 0; border: 1px solid black");
            __builder.AddAttribute(8, "bgcolor", "#a9a9a9");
            __builder.OpenElement(9, "thead");
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "class", "wechat-th");
            __builder.AddAttribute(12, "style", "color: white;border: 1px solid black; margin-top: auto");
            __builder.OpenElement(13, "th");
            __builder.AddMarkupContent(14, "<put type=\"text\" style=\"text-align: center\">FriendList</put>\r\n                                ");
            __builder.OpenElement(15, "put");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                               search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "class", "wechat-small");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "style", "margin-left: 40%; float: right; text-align: right; color: black; font-weight: bolder;");
            __builder.AddMarkupContent(20, "<img src=\"css/image/Add.png\" alt=\"Add\" width=\"25px\" height=\"25px\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "tbody");
#nullable restore
#line 30 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                         foreach (var user in _users)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "tr");
            __builder.AddAttribute(24, "class", "wechat-tr");
            __builder.AddAttribute(25, "style", "border: 1px solid black");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                                  () => getMessagess(user.Username)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-default");
#nullable restore
#line 33 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
__builder.AddContent(30, user.Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "put");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                               profile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "style", "margin-top: 3%; float: right; text-align: right; color: white;");
            __builder.AddMarkupContent(36, "<img src=\"css/image/Profile.png\" alt=\"Profile\" width=\"25px\" height=\"25px\">");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            \r\n                ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "wechat-message");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "wechat-box");
            __builder.AddAttribute(42, "style", "width: 600px; height: 35rem;background-color: rgba(255,255,255,0.7); color: black");
#nullable restore
#line 42 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                         foreach (var message in _messages)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "tr");
#nullable restore
#line 44 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
__builder.AddContent(44, message.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "class", "wechat-text");
            __builder.AddAttribute(48, "style", "width: 600px; height: 8rem;background-color: rgba(0,0,0,0.5); color:white;");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                                                                                                                         text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                    ");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                      sendMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "class", "enter");
            __builder.AddAttribute(55, "type", "button");
            __builder.AddAttribute(56, "style", "width: 110px; height: 40px; border-radius: 30px;");
            __builder.AddContent(57, "enter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
       
    private UserData _userData = new UserDataService();
    private ChatData chatData = new ChatDataService();
    private IList<User> _users = new List<User>();
    private IList<Message> _messages = new List<Message>();
    private String username;
    private String text;



    protected override async Task OnInitializedAsync()
    {
        _users = await _userData.getAllFriends(_service.getName());
        Console.WriteLine(System.Diagnostics.Process.GetCurrentProcess());
    }


    public async void getMessagess(String username)
    {
        _messages = await chatData.getMessages(_service.getName(), username);
        this.username = username;
    }

    
    public void sendMessage()
    {
        chatData.sendMessage(_service.getName(), username, text);
        getMessagess(username);
    }

    public void profile()
    {
        NavigationManager.NavigateTo("/profile");
    }

    public void search()
    {
        NavigationManager.NavigateTo("/search");
    }
    
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
