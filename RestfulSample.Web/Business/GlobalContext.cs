using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestfulSample.Web.Business
{
    public static class GlobalContext
    {
        public static IAppSessionManager AppSessionManager;
        public static ISampleRepository SampleRepository;

        static GlobalContext()
        {
            AppSessionManager = new AppSessionManager();
            SampleRepository = new SampleRepository();
        }
    }
}