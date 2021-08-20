namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableGarrafa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Garrafas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Bebida = c.String(),
                        ML = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Garrafas");
        }
    }
}
