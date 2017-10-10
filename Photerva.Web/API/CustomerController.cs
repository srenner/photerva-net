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
using Microsoft.AspNetCore.Identity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Photerva.Web.API
{
    [Authorize]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        public string UserID
        {
            get
            {
                return _userManager.GetUserId(User);
            }
        }

        private readonly IPhotervaService _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public CustomerController(IPhotervaService service, UserManager<ApplicationUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<CustomerViewModel> Get()
        {
            return _service.GetCustomers(UserID).ToViewModel();
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
