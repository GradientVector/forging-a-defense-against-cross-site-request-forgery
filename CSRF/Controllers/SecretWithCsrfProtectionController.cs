using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _01_Start_Unsecured.Controllers
{
    [Authorize]
    [EnableCors(origins: "*", headers: "*", methods: "*", SupportsCredentials = true)]
    [System.Web.Mvc.ValidateAntiForgeryToken]
    [CsrfProtectionFilter]
    public class SecretWithCsrfProtectionController : ApiController
    {
        // GET: api/SecretWithCqrsProtection
        public IEnumerable<string> Get()
        {
            return new string[] { "Secret", "This is a secret, and should only be accessible if the user has logged in." };
        }

        // GET: api/SecretWithCqrsProtection/5
        public string Get(int id)
        {
            return "This is a secret, and should only be accessible if the user has logged in.";
        }

        // POST: api/SecretWithCqrsProtection
        public string Post([FromBody]string value)
        {
            return "You Posted a secret!";
        }

        // PUT: api/SecretWithCqrsProtection/5
        public string Put(int id, [FromBody]string value)
        {
            return "You Put a secret!";
        }

        // DELETE: api/SecretWithCqrsProtection/5
        public string Delete(int id)
        {
            return "You Deleted a secret!";
        }
    }
}