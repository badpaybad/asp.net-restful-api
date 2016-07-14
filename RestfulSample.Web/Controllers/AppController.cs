using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Microsoft.SqlServer.Server;
using RestfulSample.Web.Business;

namespace RestfulSample.Web.Controllers
{
    public class AppController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage Get()
        {
            HttpContext.Current.Response.Headers["Access-Control-Allow-Origin"] = "*";
             
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("version 1.0001 (c) badpaybad.info")
            };
        }

        [HttpGet]
        [Route("~/api/app/GetToken/{id}")]
        public HttpResponseMessage GetToken(string id)
        {
            HttpContext.Current.Response.Headers["Access-Control-Allow-Origin"] = "*";
             
            //passing api key return api token
            string token;
            var isOk = GlobalContext.AppSessionManager.GetToken(id, out token);

            if (isOk)
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ResponseObject(ResponseCodeApp.SuccessApikey, token).ToStringContent()
                };
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ResponseObject(ResponseCodeApp.InvalidApiKey, "Invalid api key").ToStringContent()
                };
            }
        }

        [HttpGet]
        [Route("~/api/app/IsValidSession/{id}")]
        public HttpResponseMessage IsValidSession(string id)
        {
            HttpContext.Current.Response.Headers["Access-Control-Allow-Origin"] = "*";
             
            //passing api key return api token

            string token;
            var isOk = GlobalContext.AppSessionManager.IsValidSession(id);

            if (isOk)
            {
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ResponseObject(ResponseCodeApp.SuccessToken, true).ToStringContent()
                };
            }
            
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ResponseObject(ResponseCodeApp.InvalidToken, false).ToStringContent()
            };
        }

      
    }
}
