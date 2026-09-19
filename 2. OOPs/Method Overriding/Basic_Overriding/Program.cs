using System.Runtime.InteropServices;

namespace Basic_Overriding
{
    internal class Program
    {
        class A
        {
            public void Method1()
            {
                Console.WriteLine("Class A --- Method 1");
            }
            public virtual void Method2()
            {
                Console.WriteLine("Class A ----- Method 2");
            }
        }
        class B : A
        {
            public override void Method2()
            {
                Console.WriteLine("Override Class B");
            }
            static void Main(string[] args)
            {
                B b = new B();
                b.Method1();
                b.Method2();
            }
        }
        
    }
}
