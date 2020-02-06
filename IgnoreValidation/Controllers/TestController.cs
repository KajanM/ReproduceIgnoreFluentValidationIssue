using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using IgnoreValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IgnoreValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public IActionResult Test([CustomizeValidator(Skip = true)] Person person)
        {
            /*
            REQUEST BODY
            {
                "Name": "Sam",
                "Skills": [
                {
                    "Name": "s1",
                    "SupportingDocuments": []
                }
                ]
            }
            
            RESPONSE
            {
                "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
                "title": "One or more validation errors occurred.",
                "status": 400,
                "traceId": "|c613f5e7-4a8f59e73ef8c0cd.",
                "errors": {
                    "Skills[0].SupportingDocuments": [
                    "'Supporting Documents' must not be empty."
                        ]
                }
            }
            */

            return Ok("Hello");
        }
    }
}