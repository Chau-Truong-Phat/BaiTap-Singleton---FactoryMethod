using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17031361_ChauTruongPhat_Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //A. Eager Initialization
            //EagerInitializedSingleton one = EagerInitializedSingleton.getInstance();
            //Console.WriteLine(one.GetHashCode());

            //EagerInitializedSingleton two = EagerInitializedSingleton.getInstance();
            //Console.WriteLine(two.GetHashCode());

            //B. Static block initialization
            //StaticBlockSingleton one = StaticBlockSingleton.getInstance();
            //Console.WriteLine(one.GetHashCode());

            //StaticBlockSingleton two = StaticBlockSingleton.getInstance();
            //Console.WriteLine(two.GetHashCode());

            //C. Lazy Initialization
            //LazyInitializedSingleton one = LazyInitializedSingleton.getInstance();
            //Console.WriteLine(one.GetHashCode());

            //LazyInitializedSingleton two = LazyInitializedSingleton.getInstance();
            //Console.WriteLine(two.GetHashCode());

            //D. Thread Safe Singleton
            ThreadSafeSingleton one = ThreadSafeSingleton.getInstance();
            Console.WriteLine(one.GetHashCode());

            ThreadSafeSingleton two = ThreadSafeSingleton.getInstance();
            Console.WriteLine(two.GetHashCode());

            Console.ReadKey();

        }
    }
}
