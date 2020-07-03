using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_Singleton
{
    public class ThreadSafeSingleton
    {
        private static volatile ThreadSafeSingleton instance;
        private static object syncRoot = new object();

        private ThreadSafeSingleton()
        {

        }

        public int MyProperty { get; set; }
        private static ThreadSafeSingleton Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new ThreadSafeSingleton();
                    }
                }
                return instance;
            }
        }

        public static ThreadSafeSingleton getInstance()
        {
            return Instance;
        }
    }
}
