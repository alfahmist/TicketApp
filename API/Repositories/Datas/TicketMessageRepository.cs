using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Datas
{
    public class TicketMessageRepository : GeneralRepository<TicketMessage, MyContext, int>
    {
        private readonly MyContext myContext;

        public TicketMessageRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
