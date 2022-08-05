// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectManagementSystem.Client.Pages.TicketBoard.Tickets
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
#line 3 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\TicketBoard\Tickets\Delete.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets/delete/{Id:guid}")]
    public partial class Delete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\TicketBoard\Tickets\Delete.razor"
       
    [Parameter] public Guid Id { get; set; }
    private Ticket Ticket { get; set; } = new Ticket();
    private Project Project { get; set; } = new Project();
    private List<UserTicket> UserTickets { get; set; } = new List<UserTicket>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Ticket = await Http.GetFromJsonAsync<Ticket>($"/api/Tickets/{Id}");
            Project = await Http.GetFromJsonAsync<Project>($"/api/Projects/{Ticket.ProjectId}");
            UserTickets = await Http.GetFromJsonAsync<List<UserTicket>>("api/UserTickets");

            Ticket.UserTickets = new List<UserTicket>();

            //Retrieve all userticket links related to this ticket
            foreach (var userTicket in UserTickets)
            {
                if (userTicket.TicketId == Ticket.Id)
                {
                    Ticket.UserTickets.Add(userTicket);
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

    private async void DeleteProject()
    {

        try
        {

            //delete usertickets related to ticket
            foreach (var userTicket in Ticket.UserTickets)
            {
                var responseUserTicket = await Http.DeleteAsync($"/api/UserTickets/{userTicket.Id}");
                responseUserTicket.EnsureSuccessStatusCode();
            }

            //delete ticket
            var responseTicket = await Http.DeleteAsync($"/api/Tickets/{Id}");
            responseTicket.EnsureSuccessStatusCode();

            Navigation.NavigateTo("/tickets");
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

    private void Return()
    {
        Navigation.NavigateTo("/tickets");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
