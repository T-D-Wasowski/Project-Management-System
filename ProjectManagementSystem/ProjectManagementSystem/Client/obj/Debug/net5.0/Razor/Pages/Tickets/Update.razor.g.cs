#pragma checksum "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a121275b8a84eb97893fed9b289fc3b9f928a083"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementSystem.Client.Pages.Tickets
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
#line 3 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets/update/{Id:guid}")]
    public partial class Update : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit a Ticket</h3>\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                 Ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                         HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddMarkupContent(8, "<label class=\"control-label\">Ticket Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                Ticket.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Name = __value, Ticket.Name))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Ticket.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateValidationMessage_0(__builder2, 15, 16, 
#nullable restore
#line 17 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                  () => Ticket.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddMarkupContent(19, "<label class=\"control-label\">Ticket Description</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(20);
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                    Ticket.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Description = __value, Ticket.Description))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Ticket.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 25 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                  () => Ticket.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(29, "<label class=\"control-label\">Related Project</label>\r\n    ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateInputSelect_2(__builder2, 30, 31, "form-control", 32, 
#nullable restore
#line 31 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                              Ticket.State

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.State = __value, Ticket.State)), 34, () => Ticket.State, 35, (__builder3) => {
                    __builder3.AddMarkupContent(36, "<option>Opened</option>\r\n        ");
                    __builder3.AddMarkupContent(37, "<option>In Progress</option>\r\n        ");
                    __builder3.AddMarkupContent(38, "<option>Delayed</option>\r\n        ");
                    __builder3.AddMarkupContent(39, "<option>Completed</option>");
                }
                );
                __builder2.AddMarkupContent(40, "\r\n    ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateValidationMessage_3(__builder2, 41, 42, 
#nullable restore
#line 37 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                              () => Ticket.State

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(43, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.OpenElement(44, "div");
                __builder2.AddMarkupContent(45, "<label class=\"control-label\">Ticket Completion Date</label>\r\n        ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateInputDate_4(__builder2, 46, 47, "form-control", 48, 
#nullable restore
#line 43 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                Ticket.EndDate

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.EndDate = __value, Ticket.EndDate)), 50, () => Ticket.EndDate);
                __builder2.AddMarkupContent(51, "\r\n        ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateValidationMessage_5(__builder2, 52, 53, 
#nullable restore
#line 44 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                  () => Ticket.EndDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddMarkupContent(56, "<label class=\"control-label\">Ticket Deadline</label>\r\n        ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateInputDate_6(__builder2, 57, 58, "form-control", 59, 
#nullable restore
#line 51 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                Ticket.Deadline

#line default
#line hidden
#nullable disable
                , 60, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.Deadline = __value, Ticket.Deadline)), 61, () => Ticket.Deadline);
                __builder2.AddMarkupContent(62, "\r\n        ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateValidationMessage_7(__builder2, 63, 64, 
#nullable restore
#line 52 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                  () => Ticket.Deadline

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(66, "<label class=\"control-label\">Related Project</label>\r\n    ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateInputSelect_8(__builder2, 67, 68, "form-control", 69, 
#nullable restore
#line 58 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                              Ticket.ProjectId

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Ticket.ProjectId = __value, Ticket.ProjectId)), 71, () => Ticket.ProjectId, 72, (__builder3) => {
#nullable restore
#line 59 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
         foreach (var project in Projects)
        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(73, "option");
                    __builder3.AddAttribute(74, "label", 
#nullable restore
#line 61 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                            project.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(75, 
#nullable restore
#line 61 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                           project.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 62 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(76, "\r\n    ");
                __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update.TypeInference.CreateValidationMessage_9(__builder2, 77, 78, 
#nullable restore
#line 64 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                              () => Ticket.ProjectId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(79, "\r\n\r\n    ");
                __builder2.OpenElement(80, "p");
                __builder2.AddContent(81, 
#nullable restore
#line 67 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
         Ticket.ProjectId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddMarkupContent(84, "<label class=\"control-label\">Assigned Users</label>");
#nullable restore
#line 72 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
         foreach (var user in Users)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "form-check");
#nullable restore
#line 75 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                 if (AssignedUsers.Contains(user))
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "class", "form-check-input");
                __builder2.AddAttribute(89, "type", "checkbox");
                __builder2.AddAttribute(90, "id", "flexCheckDefault");
                __builder2.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                                                                                    (()=>handleCheckboxClick(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "checked");
                __builder2.CloseElement();
#nullable restore
#line 78 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "class", "form-check-input");
                __builder2.AddAttribute(95, "type", "checkbox");
                __builder2.AddAttribute(96, "id", "flexCheckDefault");
                __builder2.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                                                                                    (()=>handleCheckboxClick(user))

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
#nullable restore
#line 82 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(98, "label");
                __builder2.AddAttribute(99, "class", "form-check-label");
                __builder2.AddAttribute(100, "for", "flexCheckDefault");
                __builder2.AddContent(101, 
#nullable restore
#line 83 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                                                        user.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(102, " ");
                __builder2.AddContent(103, 
#nullable restore
#line 83 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                                                                        user.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 85 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n\r\n    <br>\r\n\r\n    ");
                __builder2.OpenElement(105, "button");
                __builder2.AddAttribute(106, "class", "btn btn-secondary");
                __builder2.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
                                                Return

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(108, "\r\n        Return\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n    ");
                __builder2.AddMarkupContent(110, "<button type=\"submit\" class=\"btn btn-primary\"><i class=\"fas fa-save\"></i> Update\r\n    </button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\Tickets\Update.razor"
       

        [Parameter] public Guid Id { get; set; }
        private Ticket Ticket { get; set; } = new Ticket();
        private List<Project> Projects { get; set; } = new List<Project>();
        private List<User> Users { get; set; } = new List<User>();
        private List<User> AssignedUsers { get; set; } = new List<User>();
        private List<UserTicket> UserTickets { get; set; } = new List<UserTicket>();

        protected override async Task OnInitializedAsync()
        {
            try
            {
                Ticket = await Http.GetFromJsonAsync<Ticket>($"/api/Tickets/{Id}");
                Projects = await Http.GetFromJsonAsync<List<Project>>("/api/Projects");
                Users = await Http.GetFromJsonAsync<List<User>>("/api/Users");
                UserTickets = await Http.GetFromJsonAsync<List<UserTicket>>("/api/UserTickets");

                Ticket.UserTickets = new List<UserTicket>();

                //Retrieve linked UserTickets
                foreach (var userTicket in UserTickets)
                {
                    if (userTicket.TicketId == Ticket.Id)
                    {
                        Ticket.UserTickets.Add(userTicket);
                    }
                }

                //Retrieve linked Users
                foreach (var userTicket in Ticket.UserTickets)
                {
                    AssignedUsers.Add(Users.Find(user => user.Id == userTicket.UserId));
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

        private async void HandleValidSubmit()
        {
            try
            {
                var response = await Http.PutAsJsonAsync($"/api/Tickets/{Ticket.Id}", Ticket);
                response.EnsureSuccessStatusCode();

                //remove old assignments
                foreach (var userTicket in Ticket.UserTickets)
                {
                    if (AssignedUsers.Contains(Users.Find(user => user.Id == userTicket.UserId)))
                    {
                        continue;
                    }
                    else
                    {
                        var responseUserTicketDelete = await Http.DeleteAsync($"/api/UserTickets/{userTicket.Id}");
                        responseUserTicketDelete.EnsureSuccessStatusCode();
                    }
                }

                //add new assignments
                foreach (var user in AssignedUsers)
                { 
                    if (Ticket.UserTickets.Contains(UserTickets.Find(userTicket => userTicket.UserId == user.Id & userTicket.TicketId == Ticket.Id)))
                    {
                        continue;
                    }
                    else
                    {
                        var responseUserTicketAdd = await Http.PostAsJsonAsync("/api/UserTickets", new UserTicket() { TicketId = Ticket.Id, UserId = user.Id });
                        responseUserTicketAdd.EnsureSuccessStatusCode();
                    }

                }

            Navigation.NavigateTo($"tickets/read/{Ticket.Id}");
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

    private void handleCheckboxClick(User user)
    {
        if (AssignedUsers.Contains(user))
        {
            AssignedUsers.Remove(user);
        }
        else
        {
            AssignedUsers.Add(user);
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
namespace __Blazor.ProjectManagementSystem.Client.Pages.Tickets.Update
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591