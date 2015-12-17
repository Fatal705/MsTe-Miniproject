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
        void InsertAuto(AutoDto auto);
        [OperationContract]
        [FaultContract(typeof(AutoDto))]
        void UpdateAuto(AutoDto modified, AutoDto original);
        [OperationContract]
        void DeleteAuto(AutoDto auto);

        [OperationContract]
        List<KundeDto> GetAllKunden();
        [OperationContract]
        KundeDto GetKundeById(int id);
        [OperationContract]
        void InsertKunde(KundeDto kunde);
        [OperationContract]
        [FaultContract(typeof(KundeDto))]
        void UpdateKunde(KundeDto modified, KundeDto original);
        [OperationContract]
        void DeleteKunde(KundeDto kunde);

        [OperationContract]
        List<ReservationDto> GetAllReservationen();
        [OperationContract]
        ReservationDto GetReservationById(int id);
        [OperationContract]
        void InsertReservation(ReservationDto reservation);
        [OperationContract]
        [FaultContract(typeof(ReservationDto))]
        void UpdateReservation(ReservationDto modified, ReservationDto original);
        [OperationContract]
        void DeleteReservation(ReservationDto reservation);
    }
}
