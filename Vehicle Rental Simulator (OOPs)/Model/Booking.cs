using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Simulator__OOPs_.Model
{
    internal class Booking
    {
        private int BookingID;
        private int UserId;
        private int VehicleID;
        private string StartDate;
        private string EndDate;
        private int TotalDays;
        private int TotalAmount;
        private bool IsBookingAvailable;
        private bool IsPaymentDone;
        private string PaymentMethod;

        public int BookingID1 { get => BookingID; set => BookingID = value; }
        public int UserId1 { get => UserId; set => UserId = value; }
        public int VehicleID1 { get => VehicleID; set => VehicleID = value; }
        public string StartDate1 { get => StartDate; set => StartDate = value; }
        public string EndDate1 { get => EndDate; set => EndDate = value; }
        public int TotalDays1 { get => TotalDays; set => TotalDays = value; }
        public int TotalAmount1 { get => TotalAmount; set => TotalAmount = value; }
        public bool IsBookingAvailable1 { get => IsBookingAvailable; set => IsBookingAvailable = value; }
        public bool IsPaymentDone1 { get => IsPaymentDone; set => IsPaymentDone = value; }
        public string PaymentMethod1 { get => PaymentMethod; set => PaymentMethod = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
