using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.NotThreadSafe
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        // other useful methods here
    }
}
