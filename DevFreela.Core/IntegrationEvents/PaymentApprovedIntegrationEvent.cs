using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Core.IntegrationEvents
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
