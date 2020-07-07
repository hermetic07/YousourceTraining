namespace Decorator.Tests
{
    using Decorator.Classes;
    using Decorator.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class AppendingBehaviorTest
    {
        private AppendingBehavior target;
        private Mock<IStringBehavior> moqStringBehavior;

        [TestInitialize]
        public void Setup()
        {
            this.moqStringBehavior = new Mock<IStringBehavior>();
            this.target = new AppendingBehavior(this.moqStringBehavior.Object);
        }

        [TestCleanup]
        public void Teardown()
        {
            this.moqStringBehavior = null;
            this.target = null;
        }

        [TestMethod]
        public void Reverse_ValidInputString_ReverseAppendedString()
        {
            var input = "test";
            var expected = "tset Evander";
            this.moqStringBehavior.Setup(a => a.Reverse(It.IsAny<string>())).Returns("tset");

            var actual = this.target.Reverse(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
