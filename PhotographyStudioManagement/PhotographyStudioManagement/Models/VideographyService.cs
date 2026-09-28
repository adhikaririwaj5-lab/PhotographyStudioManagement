using System;
using System.Collections.Generic;
using System.Text;

namespace PhotographyStudioManagement.Models
{
    public class VideographyService : Service
    {
        public decimal EditingFee { get; set; }

        public VideographyService(
            int serviceID,
            string serviceName,
            decimal basePrice,
            decimal editingFee)
            : base(serviceID, serviceName, basePrice)
        {
            EditingFee = editingFee;
        }

        public override decimal CalculatePrice(int hours)
        {
            return (BasePrice * hours) + EditingFee;
        }

        public override string GetServiceDetails()
        {
            return $"Videography: {ServiceName} - " +
                   $"${BasePrice:F2}/hour + ${EditingFee:F2} editing";
        }
    }
}
