using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _01_Start_Unsecured.Controllers
{
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    public class SecretWithCorsController : ApiController
    {
        // GET: api/SecretWithCors
        public IEnumerable<string> Get()
        {
            return new string[] { "Secret", "This is a secret, and should only be accessible if the user has logged in." };
        }

        // GET: api/SecretWithCors/5
        public string Get(int id)
        {
            return "This is a secret, and should only be accessible if the user has logged in.";
        }

        // POST: api/SecretWithCors
        public string Post([FromBody]string value)
        {
            return "You Posted a secret!";
        }

        // PUT: api/SecretWithCors/5
        public string Put(int id, [FromBody]string value)
        {
            return "You Put a secret!";
        }

        // DELETE: api/SecretWithCors/5
        public string Delete(int id)
        {
            return "You Deleted a secret!";
        }
    }
}
