using System;
using System.Collections.Generic;
using System.Text;
using Vehicle_Rental_Simulator__OOPs_.Model;
using Vehicle_Rental_Simulator__OOPs_.Service;
using Vehicle_Rental_Simulator__OOPs_.ServiceImpl;

namespace Vehicle_Rental_Simulator__OOPs_.Controller
{
    internal class VehicleRentalController
    {
        static void Main(string[] args)
        {
            IVehicleRentalService service = new VehicalRentalService();

            while (true)
            {
                Console.WriteLine("\n======= VEHICLE RENTAL SIMULATOR =====");

                Console.WriteLine("\n----- USER DASHBOARD -----");
                Console.WriteLine("1. Register User           : ");
                Console.WriteLine("2. Display User Details    : ");
                Console.WriteLine("3. Update Profile          : ");

                Console.WriteLine("\n----- VEHICLE DASHBOARD -----");
                Console.WriteLine("4. Register Vehicle        : ");
                Console.WriteLine("5. Display Vehicle Details : ");
                Console.WriteLine("6. Update Vehicle          : ");
                Console.WriteLine("7. Search Vehicle          : ");

                Console.WriteLine("\n----- BOOKING DASHBOARD -----");
                Console.WriteLine("8. Book Vehicle            : ");
                Console.WriteLine("9. Display Booking Details : ");
                Console.WriteLine("10. Cancel Booking         : ");

                Console.WriteLine("\n----- PAYMENT DASHBOARD -----");
                Console.WriteLine("11. Make Payment           : ");

                Console.WriteLine("\n12. Exit                 : \n");

                Console.WriteLine("\nEnter choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.RegisterUser();
                        break;

                    case 2:
                        service.DisplayUserDetails();
                        break;

                    case 3:
                        service.UpdateProfile();
                        break;

                    case 4:
                        service.AddVehicle();
                        break;

                    case 5:
                        service.DisplayVehicles();
                        break;

                    case 6:
                        service.UpdateVehicle();
                        break;

                    case 7:
                        service.SearchVehicle();
                        break;

                    case 8:
                        service.BookVehicle();
                        break;

                    case 9:
                        service.DisplayBookings();
                        break;

                    case 10:
                        service.CancelBooking();
                        break;

                    case 11:
                        service.MakePayment();
                        break;

                    case 12:
                        Console.WriteLine("Thank you.");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
