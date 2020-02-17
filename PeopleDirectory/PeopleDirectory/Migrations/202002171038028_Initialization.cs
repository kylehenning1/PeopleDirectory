namespace PeopleDirectory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        ProfilePic = c.String(),
                        MobileNumber = c.String(),
                        Gender = c.String(),
                        Email = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Client");
        }
    }
}
