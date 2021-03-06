using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Datas
{
    public class StatusRepository : GeneralRepository<Status, MyContext, int>
    {
        private readonly MyContext myContext;

        public StatusRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
