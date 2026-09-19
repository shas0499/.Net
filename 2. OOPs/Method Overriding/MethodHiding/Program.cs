namespace MethodHiding
{
    internal class Program
    {
        class A
        {
            public void Method1()
            {
                Console.WriteLine("Class A -- Method 1");
            }
            public void Method2()
            {
                Console.WriteLine("Class A --- Method 2");
            }

        }
        class B : A
        {
            public new void Method2()
            {
                Console.WriteLine("Class B Override");
            }
        }
        static void Main(string[] args)
        {
            B b = new B();
            b.Method2();
            b.Method1();
        }
    }
}
