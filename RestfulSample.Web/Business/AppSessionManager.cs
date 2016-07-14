using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace RestfulSample.Web.Business
{
    public class AppSessionManager : IAppSessionManager, IDisposable
    {
        ConcurrentDictionary<string, string> _app = new ConcurrentDictionary<string, string>();
        ConcurrentDictionary<string, string> _sessionLookup = new ConcurrentDictionary<string, string>();

        ConcurrentDictionary<string, DateTime> _session = new ConcurrentDictionary<string, DateTime>();
        private int _timeOut = 30 * 60 * 1000;
        private bool _stop = false;
        public AppSessionManager()
        {
            RegisterApiKey();

            RemoveExpiredToken();
        }

        private void RemoveExpiredToken()
        {
            new Thread(() =>
            {
                while (!_stop)
                {
                    var temp = _session.ToList();
                    var needRem = new List<string>();

                    foreach (var t in temp)
                    {
                        var dateNow = DateTime.Now;
                        if (dateNow.Subtract(t.Value).TotalSeconds > _timeOut)
                        {
                            needRem.Add(t.Key);
                        }
                    }

                    if (needRem.Count > 0)
                    {
                        foreach (var t in needRem)
                        {
                            RemoveSession(t);
                        }
                    }

                    Thread.Sleep(1000);
                }

            }).Start();
        }

        private void RegisterApiKey()
        {
            // can call to db to init 
            _app.TryAdd("4488B32B730142409E73E742F16494B3".ToLower(), "");
        }

        public bool GetToken(string apikey, out string token)
        {
            token = string.Empty;
            if (string.IsNullOrEmpty(apikey)) return false;
            apikey = apikey.ToLower();

            var isApiKeyRegistered = _app.TryGetValue(apikey, out token);

            if (!isApiKeyRegistered) return false;

            if (string.IsNullOrEmpty(token))
            {
                var newToken = Guid.NewGuid().ToString().Replace("-", string.Empty).ToLower();
                token = newToken;
                _app.TryUpdate(apikey, newToken, string.Empty);
                _session.TryAdd(newToken, DateTime.Now);
                _sessionLookup.TryAdd(newToken, apikey);
            }
            else
            {
                if (!_session.TryUpdate(token, DateTime.Now, DateTime.MinValue))
                {
                    _session.TryAdd(token, DateTime.Now);
                }
            }
            return true;
        }

        public bool IsValidSession(string token)
        {
            DateTime val;
            if (!_session.TryGetValue(token, out val) || string.IsNullOrEmpty(token))
            {
                return false;
            }
           ////todo: consider bellow, it may not correct for this function
           // token = token.ToLower();
           // _session.TryUpdate(token, DateTime.Now, DateTime.MinValue);
           
            return _session.ContainsKey(token);
            
        }

        public void KeepSession(string token)
        {
            DateTime val;
            if (_session.TryGetValue(token, out val))
            {
                _session.TryUpdate(token, DateTime.Now, DateTime.MinValue);
            }
        }
        public void RemoveSession(string token)
        {
            DateTime val;

            _session.TryRemove(token, out val);

            string apikey;
            _sessionLookup.TryRemove(token, out apikey);
            _app.TryUpdate(apikey, string.Empty, token);

        }
        public void Dispose()
        {
            _stop = true;
        }
    }
    
}