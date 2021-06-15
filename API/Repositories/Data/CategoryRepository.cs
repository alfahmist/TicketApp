﻿using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Datas
{
    public class CategoryRepository : GeneralRepository<Category, MyContext, int>
    {
        private readonly MyContext myContext;

        public CategoryRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}