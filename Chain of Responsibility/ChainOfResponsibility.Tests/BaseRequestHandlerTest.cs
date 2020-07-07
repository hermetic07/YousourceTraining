namespace ChainOfResponsibility.Tests
{
    using Chain_of_Responsibility.Classes;
    using Chain_of_Responsibility.Handlers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public class BaseRequestHandlerTest
    {
        public Mock<BaseRequestHandler> target;

        [TestInitialize]
        public void Setup()
        {
            this.target = new Mock<BaseRequestHandler>();
        }

        [TestCleanup]
        public void Teardown()
        {
            this.target = null;
        }

        [TestMethod]
        public void Parse_ValidXmlRequest_ReturnsVoid()
        {
            Request request = new Request()
            {
                ContentType = "xml",
                Content = @"<PurchaseOrder>
                                <PurchasedGame>
                                    <Name>GTA</Name>
                                </PurchasedGame>
                                <Customer>
                                    <Name>Evander</Name>
                                </Customer>
                            </PurchaseOrder>"
            };

            this.target.Object.Handle(request);

            this.target.Verify(a => a.Handle(It.IsAny<Request>()), Times.Once);
        }
    }
}
