    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_T_TicketMessage")]
    public class TicketMessage
    {
        public int ID { get; set; }
        public Ticket Ticket { get; set; }
        public Message Messages { get; set; }
        public DateTime CreatedDate { get; set; }
        public TicketMessage()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
