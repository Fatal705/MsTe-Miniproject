using AutoReservation.Common.Interfaces;
using System;
using System.Diagnostics;
using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using AutoReservation.BusinessLayer;
using AutoReservation.Dal;
using System.ServiceModel;

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

        public void DeleteAuto(AutoDto auto)
        {
            WriteActualMethod();
            business.DeleteAuto(auto.ConvertToEntity());  
        }

        public void DeleteKunde(KundeDto kunde)
        {
            WriteActualMethod();
            business.DeleteKunde(kunde.ConvertToEntity());
        }

        public void DeleteReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            business.DeleteReservation(reservation.ConvertToEntity());
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

        public void InsertAuto(AutoDto auto)
        {
            WriteActualMethod();
            business.InsertAuto(auto.ConvertToEntity());
        }

        public void InsertKunde(KundeDto kunde)
        {
            WriteActualMethod();
            business.InsertKunde(kunde.ConvertToEntity());
        }

        public void InsertReservation(ReservationDto reservation)
        {
            WriteActualMethod();
            business.InsertReservation(reservation.ConvertToEntity());
        }

        public void UpdateAuto(AutoDto modified, AutoDto original)
        {
            WriteActualMethod();
            try
            {
                business.UpdateAuto(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (LocalOptimisticConcurrencyException<Auto> e)
            {
                throw new FaultException<AutoDto>(e.MergedEntity.ConvertToDto());
            }
        }

        public void UpdateKunde(KundeDto modified, KundeDto original)
        {
            WriteActualMethod();
            try
            {
                business.UpdateKunde(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (LocalOptimisticConcurrencyException<Kunde> e)
            {
                throw new FaultException<KundeDto>(e.MergedEntity.ConvertToDto());
            }
        }

        public void UpdateReservation(ReservationDto modified, ReservationDto original)
        {
            WriteActualMethod();
            try
            {
                business.UpdateReservation(modified.ConvertToEntity(), original.ConvertToEntity());
            }
            catch (LocalOptimisticConcurrencyException<Reservation> e)
            {
                throw new FaultException<ReservationDto>(e.MergedEntity.ConvertToDto());
            }
        }
    }
}