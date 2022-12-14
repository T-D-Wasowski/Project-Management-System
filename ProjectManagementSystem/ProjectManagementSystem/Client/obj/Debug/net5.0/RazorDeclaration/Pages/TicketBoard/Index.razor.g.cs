// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectManagementSystem.Client.Pages.TicketBoard
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using ProjectManagementSystem.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using ProjectManagementSystem.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using ProjectManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\TicketBoard\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ticketboard")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\TicketBoard\Index.razor"
       

    private User User { get; set; } = new User();
    private List<User> Users { get; set; } = new List<User>();
    private List<Ticket> Tickets { get; set; } = new List<Ticket>();
    private List<Ticket> AssignedTickets { get; set; } = new List<Ticket>();
    private List<UserTicket> UserTickets { get; set; } = new List<UserTicket>();
    private List<Project> Projects { get; set; } = new List<Project>();
    private List<string> States { get; set; } = new List<string>();


    protected override async Task OnInitializedAsync()
    {
        try
        {
            Tickets = await Http.GetFromJsonAsync<List<Ticket>>("/api/Tickets");
            Projects = await Http.GetFromJsonAsync<List<Project>>("/api/Projects");
            Users = await Http.GetFromJsonAsync<List<User>>("/api/Users");
            UserTickets = await Http.GetFromJsonAsync<List<UserTicket>>("/api/UserTickets");

            var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();

            User = Users.Find(user => user.Email == authState.User.Identity.Name);

            foreach (var userTicket in UserTickets)
            {
                if (userTicket.UserId == User.Id)
                {
                    AssignedTickets.Add(Tickets.Find(ticket => ticket.Id == userTicket.TicketId));
                }
            }

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
        catch (Exception)
        {
            throw;
        }
    }

    private string rowColour(Ticket ticket)
    {
        if(ticket.Deadline != null)
        {
            if (ticket.State == "Completed")
            {
                return "table-success"; //green
            }
            else if (DateTime.Now > ticket.Deadline)
            {
                return "table-danger"; //red
            }
            else if (ticket.Deadline?.Subtract(DateTime.Now).TotalDays < 7)
            {
                return "table-warning"; //yellow
            }
        }
        return "";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
