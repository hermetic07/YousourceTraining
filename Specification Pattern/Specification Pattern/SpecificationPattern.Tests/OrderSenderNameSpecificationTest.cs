using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecificationPattern.Classes;
using System.Collections.Generic;

namespace SpecificationPattern.Tests
{
    [TestClass]
    public class OrderSenderNameSpecificationTest
    {
        OrderSenderNameSpecification target;
        ICollection<string> errors;

        [TestInitialize]
        public void Setup()
        {
            this.target = new OrderSenderNameSpecification();
            errors = new List<string>();
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

            var actual = this.target.IsSatisfiedBy(order,ref errors);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsSatisfiedBy_Invalid_False()
        {

            OrderRequest order = new OrderRequest()
            {
                SenderName = ""
            };

            var actual = this.target.IsSatisfiedBy(order, ref errors);

            Assert.IsFalse(actual);
        }
    }
}
