namespace TourismAgency2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingSeasonInOffer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Offers", "Seasons", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Offers", "Seasons");
        }
    }
}
