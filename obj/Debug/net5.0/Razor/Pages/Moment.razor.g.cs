#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2d32f71e220f6212d3988e4f7a195ea84173c94"
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
#line 2 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Moment")]
    public partial class Moment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "Moment-main");
            __builder.AddAttribute(3, "style", "height: 70vh");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "position: relative; width: 100%; height: 100%; background-color: rgba(255,255,255,0.5); overflow-y: auto");
#nullable restore
#line 9 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
         foreach(var moment in _moments)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "display: flex; flex-direction: row; display: -webkit-flex; justify-content: center; text-align: center");
            __builder.AddMarkupContent(8, "<img src=\"css/image/MomentPerson.png\" width=\"2.5%\" height=\"2.5%\">\r\n             \r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "style", "display: flex; flex-direction: column");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "style", "font-size: 1vw; font-family: Algerian; color:#3200f8");
            __builder.AddContent(13, 
#nullable restore
#line 15 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                                                     moment.username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "style", "font-size: 1vw; font-family: \'Berlin Sans FB\'");
            __builder.AddContent(17, 
#nullable restore
#line 16 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                                                 moment.time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "display: flex; flex-direction: column; margin-top: -3%; justify-content: center; text-align: center");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "style", "margin-top: 5%; text-align: center; font-family: \'Bell MT\'; font-weight: bolder; font-size: 1vw");
            __builder.AddContent(23, 
#nullable restore
#line 20 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                                                                                               moment.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "style", "display: flex; flex-direction: row; justify-content: center; align-items: center; margin-top: 3%");
            __builder.OpenElement(27, "p");
            __builder.AddMarkupContent(28, "Like:\r\n                        ");
            __builder.OpenElement(29, "img");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                       change1

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "src", 
#nullable restore
#line 23 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                     url1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "width", "10%");
            __builder.AddAttribute(33, "height", "60%");
            __builder.AddAttribute(34, "style", "text-align: center");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "label");
            __builder.AddAttribute(37, "style", "color: black");
            __builder.AddContent(38, 
#nullable restore
#line 24 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                     moment.like

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "p");
            __builder.AddMarkupContent(41, "Dislike:\r\n                        ");
            __builder.OpenElement(42, "img");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                       change2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "src", 
#nullable restore
#line 27 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                     url2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "width", "10%");
            __builder.AddAttribute(46, "height", "60%");
            __builder.AddAttribute(47, "style", "text-align: center");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "label");
            __builder.AddAttribute(50, "style", "color: black");
            __builder.AddContent(51, 
#nullable restore
#line 28 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                     moment.dislike

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                <p></p>\r\n                <input style=\"width: 70%; margin-top: 2%; height: 5%; border-radius: 1vw; justify-content: center\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "<br>\r\n            <hr style=\" border: 1px solid black\">\r\n            <br>");
#nullable restore
#line 38 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\r\n");
            __builder.AddMarkupContent(55, "<a href=\"/editmoment\" style=\"display: flex; text-align: center; outline: none; background: transparent; border: none; align-items: center; justify-content: center; margin-top: 1%; \"><img src=\"css/image/EdiMoment.png\" width=\"2%\" height=\"2%\"></a>\r\n");
            __builder.AddMarkupContent(56, "<p style=\"justify-content: center; text-align: center; font-size: 1.2vw; font-family: Fonte; color: #4dff80\">Publish</p>\r\n<hr style=\" border: 2px solid white\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
       
    private string url1 = "css/image/WhiteStar.png";
    private string url2 = "css/image/WhiteDislike.png";
    private UserData _userData = new UserDataService();
    private IList<Models.Moment> _moments = new List<Models.Moment>();

    protected override async Task OnInitializedAsync()
    {
        _moments = await _userData.getMoments();
    }

    public void change1()
    {
        if (url1.Equals("css/image/WhiteStar.png"))
        {
            url1 = "css/image/Redheart.png";
        }
        else
        {
            url1 = "css/image/WhiteStar.png";
        }
    }

    public void change2()
    {
        if (url2.Equals("css/image/WhiteDislike.png"))
        {
            url2 = "css/image/GreenDislike.png";
        }
        else
        {
            url2 = "css/image/WhiteDislike.png";
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
