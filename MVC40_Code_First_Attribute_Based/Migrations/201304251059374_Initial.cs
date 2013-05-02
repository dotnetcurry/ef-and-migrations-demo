namespace MVC40_Code_First_Attribute_Based.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "Address");
        }
    }
}
