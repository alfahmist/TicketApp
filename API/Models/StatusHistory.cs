using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_StatusHistory")]
    public class StatusHistory
    {
        public Ticket TicketID { get; set; }
        public Status StatusID { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
