#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b4a2062b721a5b0576b6d1fe73007da66ef639"
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
#line 2 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/NES")]
    public partial class NES : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\" border: 2px solid white\">\r\n<br>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-striped");
            __builder.AddAttribute(3, "style", " color: #95999c; font-weight: bolder");
            __builder.AddMarkupContent(4, "<thead><tr style=\"text-align: center; font-size: 25px\"><th>Session</th>\r\n        <th>Date</th>\r\n        <th>Content</th>\r\n        <th>Preparation</th></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 18 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
     foreach(var NES in courses)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "style", "text-align: center; font-size: 35px");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 21 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
              NES.session

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n         ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 24 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
              NES.date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n         ");
            __builder.OpenElement(14, "td");
            __builder.OpenElement(15, "ul");
            __builder.OpenElement(16, "li");
            __builder.AddContent(17, 
#nullable restore
#line 28 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
                      NES.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n         ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 32 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
              NES.preparation

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
              }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\NES.razor"
       
    private CourseData _courseData = new CourseDataService();
    private IList<Models.Course> courses = new List<Models.Course>();

    protected override async Task OnInitializedAsync()
    {
        courses = await _courseData.getAllCourses("NES");
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
