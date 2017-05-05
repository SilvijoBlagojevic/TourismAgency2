namespace TourismAgency2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOfferModelAnnotation5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "OfferName", c => c.String(nullable: false));
            AlterColumn("dbo.Offers", "Destination", c => c.String(nullable: false));
            AlterColumn("dbo.Offers", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "Description", c => c.String());
            AlterColumn("dbo.Offers", "Destination", c => c.String());
            AlterColumn("dbo.Offers", "OfferName", c => c.String());
        }
    }
}
