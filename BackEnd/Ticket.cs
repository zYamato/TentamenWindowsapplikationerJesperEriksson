using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Ticket
    {
        public int TicketId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int MovieId { get; set; }
        [Required]
        public int ShowId { get; set; }
        public DateTime StartTime { get; set; }
        [Required]
        public int SeatNum { get; set; }
        public bool WheelChair { get; set; }
    }
}
