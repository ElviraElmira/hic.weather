﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace hic.weather.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        // GET api/v1/weather
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Väder", "Mycket varmt!" };
        }

        // GET api/v1/weather/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/v1/weather
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/v1/weather/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/v1/weather/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
