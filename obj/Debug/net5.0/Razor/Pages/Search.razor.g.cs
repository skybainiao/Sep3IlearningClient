#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb82f8c6d364d728730cbfeadf331e97f27a94b0"
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
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search")]
    public partial class Search : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "sousuo");
            __builder.OpenElement(3, "form");
            __builder.AddAttribute(4, "class", "chaxun");
            __builder.AddAttribute(5, "style", "flex-direction: row; align-items: center; justify-content: center");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "style", " background-color: rgba(0,0,0,0.6); color:white; width:400px; height: 30px; border-radius: 10px; text-align: center");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "placeholder", "SearchFriend");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
                                                                                                                                                                                         text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "span");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "style", "margin-left: 20%; width: 70px; height: 30px;text-align: center; border-radius: 10px");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
                                                                                                                                          search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n<br><br>\r\n\r\n");
            __builder.OpenElement(20, "tbody");
#nullable restore
#line 19 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
 foreach (var user in _users)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "tr");
            __builder.AddAttribute(22, "class", "search-tr");
            __builder.AddAttribute(23, "style", "margin-top: 1%; width: 100%; flex-direction: row; float: left");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "button-blue");
            __builder.AddAttribute(27, "style", "margin-left: 5%; width: 1300px; height: 30px; border-radius: 15px; background-color: #7abaff; font-family: Forte");
            __builder.AddContent(28, 
#nullable restore
#line 22 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
                                                                                                                                                                            user.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
                          () =>SendRequest(user.Username)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "style", "margin-left: 5%; width: 100px; height: 30px; border-radius: 15px; font-family: Forte");
            __builder.AddContent(34, "Add");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Search.razor"
       
    private String text;

    private IList<User> _users = new List<User>();

    private UserData _userData = new UserDataService();


    protected override async Task OnInitializedAsync()
    {
        _users = await _userData.getAllUsers();
    }


    public void search()
    {
        if (text!=null)
        {
            if (_users!=null)
            {
                for (int i = 0; i < _users.Count; i++)
                {
                    if (text.Equals(_users[i].Username))
                    {
                        User user = _users[i];
                        _users = new List<User>();
                        _users.Add(user);
                        Console.WriteLine(user.Username);
                        text = null;
                    }
                }
            }
        }
        else
        {
            getAllUsers();
        }
        
    }


    public async void getAllUsers()
    {
        _users = await _userData.getAllUsers();
    }


    public async void SendRequest(String receiver)
    {
        await _userData.sendRequest(_service.getName(), receiver, "Hello,Im: "+_service.getName());
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
