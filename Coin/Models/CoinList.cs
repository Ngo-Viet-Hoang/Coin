using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class CoinList
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double BaseAsset { get; set; }
        [Required]
        public double QouteAsset { get; set; }
        [Required]
        public double LastPrice { get; set; }
        [Required]
        public double Volumn24h { get; set; }
        public int MarketId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public CoinStatus Status { get; set; }
    }
}