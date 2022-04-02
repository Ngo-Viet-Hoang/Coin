using Coin.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Coin.Data
{
    public class MyDBContext:DbContext
    {
        public MyDBContext() : base("ConnectionString")
        { }
        public DbSet<CoinMarket> CoinMarkets { get; set; }
        public DbSet<CoinList> CoinLists { get; set; }

    }
}