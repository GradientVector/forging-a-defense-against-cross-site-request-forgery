using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace _01_Start_Unsecured.Controllers
{
    public class CsrfProtectionFilter: ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string cookieToken = string.Empty;
            string formToken = string.Empty;
            IEnumerable <string> tokenHeaders;

            if (actionContext.Request.Headers.TryGetValues("CsrfToken", out tokenHeaders))
            {
                string[] tokens = tokenHeaders.FirstOrDefault()?.Split(':') ?? new string[]{};
                if (tokens.Length == 2)
                {
                    cookieToken = tokens[0];
                    formToken = tokens[1];
                }
            }
            
            try
            {
                // Throws an exception if tokens do not match
                AntiForgery.Validate(cookieToken, formToken);
            }
            catch (Exception ex)
            {
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Forbidden)
                {
                    ReasonPhrase = "Expected valid CSRF tokens",
                };
            }

            base.OnActionExecuting(actionContext);
        }
    }
}