using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiDemo.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/priyaaction/{id}")]
        public IHttpActionResult Get([FromUri]int id)
        {
            if(id > 5)
            {
				return Ok(1);
			}
            else
            {
				return NotFound();
			}
            
        }
    }
}
