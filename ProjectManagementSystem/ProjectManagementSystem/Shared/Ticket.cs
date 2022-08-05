using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Shared
{
    public class Ticket
    {

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public Nullable<DateTime> Deadline { get; set; }

        public ICollection<UserTicket> UserTickets { get; set; }

        [Required]
        [ForeignKey("Project")]
        public Guid ProjectId { get; set; } 
        public Project Project { get; set; } 

    }
}
