using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RestfulSample.UnitTest
{
    [TestFixture]
    public class TestPerformanceWithQueue:IDisposable
    {
        ConcurrentQueue<object> _queue = new ConcurrentQueue<object>();
        private bool _isStop = false;
        Random _rnd = new Random();
           
        [Test]
        public void Run()
        {
            new Thread(() =>
            {
                while (!_isStop)
                {
                    _queue.Enqueue(DateTime.Now.Ticks.ToString());
                    Thread.Sleep(_rnd.Next(1,200));
                }
            }).Start();
            new Thread(() =>
            {
                while (!_isStop)
                { 
                    var temp= new ConcurrentQueue<object>();
               
                    object o;
                    while(_queue.TryDequeue(out o)) temp.Enqueue(o);

                    object ot;
                    while (temp.TryDequeue(out ot))
                    {
                        var ot1 = ot;
                        Task.Factory.StartNew(()=> Do(ot1));
                    }
                }

                
            }).Start();
            while (true)
            {
                Thread.Sleep(100);
            }
        }

        public void Do(object obj)
        {
            //do something take randon 1->2 sec
            Console.WriteLine(obj as string);
            Thread.Sleep(_rnd.Next(1, 2000));
        }

        public void Dispose()
        {
            _isStop = true;
        }
    }
}
