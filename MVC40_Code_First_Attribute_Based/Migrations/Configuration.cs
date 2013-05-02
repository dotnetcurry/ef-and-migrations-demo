namespace MVC40_Code_First_Attribute_Based.Migrations
{
    using MVC40_Code_First_Attribute_Based.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC40_Code_First_Attribute_Based.Models.HMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVC40_Code_First_Attribute_Based.Models.HMSContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Patients.AddOrUpdate(p => p.PatientId,
             new Patient()
             {
                   PatientName = "Pat_1",
                    Gendar="Male",
                     Age=30,
                     Address="Pune",
                     DoctorId=1
             });


            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
