namespace Decorator.Tests
{
    using Decorator.Classes;
    using Decorator.Interfaces;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class DebugLoggerTest
    {
        private Mock<ILogger> target;

        [TestInitialize]
        public void Setup()
        {
            this.target = new Mock<ILogger>();
        }

        [TestCleanup]
        public void Teardown()
        {
            this.target = null;
        }

        [TestMethod]
        public void Log_ValidInputString_ReturnsVoid()
        {
            this.target.Setup(a => a.Log(It.IsAny<string>())).Verifiable();

            this.target.Verify(a => a.Log(It.IsAny<string>()), Times.Once);

            Assert.IsTrue(true);
        }
    }
}
