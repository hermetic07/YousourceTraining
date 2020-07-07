namespace ChainOfResponsibility.Tests
{
    using Chain_of_Responsibility.Classes;
    using Chain_of_Responsibility.Handlers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class JsonRequestHandlerTest
    {
        Mock<JsonRequestHandler> target;

        [TestInitialize]
        public void Setup()
        {
            this.target = new Mock<JsonRequestHandler>();
        }

        [TestCleanup]
        public void Teardown()
        {
            this.target = null;
        }

        [TestMethod]
        public void Parse_ValidJsonRequest_ReturnsVoid()
        {
            Request request = new Request()
            {
                ContentType = "json",
                Content = @"{""name"":""John Doe"",""age"":20}"
            };

            this.target.Object.Handle(request);

            this.target.Verify(a => a.Handle(It.IsAny<Request>()), Times.Once);
        }
    }
}
