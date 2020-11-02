using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddHotelCheck()
        {
            HotelReservation hotelReservation = new HotelReservation("Taj",10000, "10Sep2020", "20Sep2020");
            Assert.AreEqual("Taj", hotelReservation.Name);
        }
        [TestMethod]
        public void GetCheapestHotel()
        {
            HotelReservation hotelReservation1 = new HotelReservation("LakeWood", 30000,"10Sep2020", "11Sep2020");
            HotelReservation hotelReservation2 = new HotelReservation("BridgeWood", 10000, "10Sep2020", "11Sep2020");
            HotelReservation hotelReservation3 = new HotelReservation("RidgeWood", 20000, "10Sep2020", "11Sep2020");
            HotelCheck hotelCheck = new HotelCheck();
            hotelCheck.hotelList.Add(hotelReservation1);
            hotelCheck.hotelList.Add(hotelReservation2);
            hotelCheck.hotelList.Add(hotelReservation3);
            string cheapestHotel = hotelCheck.findCheapestHotel();
            Assert.AreEqual("BridgeWood", cheapestHotel);
        }
    }
}
