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
#line 2 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\45527\Desktop\Sep3Project\Sep3Client\Pages\Moment.razor"
       
    private string url1 = "css/image/RedHeart.png";
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
        if (content!=null)
        {
            await _userData.addComment(comment);
            comments = await _userData.getComments(_service.getName(), publisher, time);
            content = ""; 
        }
         
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
