using API.Base;
using API.Models;
using API.Repositories.Datas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : BaseController<Ticket, TicketRepository, string>
    {
        TicketRepository repository;
        public TicketsController(TicketRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
