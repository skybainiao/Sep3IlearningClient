#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08d94de1b38abd5a8ad40f983eb001c86301546c"
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
#line 1 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
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
#line 11 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
     if (_users == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "wechat-main");
            __builder.AddAttribute(4, "style", "border: 3px solid white; width: 710px; background-color: darkgray");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "wechat-table");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "wechat table-hover");
            __builder.AddAttribute(9, "style", " width: 200px; margin-top: 0; border: 1px solid black");
            __builder.AddAttribute(10, "bgcolor", "#a9a9a9");
            __builder.AddMarkupContent(11, @"<thead><tr class=""wechat-tr"" style=""color: white;border: 1px solid black;""><th><imput type=""text"" style=""text-align: center"">FriendList</imput>
                                <imput class=""wechat-small"" type=""button"" style=""margin-left: 40%; color: black; font-weight: bolder;"">＋</imput></th></tr></thead>
                        ");
            __builder.OpenElement(12, "tbody");
#nullable restore
#line 31 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                         foreach (var user in _users)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
            __builder.AddAttribute(14, "style", "border: 1px solid black");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                                                  () => getMessagess(user.Username)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "type", "button");
            __builder.AddAttribute(18, "class", "btn btn-default");
            __builder.AddContent(19, 
#nullable restore
#line 34 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                                                                                                                            user.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "imput");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                                                 fuck

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "type", "button");
            __builder.AddAttribute(24, "style", "margin-top: 3%; float: right; text-align: right; color: white; font-weight: bolder;");
            __builder.AddContent(25, "Profile");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        \r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "wechat-message");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "wechat-box");
            __builder.AddAttribute(31, "style", "width: 500px; height: 22rem;background-color: grey;");
#nullable restore
#line 44 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                         foreach (var message in _messages)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.AddContent(33, 
#nullable restore
#line 46 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                                 message.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 47 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "class", "wechat-text");
            __builder.AddAttribute(37, "style", "width: 500px; height: 6rem;background-color: rgba(143,143,144,0.6)");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                                                                                                                                 text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
                                      sendMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "class", "enter");
            __builder.AddAttribute(44, "type", "button");
            __builder.AddAttribute(45, "style", "width: 110px; height: 40px; border-radius: 30px;");
            __builder.AddContent(46, "enter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
       
    private UserData _userData = new UserDataService();
    private IList<User> _users = new List<User>();
    private IList<Message> _messages = new List<Message>();
    private String username;
    private String text;



    protected override async Task OnInitializedAsync()
    {
        _users = await _userData.getAllFriends(_service.getName());
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

    public void fuck()
    {
        NavigationManager.NavigateTo("/counter");
    }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
