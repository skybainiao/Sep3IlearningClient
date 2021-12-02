#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "779c87cf715c22d7a0736997ddf074bd08111f6c"
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
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
using LoginExample.Models;

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
#line 12 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
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
#nullable restore
#line 18 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
__builder.AddContent(13, moment.username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "span");
            __builder.AddAttribute(16, "style", "font-size: 1vw; font-family: \'Berlin Sans FB\'");
#nullable restore
#line 19 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
__builder.AddContent(17, moment.time);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "display: flex; flex-direction: column; margin-top: -3%; justify-content: center; text-align: center");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "style", "margin-top: 5%; text-align: center; font-family: \'Bell MT\'; font-weight: bolder; font-size: 1vw");
#nullable restore
#line 23 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
__builder.AddContent(23, moment.content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "style", "display: flex; flex-direction: row; justify-content: center; align-items: center; margin-top: 3%");
            __builder.OpenElement(27, "p");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
                                       () => like(moment.username,moment.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "src", 
#nullable restore
#line 26 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
                                                                                     url1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "width", "10%");
            __builder.AddAttribute(32, "height", "60%");
            __builder.AddAttribute(33, "style", "text-align: center");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "style", "color: black");
#nullable restore
#line 27 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
__builder.AddContent(37, moment.like);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "p");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
                                       () => dislike(moment.username,moment.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "src", 
#nullable restore
#line 30 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
                                                                                        url2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "width", "10%");
            __builder.AddAttribute(44, "height", "60%");
            __builder.AddAttribute(45, "style", "text-align: center");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                        ");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "style", "color: black");
#nullable restore
#line 31 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
__builder.AddContent(49, moment.dislike);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "<br>\r\n            <hr style=\" border: 1px solid black\">\r\n            <br>");
#nullable restore
#line 39 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.AddMarkupContent(52, "<a href=\"/editmoment\" style=\"display: flex; text-align: center; outline: none; background: transparent; border: none; align-items: center; justify-content: center; margin-top: 1%; \"><img src=\"css/image/EdiMoment.png\" width=\"2%\" height=\"2%\"></a>\r\n");
            __builder.AddMarkupContent(53, "<p style=\"justify-content: center; text-align: center; font-size: 1.2vw; font-family: Fonte; color: #4dff80\">Publish</p>\r\n<hr style=\" border: 2px solid white\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
       
    private string url1 = "css/image/Redheart.png";
    private string url2 = "css/image/GreenDislike.png";
    private UserData _userData = new UserDataService();
    private ChatData _chatData = new ChatDataService();
    private IList<Message> _messages = new List<Message>();
    private IList<Models.Moment> _moments = new List<Models.Moment>();
    private string un = "";

    protected override async Task OnInitializedAsync()
    {
        _moments = await _userData.getMoments();
        _messages = await _chatData.getAMS();
    }
    
    public async void like(string username,string time)
    {

        await _chatData.sendMessage(_service.getName(), "System", "like"+time);
        await _userData.like(username);
        _moments = await _userData.getMoments();
        
    }

    
    public async void dislike(string username,string time)
    {
        
        await _chatData.sendMessage(_service.getName(), "System", "dislike"+time);
        await _userData.dislike(username);
        _moments = await _userData.getMoments();

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
