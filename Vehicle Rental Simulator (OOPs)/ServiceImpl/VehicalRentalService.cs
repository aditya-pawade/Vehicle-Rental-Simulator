using System;
using System.Collections.Generic;
using System.Text;
using Vehicle_Rental_Simulator__OOPs_.Model;
using Vehicle_Rental_Simulator__OOPs_.Service;

namespace Vehicle_Rental_Simulator__OOPs_.ServiceImpl
{
    internal class VehicalRentalService : IVehicleRentalService
    {
        private User user = new User();
        private Vehicle vehicle = new Vehicle();
        private Booking booking = new Booking();
        private Random randomUser = new Random();
        private Random randomVehicle = new Random();
        private Random randomBooking = new Random();
        public void AddVehicle()
        {
            if (vehicle.IsAvailabvle)
            {
                Console.WriteLine("Vehicle already exit.");
                return;
            }

            vehicle.VehicleId1 = randomVehicle.Next(100, 999);

            Console.WriteLine("\nEnter Vehicle Brand : ");
            vehicle.Title1 = Console.ReadLine();

            Console.WriteLine("\nEnter Vehicle Description : ");
            vehicle.Description1 = Console.ReadLine();

            Console.WriteLine("\nVehicle Category : ");
            vehicle.Category1 = Console.ReadLine();

            Console.WriteLine("\nVehicle Model : ");
            vehicle.Model1 = Console.ReadLine();

            Console.WriteLine("\nManufacturing Year : ");
            vehicle.Year1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nVehicle Color : ");
            vehicle.Color1 = Console.ReadLine();

            Console.WriteLine("\nLicense Plate : ");
            vehicle.LicensePlate1 = Console.ReadLine();

            Console.WriteLine("\nFuel Type : ");
            vehicle.FuelType1 = Console.ReadLine();

            Console.WriteLine("\nPrice Per Day : ");
            vehicle.PricePerDay1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSeating Capacity : ");
            vehicle.Seats1 = Convert.ToInt32(Console.ReadLine()) ;

            vehicle.IsAvailabvle = true;

            Console.WriteLine("\nVehicle data created.");
            Console.WriteLine("Vehicle ID : " + vehicle.VehicleId1);
        }

        public void BookVehicle()
        {
            if (!user.IsUserAvailable)
            {
                Console.WriteLine("Please register user first."); 
                return;
            }

            if (!vehicle.IsAvailabvle) 
            { 
                Console.WriteLine("Vehicle is not available."); 
                return; 
            }

            if (booking.IsBookingAvailable1) 
            { 
                Console.WriteLine("Booking already exists."); 
                return; 
            }

            booking.BookingID1 = randomBooking.Next(10, 99);

            booking.UserId1 = user.UserId1;

            booking.VehicleID1 = vehicle.VehicleId1;

            Console.WriteLine("\nEnter Start Date : "); 
            booking.StartDate1 = Console.ReadLine(); 
            
            Console.WriteLine("\nEnter End Date : "); 
            booking.EndDate1 = Console.ReadLine(); 
            
            Console.WriteLine("\nEnter Number of Days: "); 
            booking.TotalDays1 = Convert.ToInt32(Console.ReadLine());

            booking.TotalAmount1 = booking.TotalDays1 * vehicle.PricePerDay1;

            booking.IsBookingAvailable1 = true;

            vehicle.IsAvailabvle = false; 
            
            Console.WriteLine("\nVehicle booked successfully."); 
            Console.WriteLine("Booking ID : " + booking.BookingID1); 
            Console.WriteLine("Total Amount : " + booking.TotalAmount1);
        }

        public void CancelBooking()
        {
            if (!booking.IsBookingAvailable1) 
            { 
                Console.WriteLine("No booking available to cancel."); 
                return; 
            }

            if (!booking.IsPaymentDone1)
            {
                Console.WriteLine("\nBooking payment not done.");
                return;
            }

            booking.IsBookingAvailable1 = false;

            vehicle.IsAvailabvle = true;

            booking.IsPaymentDone1 = false;

            Console.WriteLine("\nBooking cancelled successfully.");
            Console.WriteLine("\nVehicle is now available.");
        }

        public void DisplayBookings()
        {
            if (!booking.IsBookingAvailable1)
            {
                Console.WriteLine("No booking available.");
                return;
            }

            Console.WriteLine("\n===== BOOKING DETAILS ====="); 
            Console.WriteLine("Booking ID   : " + booking.BookingID1); 
            Console.WriteLine("User ID      : " + booking.UserId1); 
            Console.WriteLine("Vehicle ID   : " + booking.VehicleID1); 
            Console.WriteLine("Start Date   : " + booking.StartDate1); 
            Console.WriteLine("End Date     : " + booking.EndDate1); 
            Console.WriteLine("Total Days   : " + booking.TotalDays1); 
            Console.WriteLine("Total Amount : " + booking.TotalAmount1);
        }

        public void DisplayUserDetails()
        {
            if (!user.IsUserAvailable)
            {
                Console.WriteLine("User doesn't exit.");
                return;
            }
            Console.WriteLine("\nEnter User ID : ");
            int UserID = Convert.ToInt32(Console.ReadLine());

            if(UserID == user.UserId1)
            {
                Console.WriteLine("\n====== USER DETAILS =====");
                Console.WriteLine("\nUser ID   : " + user.UserId1);
                Console.WriteLine("\nUser Name : " + user.Name1);
                Console.WriteLine("\nMail      : " + user.Email1);
                Console.WriteLine("\nContact   : " + user.PhoneNumber1);
                Console.WriteLine("\nRole      : " + user.Role1);

            }
            else
            {
                Console.WriteLine("Invalid User ID.");
                return;
            }

        }

        public void DisplayVehicles()
        {
            if (!vehicle.IsAvailabvle)
            {
                Console.WriteLine("Vehicle doesn't exit.");
                return;
            }

            Console.WriteLine("\n====== VEHICLE DETAILS =====");
            Console.WriteLine("\nVehicle Brand      : " + vehicle.Title1);
            Console.WriteLine("\nDescription        : " + vehicle.Description1);
            Console.WriteLine("\nCategory           : " + vehicle.Category1);
            Console.WriteLine("\nModel              : " + vehicle.Model1);
            Console.WriteLine("\nManufactoring Year : " + vehicle.Year1);
            Console.WriteLine("\nColor              : " + vehicle.Color1);
            Console.WriteLine("\nLicense Plate      : " + vehicle.LicensePlate1);
            Console.WriteLine("\nPrice Per Day      : " + vehicle.PricePerDay1);
            Console.WriteLine("\nFuel Type          : " + vehicle.FuelType1);
            Console.WriteLine("\nSeating Capacity   : " + vehicle.Seats1);
        }

        public void Login()
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void MakePayment()
        {
            if (!booking.IsBookingAvailable1)
            {
                Console.WriteLine("No booking available.");
                return;
            }

            if (booking.IsPaymentDone1) 
            { 
                Console.WriteLine("Payment already completed."); 
                return; 
            }

            Console.WriteLine("\n===== PAYMENT ====="); 
            Console.WriteLine("Booking ID   : " + booking.BookingID1); 
            Console.WriteLine("Total Amount : " + booking.TotalAmount1); 

            Console.WriteLine("\nSelect Payment Method : "); 
            Console.WriteLine("1. UPI         : "); 
            Console.WriteLine("2. Credit Card : "); 
            Console.WriteLine("3. Debit Card  : "); 

            Console.Write("\nEnter choice : "); 
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    booking.PaymentMethod1 = "UPI"; 
                    break;

                case 2: 
                    booking.PaymentMethod1 = "Credit Card"; 
                    break;

                case 3: 
                    booking.PaymentMethod1 = "Debit Card"; 
                    break;

                default: 
                    Console.WriteLine("Invalid payment method."); 
                    return;
            }

            booking.IsPaymentDone1 = true; 
            
            Console.WriteLine("\nPayment successful!"); 
            Console.WriteLine("Payment Method : " + booking.PaymentMethod1); 
            Console.WriteLine("Amount Paid    : " + booking.TotalAmount1);
        }

        public void RegisterUser()
        {
            if (user.IsUserAvailable)
            {
                Console.WriteLine("User already exit.");
                return;
            }

            user.UserId1 = randomUser.Next(10000, 99999);

            Console.WriteLine("\nEnter User Name : ");
            user.Name1 = Console.ReadLine();

            Console.WriteLine("\nEnter User Mail : ");
            user.Email1 = Console.ReadLine();

            Console.WriteLine("\nEnter User Contact : ");
            user.PhoneNumber1 = Console.ReadLine();

            Console.WriteLine("\nEnter User Role : ");
            user.Role1 = Console.ReadLine();

            user.IsUserAvailable = true;

            Console.WriteLine("\nUser account created.");
            Console.WriteLine("Your User ID : " + user.UserId1);
        }

        public void SearchVehicle()
        {
            if (!vehicle.IsAvailabvle)
            {
                Console.WriteLine("Vehicle doesn't exit.");
                return;
            }

            Console.WriteLine("\nEnter Vehicle ID : ");
            int VehicleID = Convert.ToInt32(Console.ReadLine());

            if (VehicleID == vehicle.VehicleId1)
            {
                Console.WriteLine("\n====== VEHICLE DETAILS =====");
                Console.WriteLine("\nVehicle Brand      : " + vehicle.Title1);
                Console.WriteLine("\nDescription        : " + vehicle.Description1);
                Console.WriteLine("\nCategory           : " + vehicle.Category1);
                Console.WriteLine("\nModel              : " + vehicle.Model1);
                Console.WriteLine("\nManufactoring Year : " + vehicle.Year1);
                Console.WriteLine("\nColor              : " + vehicle.Color1);
                Console.WriteLine("\nLicense Plate      : " + vehicle.LicensePlate1);
                Console.WriteLine("\nPrice Per Day      : " + vehicle.PricePerDay1);
                Console.WriteLine("\nFuel Type          : " + vehicle.FuelType1);
                Console.WriteLine("\nSeating Capacity   : " + vehicle.Seats1);
            }
            else
            {
                Console.WriteLine("\nInvalid vehicle ID.");
                return;
            }
        }

        public void UpdateProfile()
        {
            if (!user.IsUserAvailable)
            {
                Console.WriteLine("User doesn't exit.");
                return;
            }

            Console.WriteLine("Enter User ID : ");
            int UserID = Convert.ToInt32(Console.ReadLine());

            if (UserID == user.UserId1)
            {
                while (true)
                {
                    Console.WriteLine("\n===== USER DETAILS UPDATE =====");
                    Console.WriteLine("1. Name    : ");
                    Console.WriteLine("2. Mail    : ");
                    Console.WriteLine("3. Contact : ");
                    Console.WriteLine("4. Exit    : ");

                    Console.WriteLine("\nEnter Choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nEnter New Name : ");
                            user.Name1 = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("\nEnter New Mail : ");
                            user.Email1 = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("\nEnter New Contact : ");
                            user.PhoneNumber1 = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("\nThank you.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid User ID.");
                return;
            }
        }

        public void UpdateVehicle()
        {
            if (!vehicle.IsAvailabvle)
            {
                Console.WriteLine("Vehicle doesn't exit.");
                return;
            }

            Console.WriteLine("\nEnter Vehicle ID : ");
            int VehicleID = Convert.ToInt32(Console.ReadLine());

            if(VehicleID == vehicle.VehicleId1) 
            {
                while (true)
                {
                    Console.WriteLine("\n===== VEHICLE DETAILS UPDATE =====");
                    Console.WriteLine("1. Brand          : ");
                    Console.WriteLine("2. Description    : ");
                    Console.WriteLine("3. Category       : ");
                    Console.WriteLine("4. Model          : ");
                    Console.WriteLine("5. Year           : ");
                    Console.WriteLine("6. Color          : ");
                    Console.WriteLine("7. License Plate  : ");
                    Console.WriteLine("8. Price Per Day  : ");
                    Console.WriteLine("9. Fuel Type      : ");
                    Console.WriteLine("10. Seats         : ");
                    Console.WriteLine("11. Exit          : ");

                    Console.WriteLine("\nEnter Choice : ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\nEnter New Brand : ");
                            vehicle.Title1 = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("\nEnter New Description : ");
                            vehicle.Description1 = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("\nEnter New Category : ");
                            vehicle.Category1 = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("\nEnter New Model : ");
                            vehicle.Model1 = Console.ReadLine();
                            break;

                        case 5:
                            Console.WriteLine("Enter New Year : ");
                            vehicle.Year1 = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 6:
                            Console.WriteLine("Enter New Color : ");
                            vehicle.Color1 = Console.ReadLine();
                            break;

                        case 7:
                            Console.WriteLine("Enter New License Plate : ");
                            vehicle.LicensePlate1 = Console.ReadLine();
                            break;

                        case 8:
                            Console.WriteLine("Enter New Price Per Day : ");
                            vehicle.PricePerDay1 = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 9:
                            Console.WriteLine("Enter New Fuel Type : ");
                            vehicle.FuelType1 = Console.ReadLine();
                            break;

                        case 10:
                            Console.WriteLine("Enter New Seating Capacity : ");
                            vehicle.Seats1 = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 11:
                            Console.WriteLine("Thank you.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Vehicle ID.");
                return;
            }
        }
    }
}
