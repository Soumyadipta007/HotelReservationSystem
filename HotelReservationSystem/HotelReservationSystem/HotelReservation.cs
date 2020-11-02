using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelReservation
    {
        public string Name { get; set; }
        public int rateForRegularCustomer { get; set; }
        public string startingDate { get; set; }
        public string endingDate { get; set; }
        public HotelReservation(string Name, int rate,string startingDate,string endingdDate)
        {
            this.Name = Name;
            this.rateForRegularCustomer = rate;
            this.startingDate = startingDate;
            this.endingDate = endingDate;
        }
    }
}
