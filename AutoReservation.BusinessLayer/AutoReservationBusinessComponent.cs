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

        public Collection<Autos> GetAllAutos()
        {
            return context.Autos.Local;
        }

        public Autos GetAutoById(int id)
        {
            return context.Autos.Find(id);
        }

        public Autos InsertAuto(Autos auto)
        {
            return context.Autos.Add(auto);
        }

        public Autos UpdateAuto(Autos modified, Autos original)
        {
            context.Autos.Attach(original);
            try
            {
                context.Entry(original).CurrentValues.SetValues(modified);
            }
            catch (DbUpdateConcurrencyException)
            {
                HandleDbConcurrencyException<Autos>(context, original);
            }
            return modified;
              
        }

        public Autos DeleteAuto(Autos auto)
        {
            context.Autos.Attach(auto);
            return context.Autos.Remove(auto);
        }



        private static void HandleDbConcurrencyException<T>(AutoReservationEntities context, T original) where T : class
        {
            var databaseValue = context.Entry(original).GetDatabaseValues();
            context.Entry(original).CurrentValues.SetValues(databaseValue);

            throw new LocalOptimisticConcurrencyException<T>(string.Format("Update {0}: Concurrency-Fehler", typeof(T).Name), original);
        }


    }
}