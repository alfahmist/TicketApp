using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Message")]
    public class Message
    {
        public int ID { get; set; }
        public Ticket Ticket { get; set; }
        public Employee Employee { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
    }
}
