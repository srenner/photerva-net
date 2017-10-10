using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Photerva.Lib.Logic;
using Photerva.Lib.Models;
using Microsoft.AspNetCore.Authorization;
using Photerva.Lib.ViewModels;
using Photerva.Lib.Extensions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Photerva.Web.API
{
    [Authorize]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IPhotervaService _service;

        public CustomerController(IPhotervaService service)
        {
            _service = service;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<CustomerViewModel> Get()
        {

            return _service.GetCustomers("d975f4d2-7898-454d-8ecd-9f6d65554b69").ToViewModel();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
