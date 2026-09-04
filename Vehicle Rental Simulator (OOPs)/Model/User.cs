using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Rental_Simulator__OOPs_.Model
{
    internal class User
    {
        private int UserId;
        private string Name;
        private string Email;
        private string PhoneNumber;
        private string Password;
        private string Role;
        private bool Approved;
        private bool Blocked;
        private bool isUserAvailable;
        
        private bool isLoggedIn;
        public int UserId1 { get => UserId; set => UserId = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Role1 { get => Role; set => Role = value; }
        public bool Approved1 { get => Approved; set => Approved = value; }
        public bool Blocked1 { get => Blocked; set => Blocked = value; }
        public bool IsUserAvailable { get => isUserAvailable; set => isUserAvailable = value; }
        
        public bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
