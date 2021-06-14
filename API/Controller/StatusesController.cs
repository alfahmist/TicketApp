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
    public class StatusesController : BaseController<Status, StatusRepository, int>
    {
        StatusRepository repository;
        public StatusesController(StatusRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
