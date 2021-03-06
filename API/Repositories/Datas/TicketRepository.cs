using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Datas
{
    public class TicketRepository : GeneralRepository<Ticket, MyContext, int>
    {
        private readonly MyContext myContext;

        public TicketRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
