﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Api1Controller : ControllerBase
    {

        [HttpGet]
        [Route("TaxaJuros")]
        public IActionResult TaxaJuros()
        {
            return Ok(0.01M);
        }
    }
}
