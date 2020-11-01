using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelReservationSystem;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HotelReservation hotelReservation = new HotelReservation("Raj",10000);
            Assert.AreEqual("Raj", hotelReservation.Name);
        }
    }
}
