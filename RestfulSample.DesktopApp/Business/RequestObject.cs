using System.Web.Script.Serialization;

namespace RestfulSample.DesktopApp.Business
{
    public class RequestObject
    {
        public string Token { get; set; }
        public string Action { get; set; }
        public string DataInStringJson { get; set; }
        public string DataType { get; set; }
        public string ToJson()
        {
            return new JavaScriptSerializer().Serialize(this);
        }
        public RequestObject() { }
        public RequestObject(object data)
        {
            DataInStringJson = new JavaScriptSerializer().Serialize(data);
            DataType = data.GetType().ToString();
        }
    }
}