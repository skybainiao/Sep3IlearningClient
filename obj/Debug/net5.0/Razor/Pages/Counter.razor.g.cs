#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70bf54c2f78c140881a41f4d98968730c3a8939a"
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
#line 2 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
                  test

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "test");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.OpenElement(15, "form");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
                     _user.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Username = __value, _user.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, ";\r\n        ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
                     _user.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _user.Password = __value, _user.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
                      testpost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "post");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
                      testGet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "get");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Counter.razor"
       
    private int currentCount = 0;
    private UserData _userData = new UserDataService();
    private User _user = new User();
    private IList<User> _users = new List<User>();
    private IList<User> friends = new List<User>();

    protected override async Task OnInitializedAsync()
    {
        _users = await _userData.getAllUsers();
        friends = await _userData.getAllFriends(iService.getName());
    }


    private void IncrementCount() {
        currentCount++;
    }

    public async void test()
    {
        
        Console.WriteLine(await _userData.get());
        
        Console.WriteLine(iService.getName());

        for (int i = 0; i < friends.Count; i++)
        {
            Console.WriteLine(friends[i].Username);
        }
        
        
    }


    public async void testpost()
    {
        await _userData.post(_user);
        Console.WriteLine("postdid");
    }
    
    public void testGet()
    {
        for (int i = 0; i < _users.Count; i++)
        {
            Console.WriteLine(_users[i].Username);
        }
        Console.WriteLine("getdid");
    }
    
    




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService iService { get; set; }
    }
}
#pragma warning restore 1591
