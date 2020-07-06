namespace Decorator.Tests
{
    using Decorator.Classes;
    using Decorator.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class DefaultStringBehaviorTest
    {
        private DefaultStringBehavior target;

        [TestInitialize]
        public void Setup()
        {
            this.target = new DefaultStringBehavior();
        }

        [TestCleanup]
        public void Teardown()
        {
            this.target = null;
        }

        [TestMethod]
        public void Reverse_Valid_ReverseAppendedString()
        {
            var input = "test";
            var expected = "tset";

            var actual = this.target.Reverse(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
