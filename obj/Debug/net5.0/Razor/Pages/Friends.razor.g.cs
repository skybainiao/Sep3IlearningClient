#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bb25d9deb35f3e22292cf3c03b3a1443dd68901"
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
#line 1 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using LoginExample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\JetBrainsRider\Sep3IlearningClient\_Imports.razor"
using LoginExample.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Friends")]
    public partial class Friends : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr style=\"border: 2px solid white\">\r\n    <br>");
#nullable restore
#line 5 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
 if (_adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 10 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-hover");
            __builder.AddMarkupContent(4, @"<thead><tr style=""color: white""><th>FirstName</th>
            <th>LastName</th>
            <th>HairColor</th>
            <th>EyeColor</th>
            <th>Age</th>
            <th>Weight</th>
            <th>Height</th>
            <th>Sex</th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 27 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
         foreach (var adult in _adults)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "style", "color: white");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 30 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 31 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 32 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 33 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 34 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 35 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 36 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 37 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                     adult.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "oi oi-plus");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                                                     () => Add(adult)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "style", "margin-right: 10px");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-dark");
            __builder.AddAttribute(39, "style", "left: 10px");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
                                                                          () => Modify(adult)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Modify");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\JetBrainsRider\Sep3IlearningClient\Pages\Friends.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
