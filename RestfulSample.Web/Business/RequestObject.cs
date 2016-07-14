using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace RestfulSample.Web.Business
{
    public class RequestObject
    {
        public string Token { get; set; }
        public string Action { get; set; }
        public string DataInStringJson { get; set; }
        public string DataType { get; set; }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
            //return new JavaScriptSerializer().Serialize(this);
        }

        public  T GetData<T>()
        {
            //return new JavaScriptSerializer().Deserialize<T>(DataInStringJson);
            return JsonConvert.DeserializeObject<T>(DataInStringJson);
        } 


    }
}