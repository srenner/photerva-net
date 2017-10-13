using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Photerva.Lib.Logic;
using Microsoft.AspNetCore.Identity;
using Photerva.Lib.Models;
using Photerva.Lib.ViewModels;
using System.Globalization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Photerva.Web.API
{
    [Route("api/[controller]")]
    public class SessionController : Controller
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

        public SessionController(IPhotervaService service, UserManager<ApplicationUser> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Session> Get()
        {
            var query = this.Request.Query;
            if(query.Keys.Count > 0)
            {
                //todo handle bad input
                DateRange range = new DateRange();
                if(query.ContainsKey("startDate"))
                {
                    string strStartDate = query["startDate"];
                    range.StartDate = DateTime.ParseExact(strStartDate, "yyyyMMdd", CultureInfo.InvariantCulture);
                }
                if(query.ContainsKey("endDate"))
                {
                    string strEndDate = query["endDate"];
                    range.EndDate = DateTime.ParseExact(strEndDate, "yyyyMMdd", CultureInfo.InvariantCulture);
                }
            }

            throw new NotImplementedException();
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
