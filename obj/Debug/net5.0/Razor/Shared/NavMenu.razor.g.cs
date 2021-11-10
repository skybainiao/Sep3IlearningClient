#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d816e2770cfef72c5bfbe847be85667807302f2"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Shared
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
#line 1 "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "nav");
                __builder2.AddMarkupContent(4, @"<div class=""nav-ul""><li class=""nav-item""><div class=""item-content""><a href=""/"">
                        Home
                    </a></div></li>
                
            <li class=""nav-item""><div class=""item-content""><a href=""/Counter"">
                        Counter
                    </a></div></li>
            
            <li class=""nav-item""><div class=""item-content""><a href=""/search"">
                        Search
                    </a></div></li>
            
            <li class=""nav-item""><div class=""item-content""><a href=""/add"">
                        Add
                    </a></div></li>
            
            <li class=""nav-item""><div class=""item-content""><a href=""/contactus"">
                        Contact us
                    </a></div></li>
            
            <li class=""nav-item""><div class=""item-content""><a href=""/edit"">
                        Edit
                    </a></div></li>
            
            <li class=""nav-item""><div class=""item-content""><a href=""/friends"">
                        Friends
                    </a></div></li></div>
        ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "person");
                __builder2.OpenElement(7, "a");
                __builder2.AddAttribute(8, "href", "/Login");
                __builder2.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor"
                                       go

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(10, "<img src=\"css/image/person.jpg\" alt=\"Login\" width=\"30px\" height=\"30px\">");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "personal");
                __builder2.OpenElement(14, "a");
                __builder2.AddAttribute(15, "href", "");
                __builder2.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor"
                                 PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(17, "\r\n                Log out\r\n            ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor"
       
    public string username;
    private string password;
    private string errorMessage;
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu() {
        collapseNavMenu = !collapseNavMenu;
    }

    public void go()
    {
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/Login");
        }
        catch (Exception e)
        {
            e.ToString();
        }
    }
    public async Task PerformLogout() {
        errorMessage = "";
        username = "";
        password = "";
        try {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        } catch (Exception e) { }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
