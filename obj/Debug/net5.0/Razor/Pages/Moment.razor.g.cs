#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfad063f6442f2b2968a66934e0ff0d13e8ec76f"
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
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
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
#line 12 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
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
#line 18 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
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
#line 19 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
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
#line 23 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
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
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                       () => like(moment.username,moment.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "src", 
#nullable restore
#line 26 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
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
            __builder.AddContent(37, 
#nullable restore
#line 27 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                     moment.like

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "p");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                       () => dislike(moment.username,moment.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "src", 
#nullable restore
#line 30 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
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
            __builder.AddContent(49, 
#nullable restore
#line 31 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                     moment.dislike

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                 if (show)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                     () => getComment(moment.username,moment.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "style", "font-size: 2vw; font-family: Forte; color: hotpink; outline: none; background: transparent; border: none");
            __builder.AddContent(53, "Comment");
            __builder.CloseElement();
#nullable restore
#line 38 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                }
                else if (show == false)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                     if (comments != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                         foreach (var comment1 in comments)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(54, "p");
            __builder.AddContent(55, 
#nullable restore
#line 45 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                    comment1.username

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(56, " :  ");
            __builder.AddContent(57, 
#nullable restore
#line 45 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                          comment1.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 46 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                   
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "style", "flex-direction: row; display: flex; float: left; margin-top: 3%; left: 0; right: 0; margin: auto;");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "style", "display: flex; height: 40px; width: 600px; border-radius: 1vw");
            __builder.AddAttribute(62, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                                                  content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => content = __value, content));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                                                    ");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                                                                                      () => comment(moment.username,moment.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "style", "margin-left: 5%; border-radius: 1vw; height: 40px; width: 200px");
            __builder.AddContent(68, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "<p>no comments were found</p>");
#nullable restore
#line 56 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
                     
                    
                    
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            <br>\r\n            <hr style=\" border: 1px solid black\">\r\n            <br>");
#nullable restore
#line 65 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n\r\n");
            __builder.AddMarkupContent(72, "<a href=\"/editmoment\" style=\"display: flex; text-align: center; outline: none; background: transparent; border: none; align-items: center; justify-content: center; margin-top: 1%; \"><img src=\"css/image/EdiMoment.png\" width=\"2%\" height=\"2%\"></a>\r\n");
            __builder.AddMarkupContent(73, "<p style=\"justify-content: center; text-align: center; font-size: 1.2vw; font-family: Fonte; color: #4dff80\">Publish</p>\r\n<hr style=\" border: 2px solid white\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Moment.razor"
       
    private string url1 = "css/image/Redheart.png";
    private string url2 = "css/image/GreenDislike.png";
    private UserData _userData = new UserDataService();
    private ChatData _chatData = new ChatDataService();
    private IList<Message> _messages = new List<Message>();
    private IList<Models.Moment> _moments = new List<Models.Moment>();
    private string content = "";
    private IList<Comment> comments = new List<Comment>();
    private bool show = true;
    
    

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

    public async void comment(string publisher,string time)
    {
        Comment comment = new Comment()
        {
            username = _service.getName(),
            publisher = publisher,
            content = content,
            time = time
        };
        await _userData.addComment(comment);
        comments = await _userData.getComments(_service.getName(), publisher, time);
        content = "";
    }

    public async void getComment(string publisher,string time)
    {
        comments = await _userData.getComments(_service.getName(), publisher, time);
        show = false;
       
        
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
