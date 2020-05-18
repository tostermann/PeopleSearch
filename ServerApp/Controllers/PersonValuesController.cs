﻿using Microsoft.AspNetCore.Mvc;
using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonValuesController
    {
        private DataContext context;

        public PersonValuesController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet("{id}")]
        public Person GetPerson(long id)
        {
            System.Threading.Thread.Sleep(5000);
            return context.People.Find(id);
        }

        [HttpGet]
        public IEnumerable<Person> GetProducts()
        {
            IQueryable<Person> query = context.People;
            return query;
        }
    }
}
