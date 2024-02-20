﻿using System;

namespace CSIntermediate.Interfaces
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;

        }

        public void Process(Order order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }
            else
            {
                order.Shipment = new Shipment
                {
                    Cost = _shippingCalculator.CalculateShipping(order),
                    ShippingDate = DateTime.Today.AddDays(1)

                };
                          
            }
        }
    }
}
