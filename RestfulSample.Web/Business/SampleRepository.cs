using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulSample.Web.Business
{
    public class SampleRepository : ISampleRepository, IDisposable
    {
        private List<SampleObject> _data = new List<SampleObject>();

        public SampleRepository()
        {
            //sample data
            _data.Add(new SampleObject()
            {
                Id = 1,
                Value = "version 1"
            });
        }

        public SampleObject Select(int id)
        {
            return _data.FirstOrDefault(i => i.Id == id);
        }

        public void Insert(SampleObject obj)
        {
            if (obj.Id == 0)
            {
                if (_data.Count == 0)
                {
                    obj.Id = 1;
                }
                else
                {
                    obj.Id = _data.Max(i => i.Id) + 1;
                }
            }
            var existed = _data.FirstOrDefault(i => i.Id == obj.Id) != null;
            if (existed)
            {
                obj.Id = _data.Max(i => i.Id) + 1;
            }

            _data.Add(obj);
        }

        public void Update(SampleObject obj)
        {
            var data = Select(obj.Id);
            data.Value = obj.Value;

        }

        public void Delete(int id)
        {
            _data.RemoveAll(i => i.Id == id);
        }

        public List<SampleObject> SelectAll()
        {
            return _data;
        }

        public void Dispose()
        {

        }
    }
}