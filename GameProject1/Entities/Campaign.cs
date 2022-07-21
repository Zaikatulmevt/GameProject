using GameProject1.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Entities
{
    public class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }

    }
}
