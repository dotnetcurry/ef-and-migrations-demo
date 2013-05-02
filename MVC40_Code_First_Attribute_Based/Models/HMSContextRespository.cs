using System.Data.Entity;

namespace MVC40_Code_First_Attribute_Based.Models
{
    /// <summary>
    /// The DbContext instance is a combination of the unit of work and repository pattern. 
    /// This enables the capability to query the database and also write changes made back to the store.
    /// These changes are typically the Create, Update and Delete operation. 
    /// </summary>
    public class HMSContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public HMSContext():base("name=HMSConnectionString")
        {

        }
    }
}