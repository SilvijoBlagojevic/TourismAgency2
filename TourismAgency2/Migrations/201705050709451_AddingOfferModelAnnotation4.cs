namespace TourismAgency2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOfferModelAnnotation4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "OfferName", c => c.String());
            AlterColumn("dbo.Offers", "Destination", c => c.String());
            AlterColumn("dbo.Offers", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Offers", "Destination", c => c.String(nullable: false));
            AlterColumn("dbo.Offers", "OfferName", c => c.String(nullable: false));
        }
    }
}
