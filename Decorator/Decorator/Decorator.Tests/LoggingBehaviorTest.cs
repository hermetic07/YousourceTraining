namespace Decorator.Tests
{
    using Decorator.Classes;
    using Decorator.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class LoggingBehaviorTest
    {
        private LoggingBehavior target;
        private Mock<IStringBehavior> moqStringBehavior;
        private Mock<ILogger> moqDebugLogger;

        [TestInitialize]
        public void Setup()
        {
            this.moqDebugLogger = new Mock<ILogger>();
            this.moqStringBehavior = new Mock<IStringBehavior>();
            this.target = new LoggingBehavior(this.moqStringBehavior.Object, this.moqDebugLogger.Object);
        }

        [TestCleanup]
        public void Teardown()
        {
            this.moqDebugLogger = null;
            this.moqStringBehavior = null;
            this.target = null;
        }

        [TestMethod]
        public void Reverse_ValidInputString_ReverseString()
        {
            var input = "test";
            var expected = "tset";
            this.moqStringBehavior.Setup(a => a.Reverse(It.IsAny<string>())).Returns("tset");

            var actual = this.target.Reverse(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
