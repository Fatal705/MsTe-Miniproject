using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using AutoReservation.BusinessLayer;

namespace AutoReservation.Service.Wcf
{
    public class AutoReservationService : IAutoReservationService
    {
        private AutoReservationBusinessComponent business;
        
        public AutoReservationService()
        {
            business = new AutoReservationBusinessComponent();
        }

        private static void WriteActualMethod()
        {
            Console.WriteLine("Calling: " + new StackTrace().GetFrame(1).GetMethod().Name);
        }

        public AutoDto DeleteAuto(AutoDto auto)
        {
            WriteActualMethod();
            return business.DeleteAuto(auto.ConvertToEntity()).ConvertToDto();  
        }

        public KundeDto DeleteKunde(KundeDto kunde)
        {
            WriteActualMethod();
            return business.DeleteKunde(kunde.ConvertToEntity()).ConvertToDto();
        }

        public ReservationDto DeleteReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            return business.DeleteReservation(reservation.ConvertToEntity()).ConvertToDto();
        }

        public List<AutoDto> GetAllAutos()
        {
            WriteActualMethod();
            return business.GetAllAutos().ConvertToDtos();
        }

        public List<KundeDto> GetAllKunden()
        {
            WriteActualMethod();
            return business.GetAllKunden().ConvertToDtos();
        }

        public List<ReservationDto> GetAllReservationen()
        {
            WriteActualMethod();
            return business.GetAllReservationen().ConvertToDtos();
        }

        public AutoDto GetAutoById(int id)
        {
            WriteActualMethod();
            return business.GetAutoById(id).ConvertToDto();
        }

        public KundeDto GetKundeById(int id)
        {
            WriteActualMethod();
            return business.GetKundeById(id).ConvertToDto();
        }

        public ReservationDto GetReservationById(int id)
        {
            WriteActualMethod();
            return business.GetReservationById(id).ConvertToDto();
        }

        public AutoDto InsertAuto(AutoDto auto)
        {
            WriteActualMethod();
            return business.InsertAuto(auto.ConvertToEntity()).ConvertToDto();
        }

        public KundeDto InsertKunde(KundeDto kunde)
        {
            WriteActualMethod();
            return business.InsertKunde(kunde.ConvertToEntity()).ConvertToDto();
        }

        public ReservationDto InsertReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            return business.InsertReservation(reservation.ConvertToEntity()).ConvertToDto();
        }

        public AutoDto UpdateAuto(AutoDto modified, AutoDto original)
        {
            WriteActualMethod();
            return business.UpdateAuto(modified.ConvertToEntity(), original.ConvertToEntity()).ConvertToDto();
        }

        public KundeDto UpdateKunde(KundeDto modified, KundeDto original)
        {
            WriteActualMethod();
            return business.UpdateKunde(modified.ConvertToEntity(), original.ConvertToEntity()).ConvertToDto();
        }

        public ReservationDto UpdateReservation(ReservationDto modified, ReservationDto original)
        {
            WriteActualMethod();
            return business.UpdateReservation(modified.ConvertToEntity(), original.ConvertToEntity()).ConvertToDto();
        }
    }
}