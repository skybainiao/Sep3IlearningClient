#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec5df3d5f5e8bb0e1e3c42b2e8d68f077fc3716"
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
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div style=\"font-family: Arial; font-weight: bold; font-size: 50px; color: white;\">Personal Profile</div>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "media");
            __builder.AddMarkupContent(4, "<div class=\"media\"><img src=\"css/image/ProfileMedia.jpg\" alt=\"ProfileMedia\" class=\"media-object\" width=\"100%\" height=\"100%\"></div>\r\n  ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "media-body");
#nullable restore
#line 17 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
     foreach (var profile in _profiles)
    {
      if (profile.username.Contains(_service.getName()))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "style", "margin-left: 12%; max-height: 100%");
            __builder.OpenElement(9, "label");
            __builder.AddAttribute(10, "class", "settings-label3");
            __builder.AddContent(11, "Username:");
            __builder.OpenElement(12, "label");
            __builder.AddAttribute(13, "style", "width: auto; margin-left: 2%");
#nullable restore
#line 23 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(14, profile.username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                        ");
            __builder.OpenElement(16, "label");
            __builder.AddAttribute(17, "class", "settings-label3");
            __builder.AddAttribute(18, "style", "margin-left: 25%;");
            __builder.AddContent(19, "Sex:");
            __builder.OpenElement(20, "label");
            __builder.AddAttribute(21, "style", "width: auto; margin-left: 2%");
#nullable restore
#line 24 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(22, profile.sex);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                  \r\n                        <br>\r\n                        <hr style=\" border: 0.5px solid grey\">\r\n                        <br>\r\n                  \r\n                        ");
            __builder.OpenElement(24, "label");
            __builder.AddAttribute(25, "class", "settings-label3");
            __builder.AddContent(26, "Firstname:");
            __builder.OpenElement(27, "label");
            __builder.AddAttribute(28, "style", "width: auto; margin-left: 2%");
#nullable restore
#line 30 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(29, profile.firstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "label");
            __builder.AddAttribute(32, "class", "settings-label3");
            __builder.AddAttribute(33, "style", "margin-left: 25%");
            __builder.AddContent(34, "lastname:");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "style", "width: auto; margin-left: 2%");
#nullable restore
#line 31 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(37, profile.lastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                  \r\n                        <br>\r\n                        <hr style=\" border: 0.5px solid grey\">\r\n                        <br>\r\n                  \r\n                        ");
            __builder.OpenElement(39, "label");
            __builder.AddAttribute(40, "class", "settings-label3");
            __builder.AddContent(41, "Age:");
            __builder.OpenElement(42, "label");
            __builder.AddAttribute(43, "style", "width: auto; margin-left: 2%");
#nullable restore
#line 37 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(44, profile.age);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "label");
            __builder.AddAttribute(47, "class", "settings-label3");
            __builder.AddAttribute(48, "style", "margin-left: 25%");
            __builder.AddContent(49, "Country:");
            __builder.OpenElement(50, "label");
            __builder.AddAttribute(51, "style", "width: auto; margin-left: 2%");
#nullable restore
#line 38 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(52, profile.country);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                  \r\n                        <br>\r\n                        <hr style=\" border: 0.5px solid grey\">\r\n                        <br>\r\n                  \r\n                        ");
            __builder.OpenElement(54, "label");
            __builder.AddAttribute(55, "class", "settings-label3");
            __builder.AddContent(56, "PhoneNumber:");
            __builder.OpenElement(57, "label");
            __builder.AddAttribute(58, "style", "width: 15%; margin-left: 2%");
#nullable restore
#line 44 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(59, profile.phoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "class", "settings-label3");
            __builder.AddAttribute(63, "style", "margin-left: 25%");
            __builder.AddContent(64, "E-mail:");
            __builder.OpenElement(65, "label");
            __builder.AddAttribute(66, "style", "width: 30%; margin-left: 2%");
#nullable restore
#line 45 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
__builder.AddContent(67, profile.email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
        }
        else
      {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "<em>NO FOUND PROFIle</em>");
#nullable restore
#line 52 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
      }
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\r\n<br>\r\n<hr style=\" border: 0.5px solid grey\">\r\n\r\n");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
                  setttings

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "style", "margin-top: 10%; margin-left: 90%");
            __builder.AddContent(73, "Edit");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Profile.razor"
       
  private UserData _userData = new UserDataService();
  private IList<Models.Profile> _profiles = new List<Models.Profile>();


  protected override async Task OnInitializedAsync()
  {
    _profiles = await _userData.getProfile();
  }

  public void setttings()
  {
    NavigationManager.NavigateTo("/settings");
  }

  
  
  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
