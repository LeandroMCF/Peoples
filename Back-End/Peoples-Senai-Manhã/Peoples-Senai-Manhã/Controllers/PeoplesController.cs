﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peoples_Senai_Manhã.Domains;
using Peoples_Senai_Manhã.Interfaces;
using Peoples_Senai_Manhã.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Peoples_Senai_Manhã.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PeoplesController : ControllerBase
    {
        private IPeoples _peoples { get; set; }

        public PeoplesController()
        {
            _peoples = new PeopleRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<PeoplesDomain> listaPeople = _peoples.ListarUsers();

            return Ok(listaPeople);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PeoplesDomain peoplesDomain = _peoples.ListarUserId(id);

            if (peoplesDomain == null)
            {
                return NotFound("Nenhum resultado foi encontrado");
            }

            return Ok(peoplesDomain);
        }

        [HttpPost]
        public IActionResult Post(PeoplesDomain people)
        {
            _peoples.Cadastrar(people);

            return StatusCode(201);
        }

        [HttpPut("{Id}")]
        public IActionResult Put(PeoplesDomain people, int Id)
        {
            _peoples.AtualizarIdUrl(Id, people);

            return Ok("Dados atualizados");
        }
    }
}
