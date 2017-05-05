namespace TourismAgency2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingOfferModelAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "OfferName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "OfferName", c => c.String());
        }
    }
}
