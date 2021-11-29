#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c6f18c88e8df332c6aa0c50bbd3281fc634ad0"
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
#line 2 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
using LoginExample.Data.Impl;

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
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddAttribute(3, "style", " color: #95999c; font-weight: bolder");
            __builder.AddMarkupContent(4, "<thead><tr style=\"text-align: center; font-size: 1.5vw\"><th class=\"th\">Session</th>\r\n        <th class=\"th\">Date</th>\r\n        <th class=\"th\">Content</th>\r\n        <th class=\"th\">Preparation</th></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 18 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
     foreach(var CAO in courses)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "style", "text-align: center; font-size: 1vw");
            __builder.OpenElement(8, "td");
            __builder.AddAttribute(9, "class", "td");
            __builder.AddContent(10, 
#nullable restore
#line 21 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
              CAO.session

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n         ");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "class", "td");
            __builder.AddContent(14, 
#nullable restore
#line 24 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
              CAO.date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n         ");
            __builder.OpenElement(16, "td");
            __builder.AddAttribute(17, "class", "td");
            __builder.OpenElement(18, "ul");
            __builder.AddContent(19, 
#nullable restore
#line 28 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
                  CAO.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n         ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "class", "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
              CAO.preparation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
              }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\CAO.razor"
       
    private CourseData _courseData = new CourseDataService();
    private IList<Models.Course> courses = new List<Models.Course>();

    protected override async Task OnInitializedAsync()
    {
        courses = await _courseData.getAllCourses("CAO");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
