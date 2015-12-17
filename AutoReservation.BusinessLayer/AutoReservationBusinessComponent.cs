using AutoReservation.Dal;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace AutoReservation.BusinessLayer
{
    public class AutoReservationBusinessComponent
    {
        private AutoReservationEntities context;

        public AutoReservationBusinessComponent()
        {
            this.context = new AutoReservationEntities();
        }

        public List<Auto> GetAllAutos()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Autos.ToList();
            }
        }

        public Auto GetAutoById(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Autos.Where(a => a.Id == id).FirstOrDefault();
            }
        }

        public void InsertAuto(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Autos.Add(auto);
                context.SaveChanges();
            }
        }

        public void UpdateAuto(Auto modified, Auto original)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Autos.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException<Auto>(context, original);
                }
            }
              
        }

        public void DeleteAuto(Auto auto)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Autos.Attach(auto);
                context.Autos.Remove(auto);
                context.SaveChanges();
            }
        }



        public List<Kunde> GetAllKunden()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Kunden.ToList();
            }
        }

        public Kunde GetKundeById(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Kunden.Where(a => a.Id == id).FirstOrDefault();
            }
        }

        public void InsertKunde(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunden.Add(kunde);
                context.SaveChanges();
            }
        }

        public void UpdateKunde(Kunde modified, Kunde original)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Kunden.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException<Kunde>(context, original);
                }
            }

        }

        public void DeleteKunde(Kunde kunde)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Kunden.Attach(kunde);
                context.Kunden.Remove(kunde);
                context.SaveChanges();
            }
        }



        public List<Reservation> GetAllReservationen()
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.Include("Auto").Include("Kunde").ToList();
            }
        }

        public Reservation GetReservationById(int id)
        {
            using (var context = new AutoReservationEntities())
            {
                return context.Reservationen.Include("Auto").Include("Kunde").Where(a => a.ReservationNr == id).FirstOrDefault(); ;
            }
        }

        public void InsertReservation(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservationen.Add(reservation);
                context.SaveChanges();
            }
        }

        public void UpdateReservation(Reservation modified, Reservation original)
        {
            using (var context = new AutoReservationEntities())
            {
                try
                {
                    context.Reservationen.Attach(original);
                    context.Entry(original).CurrentValues.SetValues(modified);
                    context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    HandleDbConcurrencyException<Reservation>(context, original);
                }
                
            }

        }

        public void DeleteReservation(Reservation reservation)
        {
            using (var context = new AutoReservationEntities())
            {
                context.Reservationen.Attach(reservation);
                context.Reservationen.Remove(reservation);
                context.SaveChanges();
            }
        }

        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }


    }
}