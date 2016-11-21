using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _01_Start_Unsecured.Controllers
{
    [Authorize]
    public class SecretController : ApiController
    {
        // GET: api/Secret
        public IEnumerable<string> Get()
        {
            return new string[] { "Secret", "This is a secret, and should only be accessible if the user has logged in." };
        }

        // GET: api/Secret/5
        public string Get(int id)
        {
            return "This is a secret, and should only be accessible if the user has logged in.";
        }

        // POST: api/Secret
        public string Post([FromBody]string value)
        {
            return "You Posted a secret!";
        }

        // PUT: api/Secret/5
        public string Put(int id, [FromBody]string value)
        {
            return "You Put a secret!";
        }

        // DELETE: api/Secret/5
        public string Delete(int id)
        {
            return "You Deleted a secret!";
        }
    }
}
