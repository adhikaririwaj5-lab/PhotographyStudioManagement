namespace PhotographyStudioManagement.Models
{
    public abstract class Service
    {
        private decimal basePrice;

        public int ServiceID { get; set; }

        public string ServiceName { get; set; }

        public decimal BasePrice
        {
            get { return basePrice; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(
                        "Base price cannot be negative.");
                }

                basePrice = value;
            }
        }

        protected Service(
            int serviceID,
            string serviceName,
            decimal basePrice)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            BasePrice = basePrice;
        }

        public abstract decimal CalculatePrice(int hours);

        public virtual string GetServiceDetails()
        {
            return $"{ServiceName} - Base Price: ${BasePrice:F2}";
        }
    }
}