namespace intellectustraining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Gender = c.String(nullable: false),
                        CnhClass = c.String(),
                        BirthDate = c.String(nullable: false),
                        Dependentes = c.String(),
                        Maritalstatu = c.String(nullable: false),
                        CellPhone = c.String(),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidates");
        }
    }
}
