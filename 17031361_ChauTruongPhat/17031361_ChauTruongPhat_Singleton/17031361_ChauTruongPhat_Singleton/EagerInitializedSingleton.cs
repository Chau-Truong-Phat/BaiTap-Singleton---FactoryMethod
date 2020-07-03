using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_Singleton
{
    public class EagerInitializedSingleton
    {
        private static EagerInitializedSingleton instance = new EagerInitializedSingleton();
        private EagerInitializedSingleton()
        {
                
        }
        public static EagerInitializedSingleton getInstance()
        {
            return instance;
        }
    }
}
