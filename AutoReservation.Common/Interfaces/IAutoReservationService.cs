using AutoReservation.Common.DataTransferObjects;
using System.Collections.Generic;
using System.ServiceModel;

namespace AutoReservation.Common.Interfaces
{
    [ServiceContract]
    public interface IAutoReservationService
    {
        [OperationContract]
        List<AutoDto> GetAllAutos();
        [OperationContract]
        AutoDto GetAutoById(int id);
        [OperationContract]
        AutoDto InsertAuto(AutoDto auto);
        [OperationContract]
        AutoDto UpdateAuto(AutoDto modified, AutoDto original);
        [OperationContract]
        AutoDto DeleteAuto(AutoDto auto);

        [OperationContract]
        List<KundeDto> GetAllKunden();
        [OperationContract]
        KundeDto GetKundeById(int id);
        [OperationContract]
        KundeDto InsertKunde(KundeDto kunde);
        [OperationContract]
        KundeDto UpdateKunde(KundeDto modified, KundeDto original);
        [OperationContract]
        KundeDto DeleteKunde(KundeDto kunde);

        [OperationContract]
        List<ReservationDto> GetAllReservationen();
        [OperationContract]
        ReservationDto GetReservationById(int id);
        [OperationContract]
        ReservationDto InsertReservation(ReservationDto reservation);
        [OperationContract]
        ReservationDto UpdateReservation(ReservationDto modified, ReservationDto original);
        [OperationContract]
        ReservationDto DeleteReservation(ReservationDto reservation);
    }
}
