using System.Web.Script.Serialization;

namespace RestfulSample.DesktopApp.Business
{

    public enum ResponseCodeApp
    {
        Default = 0,
        SuccessApikey = 1,
        SuccessToken = 2,
        InvalidApiKey = -1,
        InvalidToken = -2,
    }

    public class ResponseResult
    {
        public ResponseCodeApp Code { get; set; }
        public object Content { get; set; }

        public string ContentType { get { return Content.GetType().ToString(); } }

        public RequestObject Request { get; set; }

        public string ToJson()
        {
            return new JavaScriptSerializer().Serialize(this);
        }

        public static ResponseResult FromJson(string json)
        {
            var x = new JavaScriptSerializer().Deserialize<ResponseResult>(json);
            if (x == null) return new ResponseResult();

            return x;
        }
    }
}