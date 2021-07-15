using NUnit.Framework;
using NUnitTraining;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Program.Main(null);
        }
    }
}