namespace SpecificationPattern.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpecificationPattern.Classes;

    [TestClass]
    public class OrderSenderContactSpecificationTest
    {
        private OrderSenderContactSpecification target;
        private ICollection<string> errors;

        [TestInitialize]
        public void Setup()
        {
            this.target = new OrderSenderContactSpecification();
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
                SenderContactNumber = "+639476158346"
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsSatisfiedBy_Invalid_False()
        {
            OrderRequest order = new OrderRequest()
            {
                SenderContactNumber = "09476158346"
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsFalse(actual);
        }
    }
}
