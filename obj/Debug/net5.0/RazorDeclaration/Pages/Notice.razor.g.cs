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
#line 2 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using LoginExample.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using LoginExample.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using LoginExample.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Notice")]
    public partial class Notice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "D:\JetBrainsRider\Sep3IlearningClient1\Pages\Notice.razor"
 
        private String type = "";
        private UserData _userData = new UserDataService();
        private ChatData chatData = new ChatDataService();
        private IList<Request> _requests = new List<Request>();
        private IList<Message> _messages = new List<Message>();
        private IList<User> friends = new List<User>();
        private IList<Request> requests = new List<Request>();

        protected override async Task OnInitializedAsync()
        {
                _requests = await _userData.getRequest(_service.getName());
                _messages = await chatData.getAllMessages(_service.getName());
                friends = await _userData.getAllFriends(_service.getName());
                requests = await _userData.getRequest(_service.getName());
        }

        public async void getRequest()
        {
                _requests = await _userData.getRequest(_service.getName());
        }

        public void getFriendRequest()
        {
              type = "FriendRequest";  
        }

        public void getGroupRequest()
        {
                type = "GroupRequest";
        }

        public void getMessage()
        {
                type = "Message";
        }


        public void getAnnouncement()
        {
                type = "Announcement";
        }

        public void accept(string sender,string receiver)
        {
                for (int i = 0; i < friends.Count; i++)
                {
                        if (!friends[i].Username.Equals(sender))
                        {
                                _userData.addFriend(receiver, sender);
                        }
                }
                _userData.deleteRequest(sender, receiver);
                
                getRequest();
                
                Console.WriteLine("add friend");

        }

        public void refuse(string username)
        {
                chatData.sendMessage(_service.getName(), username, _service.getName() + " refuse your request");
                _userData.deleteRequest(username, _service.getName());
        }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService _service { get; set; }
    }
}
#pragma warning restore 1591
