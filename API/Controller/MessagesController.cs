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
    public class MessagesController : BaseController<Message, MessageRepository, int>
    {
        MessageRepository repository;
        public MessagesController(MessageRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
