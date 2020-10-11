namespace JsonSerializationTests
{
    public static class PolymorphismScenario
    {
        public static readonly Subclass1 Instance1 = new Subclass1 { BaseValue = "Foo", SubValue1 = 42 };

        public static readonly Subclass2 Instance2 = new Subclass2 { BaseValue = "Bar", SubValue1 = 815, SubValue2 = true } ;
    }

    public abstract class BaseClass
    {
        public string? BaseValue { get; set; }
    }

    public class Subclass1 : BaseClass
    {
        public int SubValue1 { get; set; }
    }

    public class Subclass2 : Subclass1
    {
        public bool SubValue2 { get; set; }
    }
}