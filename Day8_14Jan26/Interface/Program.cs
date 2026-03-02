namespace Interface
{
    interface Inter1
    {
        void f1();
    }
    interface Inter2
    {
        void f2(); 
    }
    class C3:Inter1,Inter2
    {
        void Inter1.f1()
        {
            Console.WriteLine("This is overiding function of inter 1 interface");
        }
        void Inter2.f2()
        {
            Console.WriteLine("This is overiding function of inter 2 interface");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            C3 obj1=new C3();
            Inter1 obj2=(Inter1)obj1;
            Inter2 obj3=(Inter2)obj1;
            obj2.f1();
            obj3.f2();
        }
    }
}
