namespace MVC40_Code_First_Attribute_Based.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(),
                        Specialization = c.String(),
                    })
                .PrimaryKey(t => t.DoctorId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        PatientName = c.String(),
                        Gendar = c.String(),
                        Age = c.Int(nullable: false),
                        DoctorId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId)
                .Index(t => t.DoctorId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Patients", new[] { "DoctorId" });
            DropForeignKey("dbo.Patients", "DoctorId", "dbo.Doctors");
            DropTable("dbo.Patients");
            DropTable("dbo.Doctors");
        }
    }
}
