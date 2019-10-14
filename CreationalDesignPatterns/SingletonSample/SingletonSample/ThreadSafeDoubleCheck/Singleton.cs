using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.ThreadSafeDoubleCheck
{
    ////Thread-safe (Double-checked Locking) initialization of singleton
    public class Singleton
    {
        private static volatile Singleton instance = null;
        private static object lockThis = new object();

        private Singleton() { }

        public static Singleton GetInstance
        {
            get 
            {
                if (instance == null)
                {
                    lock (lockThis)
                    {
                        if (instance == null)
                            instance = new Singleton();

                    }
                }
                return instance;
            }
        }

        // other useful methods here 
    }
}
