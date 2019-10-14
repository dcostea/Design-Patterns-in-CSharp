using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample.NotThreadSafe
{
    public sealed class Rex
    {
        private static Rex instance = null;

        public static int Counter { get; private set; }

        private Rex()
        {
            Counter = 0;
        }

        public static Rex Itself
        {
            get
            {
                if (instance == null)
                {
                    instance = new Rex();
                    Counter++;
                }

                return instance;
            }
        }
    }
}
