﻿namespace RazorPay.Models
{
    public class MerchantOrder
    {
        public string OrderId { get; set; }
        public string RazorpayKey { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
