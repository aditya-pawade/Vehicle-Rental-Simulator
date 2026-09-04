using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Simulator__OOPs_.Service
{
    internal interface IVehicleRentalService
    {
        void RegisterUser();
        void Login();
        void Logout();
        void UpdateProfile();
        void DisplayUserDetails();
        void AddVehicle();
        void DisplayVehicles();
        void UpdateVehicle();
        void SearchVehicle();
        void BookVehicle();
        void DisplayBookings();
        void CancelBooking();
        void MakePayment();

    }
}
