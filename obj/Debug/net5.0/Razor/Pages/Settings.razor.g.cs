#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d2a7236be88406194ba02cfb9398d8966a07290"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div style=\"font-family: Arial; font-weight: bold; font-size: 50px; color:white;\">Personal settings</div>\r\n");
            __builder.AddMarkupContent(2, "<div class=\"media\"><div class=\"media\"><img src=\"css/image/ProfileMedia.jpg\" alt=\"ProfileMedia\" class=\"media-object\" width=\"350px\" height=\"400px\"></div>\r\n  <div class=\"media-body\"><div style=\"margin-left: 12%; \"><label class=\"settings-label1\">Name:</label>\r\n      <input style=\"margin-left:2%; width: 35%; height: 20%; border:none; background-color: rgba(255,255,255,0.3)\">\r\n    \r\n      <label style=\"margin-left: 20%; font-family: Forte; font-size: 25px; color: white\">Sex:</label>\r\n      <label style=\"margin-left: 3%; color: white\"><input type=\"radio\" name=\"sexRadio\" οnclick=\"getRadio();\" checked=\"checked\">Male</label> \r\n      <label style=\"margin-left: 3%; color: white\"><input type=\"radio\" name=\"sexRadio\" οnclick=\"getRadio();\">Female</label>\r\n    \r\n      <br>\r\n      <hr style=\" border: 0.5px solid grey\">\r\n      <br>\r\n      \r\n      <label class=\"settings-label1\">User Name:</label><input style=\"margin-left: 2%; width: 35%; height: 40%; border:none; background-color: rgba(255,255,255,0.3)\">\r\n    \r\n      <br>\r\n      <hr style=\" border: 0.5px solid grey\">\r\n      <br>\r\n    \r\n      <label class=\"settings-label1\">Phone Number:</label><input style=\"margin-left: 2%; width: 35%; height: 40%; border:none; background-color: rgba(255,255,255,0.3)\">\r\n      \r\n      <br>\r\n      <hr style=\" border: 0.5px solid grey\">\r\n      <br>\r\n    \r\n      <label class=\"settings-label1\">E-mail:</label><input style=\"margin-left: 2%; width: 35%; height: 40%; border:none; background-color: rgba(255,255,255,0.3)\"></div></div></div>\r\n\r\n<br>\r\n<hr style=\" border: 0.5px solid grey\">\r\n\r\n");
            __builder.AddMarkupContent(3, @"<div style=""margin-left: 29%""><label class=""settings-label2"">Recent Password:</label><input style=""margin-left: 2%; width: 35%; height: 40%; border:none; background-color: rgba(255,255,255,0.3)"">

  <br>
  <hr style="" border: 0.5px solid grey"">

  <label class=""settings-label2"">New password:</label><input style=""margin-left: 2%; width: 35%; height: 40%; border:none; background-color: rgba(255,255,255,0.3)"">

  <br>
  <hr style="" border: 0.5px solid grey"">

  <label class=""settings-label2"">Confirm new password:</label><input style=""margin-left: 2%; width: 35%; height: 40%; border:none; background-color: rgba(255,255,255,0.3)""></div>

");
            __builder.AddMarkupContent(4, "<button style=\"margin-left: 93%; margin-top: 1%; width: 70px; height: 30px\">Save</button>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591