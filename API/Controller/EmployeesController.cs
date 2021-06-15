﻿using API.Base;
using API.Models;
using API.Repositories.Data;
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
    public class EmployeesController : BaseController<Employee, EmployeeRepository, int>
    {
        EmployeeRepository repository;
        public EmployeesController(EmployeeRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}