using System;
using System.Collections.Generic;
using System.Text;

namespace PhotographyStudioManagement.Models
{
    public class Service
    {
        public int ServiceID { get; set; }

        public string ServiceName { get; set; }

        public string Description { get; set; }

        public decimal BasePrice { get; set; }

        public Service()
        {
            ServiceName = "";
            Description = "";
        }

        public Service(int serviceID, string serviceName,
            string description, decimal basePrice)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            Description = description;
            BasePrice = basePrice;
        }

        public string GetServiceDetails()
        {
            return $"{ServiceName} - ${BasePrice:F2}";
        }
    }
}