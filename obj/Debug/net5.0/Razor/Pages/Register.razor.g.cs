#pragma checksum "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20199a243ef28e1d1ca04a30fe34ec82f2773fda"
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
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "display:flex; flex-direction: column; height: 75vh");
            __builder.OpenElement(2, "form");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "style", "background-color: rgba(0,0,0,0.5); width: 40%; justify-content: center; align-items: center; margin-top: 50px");
            __builder.AddAttribute(5, "placeholder", "username");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
                                                                                                                                                               username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "style", "background-color: rgba(0,0,0,0.5); width: 40%");
            __builder.AddAttribute(11, "placeholder", "password");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
                                                                                               password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "style", "background-color: rgba(0,0,0,0.5); width: 40%");
            __builder.AddAttribute(17, "placeholder", "password again");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
                                                                                                    passwordagain

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => passwordagain = __value, passwordagain));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
                      CreateUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "style", "color: #8fd19e; background: transparent; border: 1px solid black; border-radius: 1vw; width: 200px");
            __builder.AddContent(24, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
                      Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "style", "color: #8fd19e; background: transparent; border: 1px solid black; border-radius: 1vw; width: 200px");
            __builder.AddContent(29, "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Register.razor"
       
    private String username;
    private String password;
    private String passwordagain;
    private UserData _userData = new UserDataService();


    public async void CreateUser()
    {
        User user = new User()
        {
            Username = username,
            Password = password
        };

        if (username!=null && password!=null && passwordagain!=null)
        {
            if (password.Equals(passwordagain))
            {
                await _userData.post(user);
                NavigationManager.NavigateTo("/Login");
            }
        }
        
    }

    public void Cancel()
    {
        NavigationManager.NavigateTo("/Login");
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
