#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1372cc7205e5ad5e645b3be0234375d7921a55f"
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
            __builder.AddAttribute(4, "style", "border: 3px solid white; width: 705px; background-color: rgba(0,0,0,0.5)");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "wechat-table");
            __builder.AddAttribute(7, "style", "background-color: white");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "wechat table-hover");
            __builder.AddAttribute(10, "style", " width: 200px; margin-top: 0; border: 1px solid black");
            __builder.AddAttribute(11, "bgcolor", "#a9a9a9");
            __builder.OpenElement(12, "thead");
            __builder.OpenElement(13, "tr");
            __builder.AddAttribute(14, "class", "wechat-th");
            __builder.AddAttribute(15, "style", "color: white;border: 1px solid black;");
            __builder.OpenElement(16, "th");
            __builder.AddMarkupContent(17, "<put type=\"text\" style=\"text-align: center\">FriendList</put>\r\n                                ");
            __builder.OpenElement(18, "put");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                               search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "class", "wechat-small");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "style", "margin-left: 40%; float: right; text-align: right; color: black; font-weight: bolder;");
            __builder.AddMarkupContent(23, "<img src=\"css/image/Add.png\" alt=\"Add\" width=\"25px\" height=\"25px\">");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 31 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                         foreach (var user in _users)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.AddAttribute(27, "class", "wechat-tr");
            __builder.AddAttribute(28, "style", "border: 1px solid black");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                                  () => getMessagess(user.Username)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "type", "button");
            __builder.AddAttribute(32, "class", "btn btn-default");
#nullable restore
#line 34 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
__builder.AddContent(33, user.Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "put");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                               profile

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "type", "button");
            __builder.AddAttribute(38, "style", "margin-top: 3%; float: right; text-align: right; color: white;");
            __builder.AddMarkupContent(39, "<img src=\"css/image/Profile.png\" alt=\"Profile\" width=\"25px\" height=\"25px\">");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n        \r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "wechat-message");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "wechat-box");
            __builder.AddAttribute(45, "style", "width: 500px; height: 22rem;background-color: rgba(255,255,255,0.7); color: black");
#nullable restore
#line 44 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                         foreach (var message in _messages)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(46, "tr");
#nullable restore
#line 46 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
__builder.AddContent(47, message.ToString());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "class", "wechat-text");
            __builder.AddAttribute(51, "style", "width: 500px; height: 6rem;background-color: rgba(0,0,0,0.5); color:white;");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                                                                                                                         text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
                                      sendMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "class", "enter");
            __builder.AddAttribute(58, "type", "button");
            __builder.AddAttribute(59, "style", "width: 110px; height: 40px; border-radius: 30px;");
            __builder.AddContent(60, "enter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
       
    private UserData _userData = new UserDataService();
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
        _messages = await _userData.getMessages(_service.getName(), username);
        this.username = username;
    }

    
    public void sendMessage()
    {
        _userData.sendMessage(_service.getName(), username, text);
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
