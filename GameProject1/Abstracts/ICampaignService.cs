using GameProject1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject1.Abstracts
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);

        void Delete(Campaign campaign);

        void Update(Campaign campaign);

    

    }
}
