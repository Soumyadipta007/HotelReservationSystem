using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservationSystem
{
    public class HotelCheck
    {
        public List<HotelReservation> hotelList=new List<HotelReservation>();
        public string findCheapestHotel()
        {
            int min = int.MaxValue;
            HotelReservation cheapestHotel = null;
            foreach(HotelReservation hotel in hotelList)
            {
                if(hotel.rateForRegularCustomer< min)
                {
                    cheapestHotel = hotel;
                    min = hotel.rateForRegularCustomer;
                }
            }
            return cheapestHotel.Name;
        }
    }
}
