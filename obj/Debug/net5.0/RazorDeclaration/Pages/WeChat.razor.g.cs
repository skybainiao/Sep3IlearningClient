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
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
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
#line 53 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\WeChat.razor"
       
    private UserData _userData = new UserDataService();
    private ChatData chatData = new ChatDataService();
    private IList<User> _users = new List<User>();
    private IList<Message> _messages = new List<Message>();
    private String username;
    private String text;



    protected override async Task OnInitializedAsync()
    {
        _users = await _userData.getAllFriends(_service.getName());
        Console.WriteLine(System.Diagnostics.Process.GetCurrentProcess());
    }


    public async void getMessagess(String username)
    {
        _messages = await chatData.getMessages(_service.getName(), username);
        this.username = username;
    }

    
    public void sendMessage()
    {
        chatData.sendMessage(_service.getName(), username, text);
        getMessagess(username);
    }

    public void profile()
    {
        NavigationManager.NavigateTo("/profile");
    }

    public void search()
    {
        NavigationManager.NavigateTo("/search");
    }
    
    
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
