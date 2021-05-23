using System;
using Volo.Abp.Auditing;

namespace DemoApp
{
    public class CreateOrderDto
    {
        public Guid CustomerId { get; set; }
        public string DeliveryAddress { get; set; }
        [DisableAuditing]
        public string CreditCardNumber { get; set; }
    }
}