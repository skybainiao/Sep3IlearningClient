#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8516ff44b97667d359326b4c3b277fe0a946d2"
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
#line 1 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Shared\NavMenu.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Shared\NavMenu.razor"
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
                __builder2.OpenElement(4, "nav");
                __builder2.AddAttribute(5, "class", "navbar navbar-expand-lg navbar-toggleable-lg navbar-dark navbar-custom  box-shadow mb-3 fixed-top");
                __builder2.AddAttribute(6, "style", "background-color: rgba(178,255,244,0.3); max-width: 100%");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "nav-ul");
                __builder2.AddMarkupContent(9, @"<li class=""nav-item""><div class=""item-content""><a href=""/home"" style=""border-radius: 10px; border: 1px solid red; background-color: red; border-bottom-width: 15px; border-top-width: 15px; border-left-width: 15px; border-right-width: 15px; font-size: 25px"">
                            Home
                        </a></div></li>

                ");
                __builder2.AddMarkupContent(10, @"<li class=""nav-item""><div class=""item-content""><button type=""button"" class=""dropdown-toggle"" data-bs-toggle=""dropdown"" style=""font-weight: normal; text-align: center; margin-top: -10px; font-size:25px; color: #37ff00; background: transparent; border-width: 0; outline:none;"">
                            Course
                        </button>
                        <ul class=""dropdown-menu"" style=""background-color: rgba(0,0,0,0.4)""><li><a class=""dropdown-item"" href=""/SDJ"" style=""font-family: 'Arial'; font-weight: lighter"">SDJ</a></li>
                            <li><a class=""dropdown-item"" href=""/DNP"" style=""font-family: 'Arial'; font-weight: lighter"">DNP</a></li>
                            <li><a class=""dropdown-item"" href=""/CAO"" style=""font-family: 'Arial'; font-weight: lighter"">CAO</a></li>
                            <li><a class=""dropdown-item"" href=""/NES"" style=""font-family: 'Arial'; font-weight: lighter"">NES</a></li></ul></div></li>

                ");
                __builder2.AddMarkupContent(11, @"<li class=""nav-item"" style=""text-align: center""><div class=""item-content"" style=""text-align: center""><button onclick=""myFunction('Demo1')"" type=""button"" class=""button w3-center-align"" style=""text-align: center; background: transparent; border-width: 0; outline:none; color: #37ff00;text-decoration: none; margin-top: -10px""><div class=""oi oi-menu"" style=""text-align: center; font-size: 25px; font-weight: normal;"">Menu</div></button>
                        <div id=""Demo1"" class=""w3-hide w3-animate-zoom"" style=""text-align: center; font-size: 10px""><a href=""/wechat"" class=""w3-button w3-block w3-left-align"" style=""text-align: center; font-family: 'Arial Black'"">WeChat</a>
                            <a href=""/moment"" class=""w3-button w3-block w3-left-align"" style=""text-align: center; font-family: 'Arial Black'"">Moment</a>
                            <a href=""/groupchat"" class=""w3-button w3-block w3-left-align"" style=""text-align: center; font-family: 'Arial Black'"">GroupChat</a>
                            <a href=""/contactus"" class=""w3-button w3-block w3-left-align"" style=""text-align: center; font-family: 'Arial Black'"">ContactUs</a></div></div></li>

                ");
                __builder2.AddMarkupContent(12, @"<li class=""nav-item""><div class=""item-content""><a href=""/Notice""><img src=""css/image/Notice.png"" alt=""Notice"" type=""button"" width=""30px"" height=""30px"" style=""margin-top: -10%""><label style=""color: red; font-size: 10px"">100</label></a></div></li>

                ");
                __builder2.OpenElement(13, "li");
                __builder2.AddAttribute(14, "class", "nav-item");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "item-content");
                __builder2.AddMarkupContent(17, "<img src=\"css/image/person.jpg\" alt=\"Login\" type=\"button\" class=\"dropdown-toggle\" data-bs-toggle=\"dropdown\" width=\"30px\" height=\"30px\" style=\"margin-top: -10%\">\r\n                        ");
                __builder2.OpenElement(18, "ul");
                __builder2.AddAttribute(19, "class", "dropdown-menu dropdown-menu-right");
                __builder2.AddAttribute(20, "style", "background-color: rgba(0,0,0,0.4); margin-right: auto");
                __builder2.AddMarkupContent(21, "<li><a class=\"dropdown-item\" style=\"text-align: center; font-family: \'Arial\'; font-weight: lighter; color: rgba(255,255,255,0.5); background-color: rgba(0,0,0,0.4)\" href=\"/Profile\">Profile</a></li>\r\n                            ");
                __builder2.AddMarkupContent(22, "<li><a class=\"dropdown-item\" style=\"text-align: center; font-family: \'Arial\'; font-weight: lighter; color: rgba(255,255,255,0.5); background-color: rgba(0,0,0,0.4)\" href=\"/OwnMoment\">MyMoment</a></li>\r\n                            ");
                __builder2.OpenElement(23, "li");
                __builder2.OpenElement(24, "a");
                __builder2.AddAttribute(25, "class", "dropdown-item");
                __builder2.AddAttribute(26, "style", "text-align: center; font-family: \'Arial\'; background-color: rgba(0,0,0,0.4); color: rgba(0,162,231,0.6)");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Shared\NavMenu.razor"
                                                                                                                                                                                   go

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Logout");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
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
#line 72 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Shared\NavMenu.razor"
       
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
