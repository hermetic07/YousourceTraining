namespace SpecificationPattern.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpecificationPattern.Classes;

    [TestClass]
    public class OrderSenderEmailSpecificationTest
    {
        private OrderSenderEmailSpecification target;
        private ICollection<string> errors;

        [TestInitialize]
        public void Setup()
        {
            this.target = new OrderSenderEmailSpecification();
            this.errors = new List<string>();
        }

        [TestCleanup]
        public void Teardown()
        {
            this.target = null;
            this.errors = null;
        }

        [TestMethod]
        public void IsSatisfiedBy_ValidRequestModel_ReturnsTrue()
        {
            OrderRequest order = new OrderRequest()
            {
                SenderEmail = "emacandog@you-source.com"
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsSatisfiedBy_InvalidRequestModel_ReturnsFalse()
        {
            OrderRequest order = new OrderRequest()
            {
                SenderEmail = "emacandog"
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsFalse(actual);
        }
    }
}
