using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinahProject.Controllers
{
    public class EnquiryController : ApiController
    {
        // GET api/enquiry
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/enquiry/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/enquiry
        public void Post([FromBody]string value)
        {
        }

        // PUT api/enquiry/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/enquiry/5
        public void Delete(int id)
        {
        }
    }
}
