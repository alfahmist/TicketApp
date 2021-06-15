using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Datas
{
    public class MessageRepository : GeneralRepository<Message, MyContext, int>
    {
        private readonly MyContext myContext;

        public MessageRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}