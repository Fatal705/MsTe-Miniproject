﻿using AutoReservation.Common.DataTransferObjects;
using System.Collections.ObjectModel;

namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        Collection<AutoDto> GetAllAutos();
        AutoDto InsertAuto(AutoDto auto);
        AutoDto UpdateAuto(AutoDto modified, AutoDto original);
        AutoDto DeleteAuto(AutoDto auto);

        Collection<KundeDto> GetAllKunden();
        KundeDto InsertKunde(KundeDto kunde);
        KundeDto UpdateKunde(KundeDto modified, KundeDto original);
        KundeDto DeleteKunde(KundeDto kunde);

        Collection<ReservationDto> GetAllReservationen();
        ReservationDto InsertReservation(ReservationDto reservation);
        ReservationDto UpdateReservation(ReservationDto modified, ReservationDto original);
        ReservationDto DeleteReservation(ReservationDto reservation);
    }
}