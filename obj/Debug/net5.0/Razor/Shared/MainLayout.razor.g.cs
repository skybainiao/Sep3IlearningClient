#pragma checksum "D:\JetBrainsRider\Sep3IlearningClient\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0fa4573fa07d4bb2aeb50d8d4d6802c92dc019c"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginExample.Shared
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
#nullable restore
#line 1 "D:\JetBrainsRider\Sep3IlearningClient\Shared\MainLayout.razor"
using LoginComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient\Shared\MainLayout.razor"
using LoginExample.Authentication;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "nav");
                __builder2.OpenComponent<LoginExample.Shared.NavMenu>(4);
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "content px-4");
            __builder.AddContent(10, 
#nullable restore
#line 20 "D:\JetBrainsRider\Sep3IlearningClient\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\JetBrainsRider\Sep3IlearningClient\Shared\MainLayout.razor"
       

    [CascadingParameter] protected Task<AuthenticationState> AuthStat { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        var user = (await AuthStat).User;
        if(!user.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo($"/Login");
            // NavigationManager.NavigateTo($"/Login?returnUrl={Uri.EscapeDataString(NavigationManager.Uri)}");
        }
    }

    public void go()
    {
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/Login");
        }
        catch (Exception e)
        {
            e.ToString();
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
