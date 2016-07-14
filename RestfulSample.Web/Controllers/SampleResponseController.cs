using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using RestfulSample.Web.Business;

namespace RestfulSample.Web.Controllers
{
    public class SampleResponseController : ApiController
    {

        [HttpPost]
        public ResponseObject Post([FromBody]RequestObject request)
        //public async Task<ResponseObject> Post([FromBody]RequestObject request)
        {

            return Process(request);
        }


        private ResponseObject Process(RequestObject request)
        {
            try
            {
                HttpContext.Current.Response.Headers["Access-Control-Allow-Origin"] = "*";

                var isValidToken = GlobalContext.AppSessionManager.IsValidSession(request.Token);
                if (!isValidToken)
                {
                    return ResInvalidToken(request);
                }

                switch (request.Action)
                {
                    case "GetById":

                        return ResGetById(request);

                    case "GetAll":

                        return ResGetAll(request);
                    case "UploadFile":
                        return ResUploadFile(request);

                    default:
                        return ResDefault(request);
                }
            }
            catch (Exception ex)
            {
                return ResUnhandleError(request, ex);
            }

        }

        private ResponseObject ResUploadFile(RequestObject request)
        {
            var uploadFile = request.GetData<UploadOjbect>();
            if (uploadFile == null)
            {
                return new ResponseObject(ResponseCodeApp.FailUpload, "No file to upload")
                {
                    // Request = request
                };
            }

            var arr = Convert.FromBase64String(uploadFile.ContentBase64);
            var dir = HttpContext.Current.Server.MapPath("~/upload");
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            var path = Path.Combine(dir, uploadFile.FullName);

            using (var srm = new MemoryStream(arr))
            {
                using (var cf = new FileStream(path, FileMode.Create))
                {
                    srm.CopyTo(cf);
                    cf.Flush();
                }
            }

            return new ResponseObject(ResponseCodeApp.SuccessUpload, "upload success to: ~/upload/" + uploadFile.FullName)
            {
                //  Request = request
            };
        }

        private ResponseObject ResUnhandleError(RequestObject request, Exception ex)
        {
            return new ResponseObject(ResponseCodeApp.Error, ex.Message + " \r\n" + ex.StackTrace)
            {
                // Request = request
            };
        }

        private ResponseObject ResDefault(RequestObject request)
        {
            var defaultMsg = "This is result for sample with session token by api key";
            var responseObject = new ResponseObject(ResponseCodeApp.Ok, defaultMsg);
            responseObject.Request = request;
            return responseObject;
        }

        private ResponseObject ResGetAll(RequestObject request)
        {
            return new ResponseObject(ResponseCodeApp.Ok, GlobalContext.SampleRepository.SelectAll())
            {
                //  Request = request
            };
        }

        private ResponseObject ResGetById(RequestObject request)
        {
            var id = request.GetData<int>();

            var sampleObject = GlobalContext.SampleRepository.Select(id);

            var resGetById = new ResponseObject(ResponseCodeApp.Ok, sampleObject);
            // resGetById.Request = request;

            return resGetById;
        }

        private ResponseObject ResInvalidToken(RequestObject request)
        {
            return new ResponseObject(ResponseCodeApp.InvalidToken, "Invalid token")
            {
                // Request = request
            };
        }

    }
}
