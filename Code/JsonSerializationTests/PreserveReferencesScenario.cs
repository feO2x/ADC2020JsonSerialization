namespace JsonSerializationTests
{
    public static class PreserveReferencesScenario
    {
        public static readonly A ObjectGraphRoot;

        static PreserveReferencesScenario()
        {
            var c = new C();
            var b = new B(c);
            ObjectGraphRoot = new A(b, c);
        }
    }

    public sealed class A
    {
        public A(B b, C c)
        {
            B = b;
            C = c;
        }

        public B B { get; }

        public C C { get; }
    }

    public sealed class B
    {
        public B(C c)
        {
            C = c;
        }

        public C C { get; }
    }

    public sealed class C { }
}