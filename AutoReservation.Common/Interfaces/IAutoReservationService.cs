using AutoReservation.Common.DataTransferObjects;
using System.Collections.ObjectModel;

namespace AutoReservation.Common.Interfaces
{
    public interface IAutoReservationService
    {
        Collection<AutoDto> GetAllAutos();        AutoDto GetAutoById(int id);
        AutoDto InsertAuto(AutoDto auto);
        AutoDto UpdateAuto(AutoDto modified, AutoDto original);
        AutoDto DeleteAuto(AutoDto auto);

        Collection<KundeDto> GetAllKunden();        KundeDto GetKundeById(int id);
        KundeDto InsertKunde(KundeDto kunde);
        KundeDto UpdateKunde(KundeDto modified, KundeDto original);
        KundeDto DeleteKunde(KundeDto kunde);

        Collection<ReservationDto> GetAllReservationen();        ReservationDto GetReservationById(int id);
        ReservationDto InsertReservation(ReservationDto reservation);
        ReservationDto UpdateReservation(ReservationDto modified, ReservationDto original);
        ReservationDto DeleteReservation(ReservationDto reservation);
    }
}
