using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Models.Customer> Get()
        {
            return new Models.Customer[] {
                new Models.Customer {
                    Name = "Daniel O",
                    CountryCode = "US"
                },
                new Models.Customer {
                    Name = "Test User",
                    CountryCode = "UK"
                },
                new Models.Customer {
                    Name = "Someone Else",
                    CountryCode = "FR"
                }
            };
        }

        [HttpGet("{id}")]
        public Models.Customer Get(int id)
        {
            return new Models.Customer
            {
                Name = "Someone Else",
                CountryCode = "FR"
            };
        }
    }
}