// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 2 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/WeChat")]
    public partial class WeChat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "D:\JetBrainsRider\Sep3IlearningClient\Pages\WeChat.razor"
       
    private UserData _userData = new UserDataService();
    private IList<User> _users = new List<User>();
    private IList<Message> _messages = new List<Message>();
    private String username;
    private String text;



    protected override async Task OnInitializedAsync()
    {
        _users = await _userData.getAllFriends(_service.getName());
    }


    public async void getMessagess(String username)
    {
        _messages = await _userData.getMessages(_service.getName(), username);
        this.username = username;
    }

    
    public void sendMessage()
    {
        _userData.sendMessage(_service.getName(), username, text);
        getMessagess(username);
    }

    public void fuck()
    {
        NavigationManager.NavigateTo("/counter");
    }
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
