using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace RestfulSample.Web.Business
{
    public enum ResponseCodeApp
    {
        Default=0,
        SuccessApikey=1,
        SuccessToken=2,
        InvalidApiKey=-1,
        InvalidToken=-2,
        Ok=3,
        Error = -3,
        SuccessUpload = 4,
        FailUpload = -4,
    }

    public class ResponseObject
    {
        public ResponseCodeApp Code { get; set; }
        public object Content { get; set; }

        public string ContentType { get { return Content.GetType().ToString(); } }

        public ResponseObject(ResponseCodeApp code, object content)
        {
            Code = code;
            Content = content;
        }

        public RequestObject Request { get; set; }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
            //return  new JavaScriptSerializer().Serialize(this);
        }

        public StringContent ToStringContent()
        {
            return new StringContent(ToJson());
        }

       
    }
}