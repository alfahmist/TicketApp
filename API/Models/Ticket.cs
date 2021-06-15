using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Ticket")]
    public class Ticket
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<StatusHistory> StatusHistories { get; set; }
        public Category Category { get; set; }
    }
}