#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Home.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da94fd3d2ffc84591b5fb51577db1a69946604b"
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
#line 4 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Home.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Home")]
    public partial class Home : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "<div class=\"index-background\"></div>\r\n  ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "style", "position: fixed; z-index: 3; list-style-type: none; margin-left: 75%; margin-top: -3%");
            __builder.AddMarkupContent(4, @"<li class=""nav-item""><div class=""item-content""><button type=""button"" class=""dropdown-toggle"" data-bs-toggle=""dropdown"" style=""font-weight: normal; text-align: center; font-size:25px; color: #34ce57; background: transparent; border-width: 0; outline:none;"">
          Course
        </button>
        <ul class=""dropdown-menu"" style=""background-color: rgba(0,0,0,0.4)""><li><a class=""dropdown-item"" href=""/SDJ"" style=""font-family: 'Arial'; font-weight: lighter"">SDJ</a></li>
          <li><a class=""dropdown-item"" href=""/DNP"" style=""font-family: 'Arial'; font-weight: lighter"">DNP</a></li>
          <li><a class=""dropdown-item"" href=""/CAO"" style=""font-family: 'Arial'; font-weight: lighter"">CAO</a></li>
          <li><a class=""dropdown-item"" href=""/NES"" style=""font-family: 'Arial'; font-weight: lighter"">NES</a></li></ul></div></li>
    
    ");
            __builder.AddMarkupContent(5, @"<li class=""nav-item""><div class=""item-content""><button type=""button"" class=""dropdown-toggle"" data-bs-toggle=""dropdown"" style=""font-weight: normal; text-align: center; font-size:25px; color: #34ce57; background: transparent; border-width: 0; outline:none;""><div class=""oi oi-menu"" style=""text-align: center; font-size: 25px; font-weight: normal;"">Menu</div></button>
        <ul class=""dropdown-menu"" style=""background-color: rgba(0,0,0,0.4)""><li><a class=""dropdown-item"" href=""/wechat"" style=""font-family: 'Arial'; font-weight: lighter; text-align: center"">WeChat</a></li>
          <li><a class=""dropdown-item"" href=""/moment"" style=""font-family: 'Arial'; font-weight: lighter; text-align: center"">Moment</a></li>
          <li><a class=""dropdown-item"" href=""/group"" style=""font-family: 'Arial'; font-weight: lighter; text-align: center"">Group</a></li>
          <li><a class=""dropdown-item"" href=""/groupchat"" style=""font-family: 'Arial'; font-weight: lighter; text-align: center"">GroupChat</a></li>
          <li><a class=""dropdown-item"" href=""/contactus"" style=""font-family: 'Arial'; font-weight: lighter; text-align: center"">ContactUs</a></li></ul></div></li>

    ");
            __builder.AddMarkupContent(6, @"<li class=""nav-item""><div class=""item-content""><a href=""/Notice""><img src=""css/image/Notice.png"" alt=""Notice"" type=""button"" width=""30px"" height=""30px"" style=""margin-top: 2%""><label style=""color: red; font-size: 10px"">100</label></a></div></li>
    
                ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "nav-item");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "item-content");
            __builder.AddMarkupContent(11, "<img src=\"css/image/person.jpg\" alt=\"Login\" type=\"button\" class=\"dropdown-toggle\" data-bs-toggle=\"dropdown\" width=\"30px\" height=\"30px\" style=\"margin-top: 3%\">\r\n                        ");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "dropdown-menu");
            __builder.AddAttribute(14, "style", "background-color: rgba(0,0,0,0.4)");
            __builder.AddMarkupContent(15, "<li><a class=\"dropdown-item\" style=\"text-align: center; font-family: Aharoni\" href=\"/Profile\">Profile</a></li>\r\n                            ");
            __builder.OpenElement(16, "li");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "class", "dropdown-item");
            __builder.AddAttribute(19, "style", "text-align: center; font-family: Aharoni; background-color: rgba(0,0,0,0.4); color: rgba(255,255,255,0.4)");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Home.razor"
                                                                                                                                                                                     go

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n  ");
            __builder.AddMarkupContent(23, "<div class=\"index-A\"><div style=\"flex-direction: column; position: absolute; z-index: 3; margin-top: 27%; margin-left: 57%; margin-bottom: 73%; margin-right: 33%\"><form class=\"chaxun\" style><span style=\"width:600px; height: 30px; text-align: center; font-size: 50px; color: white; margin-right: 10%\">Software Engineering</span>\r\n        <br>\r\n        <button style=\"font-size: 25px; color: white; width: 420px; height: 50px; text-align: center; border-radius: 10px; margin-top: 40px; margin-right: 10%; border: 1px solid red; background-color: red; border-bottom-width: 10px; border-top-width: 5px; border-left-width: 10px; border-right-width: 10px; transform: rotate(-45deg);\r\n                                                                                                                                                                                                                                                                                                   -webkit-transform: rotate(-45deg);\" type=\"button\">Welcome our Journey </button></form></div>\r\n    <img src=\"css/image/backmath.jpg\" width=\"100%\" height=\"70%\" style=\"position: relative\">\r\n    <div class=\"index-B\" style=\"text-align: center\"><a href=\"/SDJ\"><img src=\"css/image/SDJ.png\" width=\"23%\" height=\"60%\" style=\"border-radius: 50%; overflow: hidden;\"></a>\r\n      <a href=\"/DNP\"><img src=\"css/image/DNP.png\" width=\"23%\" height=\"60%\" style=\"border-radius: 50%; overflow: hidden;\"></a>\r\n      <a href=\"/CAO\"><img src=\"css/image/CAO.png\" width=\"23%\" height=\"60%\" style=\"border-radius: 50%; overflow: hidden;\"></a>\r\n      <a href=\"/NES\"><img src=\"css/image/NES.png\" width=\"23%\" height=\"60%\" style=\"border-radius: 50%; overflow: hidden;\"></a>\r\n      <p style=\"margin: auto; top: 150%; bottom: 0; left: 0; right: 0; text-align: center; color: black; font-size: 30px; font-weight: normal; position: absolute; width: 60%; height: 40%\">Software engineering is a discipline that studies the use of engineering methods to build and maintain effective, practical and high-quality software.It involves programming languages, databases, software development tools, system platforms, standards, embedded systems, man-machine interfaces, operating systems, compilers, databases, etc. These applications promote economic and social development, and also improve work efficiency and life efficiency.</p></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Home.razor"
 

  private bool collapseNavMenu = true;
     
  private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
     
  private void ToggleNavMenu() {
    collapseNavMenu = !collapseNavMenu;
  }
     

  public async Task go() {

    try {
      ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
      _navigationManager.NavigateTo("/Login");
    } catch (Exception e) { }
  }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
