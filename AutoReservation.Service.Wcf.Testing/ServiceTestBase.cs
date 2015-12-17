using AutoReservation.Common.DataTransferObjects;
using AutoReservation.Common.Interfaces;
using AutoReservation.TestEnvironment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace AutoReservation.Service.Wcf.Testing
{
    [TestClass]
    public abstract class ServiceTestBase
    {
        protected abstract IAutoReservationService Target { get; }

        [TestInitialize]
        public void InitializeTestData()
        {
            TestEnvironmentHelper.InitializeTestData();
        }

        [TestMethod]
        public void Test_GetAutos()
        {
            List<AutoDto> autos = Target.GetAllAutos();
            Assert.AreEqual(autos.Count, 3);
        }

        [TestMethod]
        public void Test_GetKunden()
        {
            List<KundeDto> kunden = Target.GetAllKunden();
            Assert.AreEqual(kunden.Count, 4);
        }

        [TestMethod]
        public void Test_GetReservationen()
        {
            List<ReservationDto> reservation = Target.GetAllReservationen();
            Assert.AreEqual(reservation.Count, 1);
        }

        [TestMethod]
        public void Test_GetAutoById()
        {
            AutoDto auto = Target.GetAutoById(1);
            Assert.AreEqual(auto.Id, 1);
        }

        [TestMethod]
        public void Test_GetKundeById()
        {
            KundeDto kunde = Target.GetKundeById(1);
            Assert.AreEqual(kunde.Id, 1);
        }

        [TestMethod]
        public void Test_GetReservationByNr()
        {
            ReservationDto reservation = Target.GetReservationById(1);
            Assert.AreEqual(reservation.ReservationNr, 1); ;
        }

        [TestMethod]
        public void Test_GetReservationByIllegalNr()
        {
            ReservationDto reservation = Target.GetReservationById(10);
            Assert.IsNull(reservation);
        }

        [TestMethod]
        public void Test_InsertAuto()
        {       
            AutoDto newAuto = new AutoDto();
            newAuto.Id = 4;
            newAuto.Marke = "Audi R8";
            newAuto.AutoKlasse = 0;
            newAuto.Tagestarif = 150;
            newAuto.Basistarif = 50;
            Target.InsertAuto(newAuto);
            AutoDto auto = Target.GetAutoById(4);
            Assert.AreEqual(auto.Id, newAuto.Id);
        }

        [TestMethod]
        public void Test_InsertKunde()
        {
            KundeDto newKunde = new KundeDto();
            newKunde.Id = 5;
            newKunde.Nachname = "Thamm";
            newKunde.Vorname = "Dominik";
            newKunde.Geburtsdatum = DateTime.Now;
            Target.InsertKunde(newKunde);
            KundeDto kunde = Target.GetKundeById(5);
            Assert.AreEqual(kunde.Id, newKunde.Id);
        }

        [TestMethod]
        public void Test_InsertReservation()
        {
            ReservationDto newReservation = new ReservationDto();
            newReservation.ReservationNr = 2;
            newReservation.Kunde = Target.GetKundeById(1);
            newReservation.Auto = Target.GetAutoById(1);
            newReservation.Von = DateTime.Now;
            newReservation.Bis = DateTime.Now.AddDays(50);
            Target.InsertReservation(newReservation);
            ReservationDto reservation = Target.GetReservationById(2);
            Assert.AreEqual(reservation.ReservationNr, newReservation.ReservationNr);
        }

        [TestMethod]
        public void Test_UpdateAuto()
        {
            AutoDto auto = Target.GetAutoById(1);
            AutoDto original = Target.GetAutoById(1);
            auto.Marke = "BMW 1er";
            Target.UpdateAuto(auto, original);
            AutoDto modified = Target.GetAutoById(1);
            Assert.AreEqual(auto.Marke, modified.Marke);
        }

        [TestMethod]
        public void Test_UpdateKunde()
        {
            KundeDto kunde = Target.GetKundeById(1);
            KundeDto original = Target.GetKundeById(1);
            kunde.Nachname = "Thamm";
            kunde.Vorname = "Dominik";
            Target.UpdateKunde(kunde, original);
            KundeDto modified = Target.GetKundeById(1);
            Assert.AreEqual(kunde.Nachname, modified.Nachname);
            Assert.AreEqual(kunde.Vorname, modified.Vorname);
        }

        [TestMethod]
        public void Test_UpdateReservation()
        {
            ReservationDto reservation = Target.GetReservationById(1);
            ReservationDto original = Target.GetReservationById(1);
            reservation.Von = DateTime.Now;
            Target.UpdateReservation(reservation, original);
            ReservationDto modified = Target.GetReservationById(1);
            Assert.AreEqual(reservation.Von, modified.Von);
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<AutoDto>))]
        public void Test_UpdateAutoWithOptimisticConcurrency()
        {
            AutoDto auto1 = Target.GetAutoById(1);
            AutoDto auto2 = Target.GetAutoById(1);
            AutoDto original = Target.GetAutoById(1);
            auto1.Marke = "Audi R8";
            auto2.Marke = "BMW 1er";
            Target.UpdateAuto(auto1, original);
            Target.UpdateAuto(auto2, original);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<KundeDto>))]
        public void Test_UpdateKundeWithOptimisticConcurrency()
        {
            KundeDto kunde1 = Target.GetKundeById(1);
            KundeDto kunde2 = Target.GetKundeById(1);
            KundeDto original = Target.GetKundeById(1);
            kunde1.Nachname = "Thamm";
            kunde2.Nachname = "Ryser";
            Target.UpdateKunde(kunde1, original);
            Target.UpdateKunde(kunde2, original);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(FaultException<ReservationDto>))]
        public void Test_UpdateReservationWithOptimisticConcurrency()
        {
            ReservationDto reservation1 = Target.GetReservationById(1);
            ReservationDto reservation2 = Target.GetReservationById(1);
            ReservationDto original = Target.GetReservationById(1);
            reservation1.Bis = DateTime.Now.AddDays(1);
            reservation2.Bis = DateTime.Now.AddDays(2);
            Target.UpdateReservation(reservation1, original);
            Target.UpdateReservation(reservation2, original);
            Assert.Fail();
        }

        [TestMethod]
        public void Test_DeleteKunde()
        {
            List<KundeDto> kunden = Target.GetAllKunden();
            Target.DeleteKunde(Target.GetKundeById(1));
            Assert.IsNull(Target.GetKundeById(1));
        }

        [TestMethod]
        public void Test_DeleteAuto()
        {
            List<AutoDto> autos = Target.GetAllAutos();
            Target.DeleteAuto(Target.GetAutoById(1));
            Assert.IsNull(Target.GetAutoById(1));
        }

        [TestMethod]
        public void Test_DeleteReservation()
        {
            List<ReservationDto> autos = Target.GetAllReservationen();
            Target.DeleteReservation(Target.GetReservationById(1));
            Assert.IsNull(Target.GetReservationById(1));
        }
    }
}
