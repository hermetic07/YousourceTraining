namespace SpecificationPattern.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpecificationPattern.Classes;

    [TestClass]
    public class OrderRecipientContactSpecificationTest
    {
        private OrderRecipientContactSpecification target;
        private ICollection<string> errors;

        [TestInitialize]
        public void Setup()
        {
            this.target = new OrderRecipientContactSpecification();
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
                RecipientContactNumber = "+639476158346"
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsSatisfiedBy_InvalidRequestModel_ReturnsFalse()
        {
            OrderRequest order = new OrderRequest()
            {
                RecipientContactNumber = "09476158346"
            };

            var actual = this.target.IsSatisfiedBy(order, ref this.errors);

            Assert.IsFalse(actual);
        }
    }
}
