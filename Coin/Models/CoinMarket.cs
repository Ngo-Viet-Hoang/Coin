using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public enum CoinStatus
    {
        Active = 1,
        Deactive = 0,
    }
    public class CoinMarket
    {
      
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public CoinStatus Status { get; set; }

    }
}