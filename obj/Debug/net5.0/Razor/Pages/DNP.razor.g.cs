#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4a859f90b724021fa64e3cd0a20f74cc064f161"
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
#line 2 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/DNP")]
    public partial class DNP : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "display:flex; flex-direction: column; height: 75vh");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "display: flex; flex-direction: row; justify-content: center");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                          announcement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Announcement");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                          plan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "style", "margin-left: 5%");
            __builder.AddContent(12, "Plan");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "DNP-text");
            __builder.AddAttribute(16, "style", "position: relative; width: 70%; height: 100%; top: 0; right: 0; left: 0; bottom: 0; margin: auto; background-color: rgba(255,255,255,0.7); color: black; margin-top: 3%; overflow-y: auto");
#nullable restore
#line 16 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
     if (type.Equals("Announcement"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
         foreach (var announcement in _announcements)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "style", "display: flex; flex-direction: row; display: -webkit-flex; justify-content: center; text-align: center");
            __builder.AddMarkupContent(19, "<img src=\"css/image/MomentPerson.png\" width=\"2.5%\" height=\"2.5%\">\r\n\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "display: flex; flex-direction: column");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "style", "font-size: 1vw; font-family: Algerian; color:#3200f8");
            __builder.AddContent(24, 
#nullable restore
#line 24 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                                                                     announcement.LecturerName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "style", "font-size: 1vw; font-family: \'Berlin Sans FB\'");
            __builder.AddContent(28, 
#nullable restore
#line 25 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                                                                 announcement.time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "style", "display: flex; flex-direction: column; margin-top: -3%; justify-content: center; text-align: center");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "style", "margin-top: 5%; text-align: center; font-family: \'Bell MT\'; font-weight: bolder; font-size: 1vw");
            __builder.AddContent(34, 
#nullable restore
#line 29 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                                                                                                               announcement.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                <br>");
#nullable restore
#line 31 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                 if (look)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                      () => getcontent(announcement.LecturerName, announcement.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "style", "font-size: 2vw; font-family: Forte; color: hotpink; outline: none; background: transparent; border: none");
            __builder.AddContent(39, "Comment");
            __builder.CloseElement();
#nullable restore
#line 34 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                }
                else if (look == false)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                     if (content != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(40, "<br>\r\n                        ");
            __builder.AddMarkupContent(41, "<p style=\"font-size: 2vw; font-weight: bolder; color: rgba(255,68,221,0.8); font-family: Forte\">Comment</p>\r\n                        <br>");
#nullable restore
#line 42 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                         foreach (var commentDNP in _comments)
                        {
                            if (commentDNP.username.Equals(_service.getName()) && commentDNP.publisher.Equals(announcement.LecturerName))
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "style", "color: #02abff; font-size: 1vw");
            __builder.AddContent(44, 
#nullable restore
#line 46 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                                                           commentDNP.username

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(45, " : ");
            __builder.AddContent(46, 
#nullable restore
#line 46 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                                                                                  commentDNP.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 47 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "style", "width: 70%; height: 100%; flex-direction: row; display: flex; float: left; margin-top: 3%; left: 0; right: 0; margin: auto;");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "style", "display: flex; height: 30px; width: 100%; border-radius: 2vw");
            __builder.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                          content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => content = __value, content));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                            ");
            __builder.OpenElement(54, "button");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                                              () => comment(announcement.LecturerName, announcement.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "style", "margin-left: 5%; border-radius: 1vw; height: 30px; width: 20%");
            __builder.AddContent(57, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "<p>no comments were found</p>");
#nullable restore
#line 57 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            <br>\r\n            <hr style=\" border: 1px solid black\">\r\n            <br>");
#nullable restore
#line 64 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
         
    }
    else if (type.Equals("Plan"))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "table");
            __builder.AddAttribute(61, "class", "table table-striped");
            __builder.AddAttribute(62, "style", " color: #f83a00; font-weight: bolder");
            __builder.AddMarkupContent(63, @"<thead><tr style=""text-align: center; font-size: 1.5vw""><th class=""th"">Session</th>
                     <th class=""th"">Date</th>
                     <th class=""th"">Content</th>
                     <th class=""th"">Preparation</th></tr></thead>
                 ");
            __builder.OpenElement(64, "tbody");
#nullable restore
#line 78 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                  foreach(var DNP in courses)
                 {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "tr");
            __builder.AddAttribute(66, "style", "text-align: center; font-size: 1vw");
            __builder.OpenElement(67, "td");
            __builder.AddAttribute(68, "class", "td");
            __builder.AddContent(69, 
#nullable restore
#line 81 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                           DNP.session

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                      ");
            __builder.OpenElement(71, "td");
            __builder.AddAttribute(72, "class", "td");
            __builder.AddContent(73, 
#nullable restore
#line 84 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                           DNP.date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                      ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "class", "td");
            __builder.OpenElement(77, "ul");
            __builder.AddContent(78, 
#nullable restore
#line 88 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                               DNP.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                      ");
            __builder.OpenElement(80, "td");
            __builder.AddAttribute(81, "class", "td");
            __builder.AddContent(82, 
#nullable restore
#line 92 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                           DNP.preparation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
                           }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\DNP.razor"
       
    private CourseData _courseData = new CourseDataService();
    private IList<Models.Course> courses = new List<Models.Course>();
    private IList<Announcement> _announcements = new List<Announcement>();
    private IList<Comment> _comments = new List<Comment>();
    private string content = "";
    private UserData _userData = new UserDataService();
    private bool look = true;
    private string type = "";

    protected override async Task OnInitializedAsync()
    {
        courses = await _courseData.getAllCourses("DNP");
        _announcements = await _courseData.getAllAnnouncement("DNP");

    }

    public async void comment(string publisher, string time)
    {
        Comment comment = new Comment()
        {
            username = (_service.getName()),
            publisher = publisher,
            content = content,
            time = time
        };
        if (content != null)
        {
            await _userData.addComment(comment);
            _comments = await _userData.getComments(_service.getName(), publisher, time);
            content = "";
        }
    }

    public async void getcontent(string publisher, string time)
    {
        _comments = await _userData.getComments(_service.getName(), publisher, time);
        look = false;
    }

    public void announcement()
    {
        type = "Announcement";
    }
    
    public void plan()
    {
        type = "Plan";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
