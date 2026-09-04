using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Simulator__OOPs_.Model
{
    internal class Vehicle
    {
        private int VehicleId;
        private string Title;
        private string Description;
        private string Category;
        private string Model;
        private int Year;
        private string Color;
        private string LicensePlate;
        private int PricePerDay;
        private string FuelType;
        private int Seats;
        private bool isAvailabvle;

        public int VehicleId1 { get => VehicleId; set => VehicleId = value; }
        public string Title1 { get => Title; set => Title = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Category1 { get => Category; set => Category = value; }
        public string Model1 { get => Model; set => Model = value; }
        public int Year1 { get => Year; set => Year = value; }
        public string Color1 { get => Color; set => Color = value; }
        public string LicensePlate1 { get => LicensePlate; set => LicensePlate = value; }
        public int PricePerDay1 { get => PricePerDay; set => PricePerDay = value; }
        public string FuelType1 { get => FuelType; set => FuelType = value; }
        public int Seats1 { get => Seats; set => Seats = value; }
        public bool IsAvailabvle { get => isAvailabvle; set => isAvailabvle = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
