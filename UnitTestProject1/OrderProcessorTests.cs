using CSIntermediate.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class OrderProcessorTests
    {
        // METHODNAME_CONDITION_EXPECTATION
            
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]  
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);

        }


    }

    public class FakeShippingCalculator : IShippingCalculator
    {

        public float CalculateShipping(Order order)
        {
            // throw new NotImplementedException();
            return 1;
        }
    }
}
