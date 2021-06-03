using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class Show
    {
        public int ShowId { get; set; }
        Movie Movie { get; set; }
        public int MovieId { get; set; }
        public int RoomNum { get; set; }
        public bool wheelChair { get; set; }
        public List<Ticket> Tickets { get; set; }
        public DateTime StartTime { get; set; }

    }
}
