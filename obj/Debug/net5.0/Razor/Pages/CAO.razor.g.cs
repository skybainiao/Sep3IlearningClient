#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab6372c17b4798dfa37a9706bfa7bf4a00180499"
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
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CAO")]
    public partial class CAO : Microsoft.AspNetCore.Components.ComponentBase
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
#line 12 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                          announcement

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "style", "border-radius: 1vw; color: #cddc39; background: transparent; border: 1px solid orangered");
            __builder.AddContent(8, "Announcement");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                          plan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "margin-left: 5%; border-radius: 1vw; color: #cddc39; background: transparent; border: 1px solid orangered");
            __builder.AddContent(13, "Plan");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "CAO-text");
            __builder.AddAttribute(17, "style", "position: relative; width: 70%; height: 100%; top: 0; right: 0; left: 0; bottom: 0; margin: auto; background-color: rgba(255,255,255,0.7); color: black; margin-top: 3%; overflow-y: auto; overflow-x: auto");
#nullable restore
#line 16 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
     if (type.Equals("Announcement"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
         foreach (var announcement in _announcements)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "display: flex; flex-direction: row; display: -webkit-flex; justify-content: center; text-align: center");
            __builder.AddMarkupContent(20, "<img src=\"css/image/MomentPerson.png\" width=\"2.5%\" height=\"2.5%\">\r\n\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "style", "display: flex; flex-direction: column");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "style", "font-size: 1vw; font-family: Algerian; color:#3200f8");
#nullable restore
#line 24 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(25, announcement.LecturerName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "style", "font-size: 1vw; font-family: \'Berlin Sans FB\'");
#nullable restore
#line 25 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(29, announcement.time);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "style", "display: flex; flex-direction: column; margin-top: -3%; justify-content: center; text-align: center");
            __builder.OpenElement(33, "span");
            __builder.AddAttribute(34, "style", "margin-top: 5%; text-align: center; font-family: \'Bell MT\'; font-weight: bolder; font-size: 1vw");
#nullable restore
#line 29 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(35, announcement.content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                <br>");
#nullable restore
#line 31 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                 if (look)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                                      () => getcontent(announcement.LecturerName, announcement.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "style", "font-size: 2vw; font-family: Forte; color: hotpink; outline: none; background: transparent; border: none");
            __builder.AddContent(40, "Comment");
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                }
                else if (look == false)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                     if (content != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<br>\r\n                        ");
            __builder.AddMarkupContent(42, "<p style=\"font-size: 2vw; font-weight: bolder; color: rgba(255,68,221,0.8); font-family: Forte\">Comment</p>\r\n                        <br>");
#nullable restore
#line 42 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                         foreach (var commentCAO in _comments)
                        {
                            if (commentCAO.username.Equals(_service.getName()) && commentCAO.publisher.Equals(announcement.LecturerName))
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "p");
            __builder.AddAttribute(44, "style", "color: #02abff; font-size: 1vw");
#nullable restore
#line 46 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(45, commentCAO.username);

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, " : ");
#nullable restore
#line 46 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(47, commentCAO.content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                            }
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "style", "width: 70%; height: 100%; flex-direction: row; display: flex; float: left; margin-top: 3%; left: 0; right: 0; margin: auto;");
            __builder.OpenElement(50, "input");
            __builder.AddAttribute(51, "style", "display: flex; height: 30px; width: 100%; border-radius: 2vw");
            __builder.AddAttribute(52, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                                          content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => content = __value, content));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                                              () => comment(announcement.LecturerName, announcement.time)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "style", "margin-left: 5%; border-radius: 1vw; height: 30px; width: 20%");
            __builder.AddContent(58, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<p>no comments were found</p>");
#nullable restore
#line 57 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            <br>\r\n            <hr style=\" border: 1px solid black\">\r\n            <br>");
#nullable restore
#line 64 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
         
    }
    else if (type.Equals("Plan"))
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(61, "table");
            __builder.AddAttribute(62, "class", "table table-striped");
            __builder.AddAttribute(63, "style", " color: #f83a00; font-weight: bolder");
            __builder.AddMarkupContent(64, "<thead><tr style=\"text-align: center; font-size: 1.5vw\"><th class=\"th\">Session</th>\r\n                <th class=\"th\">Date</th>\r\n                <th class=\"th\">Content</th>\r\n                <th class=\"th\">Preparation</th></tr></thead>\r\n            ");
            __builder.OpenElement(65, "tbody");
#nullable restore
#line 78 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
             foreach(var CAO in courses)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "tr");
            __builder.AddAttribute(67, "style", "text-align: center; font-size: 1vw");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "class", "td");
#nullable restore
#line 81 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(70, CAO.session);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                 ");
            __builder.OpenElement(72, "td");
            __builder.AddAttribute(73, "class", "td");
#nullable restore
#line 84 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(74, CAO.date);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                 ");
            __builder.OpenElement(76, "td");
            __builder.AddAttribute(77, "class", "td");
            __builder.OpenElement(78, "ul");
#nullable restore
#line 88 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(79, CAO.content);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                 ");
            __builder.OpenElement(81, "td");
            __builder.AddAttribute(82, "class", "td");
#nullable restore
#line 92 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
__builder.AddContent(83, CAO.preparation);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 101 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\CAO.razor"
       
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
        courses = await _courseData.getAllCourses("CAO");
        _announcements = await _courseData.getAllAnnouncement("CAO");
    }

    public async void comment(string publisher,string time)
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
