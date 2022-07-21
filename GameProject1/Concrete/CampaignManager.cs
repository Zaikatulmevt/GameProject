using GameProject1.Abstracts;
using GameProject1.Entities;
using System;
using System.Collections.Generic;

namespace GameProject1.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private List<Campaign> campaigns = new List<Campaign> { }; 
        public CampaignManager()
        {

        }

        public void Add(Campaign campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi" );
        }

        public void Delete(Campaign campaign)
        {
            campaigns.RemoveAll(c => c.Id == campaign.Id );
            Console.WriteLine(campaign.CampaignName + "kampanyası silindi");
        }

        public void Update(Campaign campaign)
        {
            var index = campaigns.FindIndex(c => c.Id == campaign.Id);
            campaigns[index] = campaign;

            Console.WriteLine(campaign.CampaignName + "kampanyası güncellendi");
        }

    }
}
