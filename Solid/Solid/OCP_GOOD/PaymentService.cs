using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_GOOD
{
    public class PaymentService
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentService(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void Pay()
        {
            /// Implementation

            _paymentMethod.Pay();

            /// Implementation
        }
    }
}
