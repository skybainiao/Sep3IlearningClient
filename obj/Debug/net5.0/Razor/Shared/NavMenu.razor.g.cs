#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eb3bf4066ebad1ad4228148f6228dcf8916f79d"
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
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "nav-ul");
                __builder2.AddMarkupContent(6, "<li class=\"nav-item\"><div class=\"item-content\"><a href=\"/\">\r\n                        Home\r\n                    </a></div></li>\r\n\r\n            ");
                __builder2.AddMarkupContent(7, "<li class=\"nav-item\"><div class=\"item-content\"><a href=\"/Counter\">\r\n                        Counter\r\n                    </a></div></li>\r\n\r\n            ");
                __builder2.AddMarkupContent(8, "<li class=\"nav-item\"><div class=\"item-content\"><a href=\"/contactus\">\r\n                        Contact us\r\n                    </a></div></li>\r\n\r\n            ");
                __builder2.AddMarkupContent(9, "<li class=\"nav-item\"><div class=\"item-content\"><a href=\"/edit\">\r\n                        Edit\r\n                    </a></div></li>\r\n\r\n            ");
                __builder2.AddMarkupContent(10, "<li class=\"nav-item\"><div class=\"item-content\"><a href=\"/wechat\">\r\n                        WeChat\r\n                    </a></div></li>\r\n            ");
                __builder2.AddMarkupContent(11, @"<li class=""nav-item""><div class=""item-content"" style=""width: 70px; height: 30px;""><button onclick=""myFunction('Demo1')"" type=""button"" class=""w3-button w3-center-align"" style=""width: 70px; height: 50px; margin-top: -10px""><div class=""oi oi-menu"" style=""font-size: 5px; font-weight: normal;"">Menu</div></button>
                    <div id=""Demo1"" class=""w3-hide w3-animate-zoom"" style=""text-align: center; font-size: 5px""><a href=""#"" class=""w3-button w3-block w3-left-align"">Group</a>
                        <a href=""#"" class=""w3-button w3-block w3-left-align"">GroupChat</a></div></div></li>
            ");
                __builder2.OpenElement(12, "li");
                __builder2.AddAttribute(13, "class", "nav-item");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "item-content");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "href", "/Login");
                __builder2.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor"
                                               go

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(19, "<img src=\"css/image/person.jpg\" alt=\"Login\" width=\"30px\" height=\"30px\">");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 71 "D:\JetBrainsRider\Sep3IlearningClient\Shared\NavMenu.razor"
       
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
