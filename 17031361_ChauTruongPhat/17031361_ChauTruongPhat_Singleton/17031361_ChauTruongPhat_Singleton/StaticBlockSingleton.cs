using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_Singleton
{
    public class StaticBlockSingleton
    {
        private static StaticBlockSingleton instance;

        private StaticBlockSingleton()
        {
       
        }

        static StaticBlockSingleton()
        {
            try
            {
                instance = new StaticBlockSingleton();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static StaticBlockSingleton getInstance()
        {
            return instance;
        }
    }
}
