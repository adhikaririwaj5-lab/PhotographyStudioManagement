using System;
using System.Collections.Generic;
using System.Text;

namespace PhotographyStudioManagement.Models
{
    public class PhotographyService : Service
    {
        public PhotographyService(
            int serviceID,
            string serviceName,
            decimal basePrice)
            : base(serviceID, serviceName, basePrice)
        {
        }

        public override decimal CalculatePrice(int hours)
        {
            return BasePrice * hours;
        }

        public override string GetServiceDetails()
        {
            return $"Photography: {ServiceName} - ${BasePrice:F2} per hour";
        }
    }
}