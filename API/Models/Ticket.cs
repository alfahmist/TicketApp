﻿using System;
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
        public int Status { get; set; }
        public int Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public Ticket()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}