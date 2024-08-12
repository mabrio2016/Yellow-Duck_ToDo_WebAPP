namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProperty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Done = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Todoes");
        }
    }
}
