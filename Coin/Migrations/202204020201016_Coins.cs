namespace Coin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coins : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CoinLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BaseAsset = c.Double(nullable: false),
                        QouteAsset = c.Double(nullable: false),
                        LastPrice = c.Double(nullable: false),
                        Volumn24h = c.Double(nullable: false),
                        MarketId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CoinMarkets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CoinMarkets");
            DropTable("dbo.CoinLists");
        }
    }
}
