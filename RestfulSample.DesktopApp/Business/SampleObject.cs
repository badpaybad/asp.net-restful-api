using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace RestfulSample.DesktopApp.Business
{
    public class SampleObject
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public string ToJson()
        {
            return new JavaScriptSerializer().Serialize(this);
        }
    }
}