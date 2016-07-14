using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestfulSample.Web.Business;

namespace RestfulSample.Web.Controllers
{
    public class SampleController : ApiController
    {
        // GET: api/Sample
        public List<SampleObject> Get()
        {
            return GlobalContext.SampleRepository.SelectAll();
        }

        // GET: api/Sample/5
        public SampleObject Get(int id)
        {
            return GlobalContext.SampleRepository.Select(id);
        }

        // POST: api/Sample
        public void Post([FromBody]SampleObject value)
        {
            GlobalContext.SampleRepository.Insert(value);
        }

        // PUT: api/Sample/5
        public void Put(int id, [FromBody]SampleObject value)
        {
            value.Id = id;
            GlobalContext.SampleRepository.Update(value);
        }

        // DELETE: api/Sample/5
        public void Delete(int id)
        {
            GlobalContext.SampleRepository.Delete(id);
        }
    }
}
