using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Datas
{
    public class StatusHistoryRepository : GeneralRepository<StatusHistory, MyContext, int>
    {
        private readonly MyContext myContext;

        public StatusHistoryRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
