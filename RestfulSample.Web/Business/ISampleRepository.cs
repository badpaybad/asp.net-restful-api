using System.Collections.Generic;

namespace RestfulSample.Web.Business
{
    public interface ISampleRepository
    {
        SampleObject Select(int id);
        void Insert(SampleObject obj);
        void Update(SampleObject obj);
        void Delete(int id);
        List<SampleObject> SelectAll();
    }
}