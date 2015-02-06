namespace CommunityMedicine.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doses",
                c => new
                    {
                        DoseId = c.Int(nullable: false, identity: true),
                        DoseName = c.String(),
                    })
                .PrimaryKey(t => t.DoseId);
            
            CreateTable(
                "dbo.Treatments",
                c => new
                    {
                        TreatmentId = c.Int(nullable: false, identity: true),
                        PatientVoterId = c.String(),
                        Observation = c.String(),
                        Date = c.DateTime(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        DeseaseId = c.Int(nullable: false),
                        DoseId = c.Int(nullable: false),
                        MealType = c.Int(nullable: false),
                        Quantity = c.Double(nullable: false),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.TreatmentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Treatments");
            DropTable("dbo.Doses");
        }
    }
}
