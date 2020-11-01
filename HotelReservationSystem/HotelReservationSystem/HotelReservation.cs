using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        public string Name { get; set; }
        public int rateForRegularCustomer { get; set; }
        public HotelReservation(string Name, int rate)
        {
            this.Name = Name;
            this.rateForRegularCustomer = rate;
        }        
    }
}
