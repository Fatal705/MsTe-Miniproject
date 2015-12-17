using AutoReservation.Dal;
using AutoReservation.TestEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoReservation.BusinessLayer.Testing
{
    [TestClass]
    public class BusinessLayerTest
    {
        private AutoReservationBusinessComponent target;
        private AutoReservationBusinessComponent Target
        {
            get
            {
                if (target == null)
                {
                    target = new AutoReservationBusinessComponent();
                }
                return target;
            }
        }


        [TestInitialize]
        public void InitializeTestData()
        {
            TestEnvironmentHelper.InitializeTestData();
        }
        
        [TestMethod]
        public void Test_UpdateAuto()
        {
            Auto auto = Target.GetAutoById(1);
            Auto original = Target.GetAutoById(1);
            auto.Marke = "BMW 1er";
            Target.UpdateAuto(auto, original);
            Auto modified = Target.GetAutoById(1);
            Assert.AreEqual(auto.Marke, modified.Marke);
        }

        [TestMethod]
        public void Test_UpdateKunde()
        {
            Kunde kunde = Target.GetKundeById(1);
            Kunde original = Target.GetKundeById(1);
            kunde.Nachname = "Thamm";
            kunde.Vorname = "Dominik";
            Target.UpdateKunde(kunde, original);
            Kunde modified = Target.GetKundeById(1);
            Assert.AreEqual(kunde.Nachname, modified.Nachname);
            Assert.AreEqual(kunde.Vorname, modified.Vorname);
        }

        [TestMethod]
        public void Test_UpdateReservation()
        {
            Reservation reservation = Target.GetReservationById(1);
            Reservation original = Target.GetReservationById(1);
            reservation.AutoId = 3;
            Target.UpdateReservation(reservation, original);
            Reservation modified = Target.GetReservationById(1);
            Assert.AreEqual(reservation.AutoId, modified.AutoId);
        }
    }
}
