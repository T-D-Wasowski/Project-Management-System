#pragma checksum "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd21645f38dd68796f2fc7c510c21bcb5d8e81d0"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementSystem.Client.Pages.ReportBoard
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
#line 3 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reportboard")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Reports Board</h3>\r\n\r\n<hr>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<label for=\"formControlSelect\">Project for Report</label>\r\n    ");
            __builder.OpenElement(4, "select");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "id", "formControlSelect");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                   GeneratePrediction

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "selected");
            __builder.AddAttribute(10, "disabled");
            __builder.AddAttribute(11, "hidden");
            __builder.AddAttribute(12, "label", "-- select an option --");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
         foreach (var project in Projects)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "label", 
#nullable restore
#line 17 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                            project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                           project.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<hr>");
#nullable restore
#line 24 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
 if (Generated == true)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<h4>Project Development Progress Report</h4>\r\n    ");
            __builder.OpenElement(18, "p");
            __builder.AddMarkupContent(19, "\r\n        This project is issued by ");
            __builder.OpenElement(20, "b");
            __builder.AddContent(21, 
#nullable restore
#line 28 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                      Company.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(22, " as one of ");
            __builder.OpenElement(23, "b");
            __builder.AddContent(24, 
#nullable restore
#line 28 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                     TotalCompanyProjects

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " projects");
            __builder.CloseElement();
            __builder.AddContent(26, " issued by this company. This project has ");
            __builder.OpenElement(27, "b");
            __builder.AddContent(28, 
#nullable restore
#line 28 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                                                                    ProjectAssignedUsers

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " assigned users");
            __builder.CloseElement();
            __builder.AddContent(30, " and ");
            __builder.OpenElement(31, "b");
            __builder.AddContent(32, 
#nullable restore
#line 28 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                                                                                                                    ProjectAssignedTickets

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, " assigned tickets");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, ".\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "p");
            __builder.AddMarkupContent(37, "\r\n        That is a difference of ");
            __builder.OpenElement(38, "b");
            __builder.AddContent(39, 
#nullable restore
#line 31 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                    AssignedUserProjectCompanyDifference.ToString("0.####")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(40, " users");
            __builder.CloseElement();
            __builder.AddContent(41, " and ");
            __builder.OpenElement(42, "b");
            __builder.AddContent(43, 
#nullable restore
#line 31 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                              AssignedTicketProjectCompanyDifference.ToString("0.####")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, " tickets");
            __builder.CloseElement();
            __builder.AddContent(45, " compared to the average ");
            __builder.OpenElement(46, "b");
            __builder.AddContent(47, 
#nullable restore
#line 31 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                                                                                                                                AverageCompanyAssignedUsers.ToString("0.####")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(48, " users");
            __builder.CloseElement();
            __builder.AddContent(49, " and ");
            __builder.OpenElement(50, "b");
            __builder.AddContent(51, 
#nullable restore
#line 31 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                                                                                                                                                                                                 AverageCompanyAssignedTickets.ToString("0.####")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(52, " tickets");
            __builder.CloseElement();
            __builder.AddContent(53, " of all the other projects issued by ");
            __builder.OpenElement(54, "b");
            __builder.AddContent(55, 
#nullable restore
#line 31 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                                                                                                                                                                                                                                                                                                      Company.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, ".\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.OpenElement(58, "p");
            __builder.AddMarkupContent(59, "\r\n        Out of the ");
            __builder.OpenElement(60, "b");
            __builder.AddContent(61, 
#nullable restore
#line 34 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                       ProjectAssignedTickets

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(62, " tickets");
            __builder.CloseElement();
            __builder.AddContent(63, " assigned to this project, ");
            __builder.OpenElement(64, "b");
            __builder.AddContent(65, 
#nullable restore
#line 34 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                        ProjectCompletedTickets

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(66, " of them are complete");
            __builder.CloseElement();
            __builder.AddContent(67, ", which means this project is ");
            __builder.OpenElement(68, "b");
            __builder.AddContent(69, 
#nullable restore
#line 34 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                                                                                          ProjectCompletedTicketsPercentage.ToString("0.####")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(70, "% complete");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, ".\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "<h4>Project User Productivity Report</h4>\r\n    ");
            __builder.OpenElement(73, "p");
            __builder.AddMarkupContent(74, "\r\n        This project has ");
            __builder.OpenElement(75, "b");
            __builder.AddContent(76, 
#nullable restore
#line 39 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                             ProjectAssignedUsers

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(77, " users");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, " working on it. These users are:\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.OpenElement(80, "ul");
            __builder.AddAttribute(81, "class", "list-group");
#nullable restore
#line 42 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
         foreach (var user in AssignedUsers)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "li");
            __builder.AddAttribute(83, "class", "list-group-item");
            __builder.OpenElement(84, "ul");
            __builder.AddAttribute(85, "class", "list-group");
            __builder.OpenElement(86, "li");
            __builder.AddAttribute(87, "class", "list-group-item");
            __builder.OpenElement(88, "b");
            __builder.AddContent(89, 
#nullable restore
#line 46 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                    user.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(90, " ");
            __builder.AddContent(91, 
#nullable restore
#line 46 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                    user.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                    ");
            __builder.OpenElement(93, "li");
            __builder.AddAttribute(94, "class", "list-group-item");
            __builder.AddContent(95, "Working on ");
            __builder.OpenElement(96, "b");
            __builder.AddContent(97, 
#nullable restore
#line 47 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                               user.UserTickets.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(98, " tickets");
            __builder.CloseElement();
            __builder.AddContent(99, " across ");
            __builder.OpenElement(100, "b");
            __builder.AddContent(101, 
#nullable restore
#line 47 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
                                                                                                             user.ProjectUsers.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(102, " different projects");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"


}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(103, "p");
            __builder.AddContent(104, 
#nullable restore
#line 58 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
         Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "C:\Users\Sandra Gröniger\Desktop\Dawid 2022\Uni\EAD\Coursework\ProjectManagementSystem\ProjectManagementSystem\Client\Pages\ReportBoard\Index.razor"
       

    private bool Generated { get; set; } = false;
    private string Message { get; set; } = "Please select a project for the report.";

    private double TotalCompanyProjects { get; set; }
    private double TotalCompanyAssignedUsers { get; set; }
    private double TotalCompanyAssignedTickets { get; set; }
    private double AverageCompanyAssignedUsers { get; set; }
    private double AverageCompanyAssignedTickets { get; set; }

    private double ProjectAssignedUsers { get; set; }
    private double AssignedUserProjectCompanyDifference { get; set; }
    private double AssignedUserProjectCompanyPercentage { get; set; }

    private double ProjectAssignedTickets { get; set; }
    private double AssignedTicketProjectCompanyDifference { get; set; }
    private double AssignedTicketProjectCompanyPercentage { get; set; }

    private double ProjectCompletedTickets { get; set; }
    private double ProjectCompletedTicketsPercentage { get; set; }

    private Company Company {get;set;} = new Company();
    private List<Company> Companies { get; set; } = new List<Company>();
    private List<Project> Projects { get; set; } = new List<Project>();
    private List<Ticket> Tickets { get; set; } = new List<Ticket>();
    private List<ProjectUser> ProjectUsers { get; set; } = new List<ProjectUser>();
    private List<User> Users { get; set; } = new List<User>();
    private List<User> AssignedUsers { get; set; } = new List<User>();
    private List<UserTicket> UserTickets { get; set; } = new List<UserTicket>();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            Companies = await Http.GetFromJsonAsync<List<Company>>("/api/Companies");
            Projects = await Http.GetFromJsonAsync<List<Project>>("/api/Projects");
            Tickets = await Http.GetFromJsonAsync<List<Ticket>>("/api/Tickets");
            ProjectUsers = await Http.GetFromJsonAsync<List<ProjectUser>>("/api/ProjectUsers");
            UserTickets = await Http.GetFromJsonAsync<List<UserTicket>>("/api/UserTickets");
            Users = await Http.GetFromJsonAsync<List<User>>("/api/Users");

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

    private void GeneratePrediction(ChangeEventArgs e)
    {
        Generated = true;

        Project project = Projects.Find(project => project.Id.ToString() == e.Value.ToString());
        Company = Companies.Find(company => company.Id == project.CompanyId);

        //Retrieve company projects
        Company.Projects = new List<Project>();
        foreach (var p in Projects)
        {
            if (p.CompanyId == Company.Id)
            {
                Company.Projects.Add(p);
            }
        }

        //Retrieve each company projects projectUsers
        foreach (var companyProject in Company.Projects)
        {
            companyProject.ProjectUsers = new List<ProjectUser>();
            foreach (var projectUser in ProjectUsers)
            {
                if (projectUser.ProjectId == companyProject.Id)
                {
                    companyProject.ProjectUsers.Add(projectUser);
                }
            }

            companyProject.Tickets = new List<Ticket>();
            foreach(var ticket in Tickets)
            {
                if (ticket.ProjectId == companyProject.Id)
                {
                    companyProject.Tickets.Add(ticket);
                }
            }
        }

        //Retrieve project projectUsers
        project.ProjectUsers = new List<ProjectUser>();
        foreach (var projectUser in ProjectUsers)
        {
            if (projectUser.ProjectId == project.Id)
            {
                project.ProjectUsers.Add(projectUser);
            }
        }

        AssignedUsers = new List<User>();
        //Retrieve assigned users
        foreach (var projectUser in project.ProjectUsers)
        {
            AssignedUsers.Add(Users.Find(user => user.Id == projectUser.UserId));
        }

        foreach (var user in AssignedUsers)
        {
            user.UserTickets = new List<UserTicket>();
            user.ProjectUsers = new List<ProjectUser>();

            foreach (var userTicket in UserTickets)
            {
                if (userTicket.UserId == user.Id)
                {
                    user.UserTickets.Add(userTicket);
                }
            }

            foreach (var projectUser in ProjectUsers)
            {
                if (projectUser.UserId == user.Id)
                {
                    user.ProjectUsers.Add(projectUser);
                }
            }
        }

        //Retrieve assigned tickets
        project.Tickets = new List<Ticket>();
        foreach (var ticket in Tickets)
        {
            if (ticket.ProjectId == project.Id)
            {
                project.Tickets.Add(ticket);
            }
        }

        TotalCompanyProjects = Company.Projects.Count;

        TotalCompanyAssignedUsers = 0;
        TotalCompanyAssignedTickets = 0;
        foreach (var companyProject in Company.Projects)
        {
            TotalCompanyAssignedUsers += companyProject.ProjectUsers.Count;
            TotalCompanyAssignedTickets += companyProject.Tickets.Count;
        }

        AverageCompanyAssignedUsers = (TotalCompanyAssignedUsers / TotalCompanyProjects);
        AverageCompanyAssignedTickets = (TotalCompanyAssignedTickets / TotalCompanyProjects);

        ProjectAssignedUsers = project.ProjectUsers.Count;
        AssignedUserProjectCompanyDifference = (ProjectAssignedUsers - AverageCompanyAssignedUsers);
        AssignedUserProjectCompanyPercentage = (ProjectAssignedUsers / TotalCompanyAssignedUsers);

        ProjectAssignedTickets = project.Tickets.Count;
        AssignedTicketProjectCompanyDifference = (ProjectAssignedTickets - AverageCompanyAssignedTickets);
        AssignedTicketProjectCompanyPercentage = (ProjectAssignedTickets / TotalCompanyAssignedTickets);

        List<Ticket> completedTickets = new List<Ticket>();
        foreach (var ticket in project.Tickets)
        {
            if(ticket.EndDate != null)
            {
                completedTickets.Add(ticket);
            }

        }

        ProjectCompletedTickets = completedTickets.Count;
        ProjectCompletedTicketsPercentage = ((ProjectCompletedTickets / ProjectAssignedTickets) * 100);

        //----------------------------------------------------------------------------------------------------

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
