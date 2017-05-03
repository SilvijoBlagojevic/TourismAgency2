namespace TourismAgency2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateOffersWithData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT [dbo].[Offers] ON");
            Sql("INSERT INTO [dbo].[Offers] ([OfferId], [OfferName], [Destination], [Description], [Price], [Customer_CustomerId]) VALUES (1, N'Summer Holiday In India', N'KASHMIR', N'The original \"Paradise on Earth\" is a summer delight – cool locales, romantic Shikara on the picturesque Dal, blooming Shalimar Gardens are all views to cherish.', 99, NULL)");
            Sql("INSERT INTO [dbo].[Offers] ([OfferId], [OfferName], [Destination], [Description], [Price], [Customer_CustomerId]) VALUES (2, N'Summer Holiday In India', N'UTTARAKHAND', N'From Yoga classes to rafting and wildlife stays to humbling pilgrimages – there''s something for everyone in Uttarakhand. A particular favorite with foreigners.', 89, NULL)");
            Sql("INSERT INTO [dbo].[Offers] ([OfferId], [OfferName], [Destination], [Description], [Price], [Customer_CustomerId]) VALUES (3, N'Summer Holiday In India', N'HIMACHAL PRADESH', N'The Abode of the Himalayas is India''s favorite summer destination and home to 100+ hill stations in India. Pine forests and apple orchards further add to its appeal.', 79, NULL)");
            Sql("INSERT INTO [dbo].[Offers] ([OfferId], [OfferName], [Destination], [Description], [Price], [Customer_CustomerId]) VALUES (4, N'Summer Holiday In India', N'LADAKH', N'The seemingly photoshopped Buddhist ex-kingdom is home to gompas flanked by whitewashed stupas. Ladakh''s cold desert is nature''s boon and bane to the Himalayas.', 99, NULL)");
            Sql("INSERT INTO [dbo].[Offers] ([OfferId], [OfferName], [Destination], [Description], [Price], [Customer_CustomerId]) VALUES (6, N'Summer Holiday In India', N'KERALA', N'\"God''s Own Country\" is a true revelation in summers. If the numerous beaches, backwaters and Ayurveda in Kerala don''t get you, the exotic culture and cuisine will!', 49, NULL)");
            Sql("SET IDENTITY_INSERT [dbo].[Offers] OFF");
        }
        
        public override void Down()
        {
        }
    }
}
