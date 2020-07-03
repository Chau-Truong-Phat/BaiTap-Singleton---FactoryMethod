using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_Singleton
{
    public class LazyInitializedSingleton
    {
        private static LazyInitializedSingleton instance;
        private LazyInitializedSingleton()
        {

        }

        public static LazyInitializedSingleton getInstance()
        {
            if(instance == null)
            {
                instance = new LazyInitializedSingleton();
            }
            return instance;
        }
    }
}
