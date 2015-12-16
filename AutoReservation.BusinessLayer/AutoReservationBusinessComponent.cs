using AutoReservation.Dal;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;

namespace AutoReservation.BusinessLayer
{
    public class AutoReservationBusinessComponent
    {
        private AutoReservationEntities context;

        public AutoReservationBusinessComponent()
        {
            this.context = new AutoReservationEntities();
        }

        public Collection<Auto> GetAllAutos()
        {
            return context.Autos.Local;
        }

        public Auto GetAutoById(int id)
        {
            return context.Autos.Find(id);
        }

        public Auto InsertAuto(Auto auto)
        {
            return context.Autos.Add(auto);
        }

        public Auto UpdateAuto(Auto modified, Auto original)
        {
            context.Autos.Attach(original);
            try
            {
                context.Entry(original).CurrentValues.SetValues(modified);
            }
            catch (DbUpdateConcurrencyException)
            {
                HandleDbConcurrencyException<Auto>(context, original);
            }
            return modified;
              
        }

        public Auto DeleteAuto(Auto auto)
        {
            context.Autos.Attach(auto);
            return context.Autos.Remove(auto);
        }



        public Collection<Kunde> GetAllKunden()
        {
            return context.Kunden.Local;
        }

        public Kunde GetKundeById(int id)
        {
            return context.Kunden.Find(id);
        }

        public Kunde InsertKunde(Kunde kunde)
        {
            return context.Kunden.Add(kunde);
        }

        public Kunde UpdateKunde(Kunde modified, Kunde original)
        {
            context.Kunden.Attach(original);
            try
            {
                context.Entry(original).CurrentValues.SetValues(modified);
            }
            catch (DbUpdateConcurrencyException)
            {
                HandleDbConcurrencyException<Kunde>(context, original);
            }
            return modified;

        }

        public Kunde DeleteKunde(Kunde kunde)
        {
            context.Kunden.Attach(kunde);
            return context.Kunden.Remove(kunde);
        }



        public Collection<Reservation> GetAllReservationen()
        {
            return context.Reservationen.Local;
        }

        public Reservation GetReservationById(int id)
        {
            return context.Reservationen.Find(id);
        }

        public Reservation InsertReservation(Reservation reservation)
        {
            return context.Reservationen.Add(reservation);
        }

        public Reservation UpdateReservation(Reservation modified, Reservation original)
        {
            context.Reservationen.Attach(original);
            try
            {
                context.Entry(original).CurrentValues.SetValues(modified);
            }
            catch (DbUpdateConcurrencyException)
            {
                HandleDbConcurrencyException<Reservation>(context, original);
            }
            return modified;

        }

        public Reservation DeleteReservation(Reservation reservation)
        {
            context.Reservationen.Attach(reservation);
            return context.Reservationen.Remove(reservation);
        }

        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }


    }
}