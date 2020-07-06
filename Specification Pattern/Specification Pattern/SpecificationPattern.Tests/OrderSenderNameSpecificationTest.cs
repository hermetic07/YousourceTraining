namespace SpecificationPattern.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpecificationPattern.Classes;

    [TestClass]
    public class OrderSenderNameSpecificationTest
    {
        private OrderSenderNameSpecification target;
        private ICollection<string> errors;

        [TestInitialize]
        public void Setup()
        {
            this.target = new OrderSenderNameSpecification();
            this.errors = new List<string>();
        }

        [TestCleanup]
        public void Teardown()
        {
            this.target = null;
            this.errors = null;
        }

        [TestMethod]
        public void IsSatisfiedBy_Valid_True()
        {
            OrderRequest order = new OrderRequest()
            {
                SenderName = "Evander"
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsSatisfiedBy_Invalid_False()
        {
            OrderRequest order = new OrderRequest()
            {
                SenderName = string.Empty
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsFalse(actual);
        }
    }
}
