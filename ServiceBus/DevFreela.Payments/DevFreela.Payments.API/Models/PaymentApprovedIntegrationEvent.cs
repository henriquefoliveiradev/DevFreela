﻿namespace DevFreela.Payments.API.Models
{
    public class PaymentApprovedIntegrationEvent
    {
        public PaymentApprovedIntegrationEvent(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
