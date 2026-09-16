using System;
using System.Collections.Generic;
using System.Text;

namespace PhotographyStudioManagement.Models
{
    public class Booking
    {
        public int BookingID { get; set; }

        public int ClientID { get; set; }

        public int ServiceID { get; set; }

        public DateTime BookingDate { get; set; }

        public string Location { get; set; }

        public decimal Price { get; set; }

        public string BookingStatus { get; set; }

        public string PaymentStatus { get; set; }

        public decimal AmountPaid { get; set; }

        public string Notes { get; set; }

        public Booking()
        {
            Location = "";
            BookingStatus = "Pending";
            PaymentStatus = "Unpaid";
            Notes = "";
        }

        public Booking(
            int bookingID,
            int clientID,
            int serviceID,
            DateTime bookingDate,
            string location,
            decimal price,
            string bookingStatus,
            string paymentStatus,
            decimal amountPaid,
            string notes)
        {
            BookingID = bookingID;
            ClientID = clientID;
            ServiceID = serviceID;
            BookingDate = bookingDate;
            Location = location;
            Price = price;
            BookingStatus = bookingStatus;
            PaymentStatus = paymentStatus;
            AmountPaid = amountPaid;
            Notes = notes;
        }

        public string GetBookingDetails()
        {
            return $"Booking #{BookingID} - {BookingDate:d} - {BookingStatus}";
        }
    }
}