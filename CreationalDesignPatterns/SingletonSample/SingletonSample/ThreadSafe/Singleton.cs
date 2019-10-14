using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.ThreadSafe
{
    ////Thread-safe (Double-checked Locking) initialization of singleton
    public class Singleton
    {
        private static Singleton instance = null;
        private static object lockThis = new object();

        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                lock (lockThis)
                {
                    if (instance == null)
                        instance = new Singleton();

                    return instance;
                }
            }
        }

        // other useful methods here 
    }
}
