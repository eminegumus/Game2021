using System;
using System.Collections.Generic;
using System.Text;
using Game2021.Abstract;
using Game2021.Entities;

namespace Game2021.Concrete
{
    public class CampaignManager:IBaseService<Campaign>
    {
        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is Added");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is Updated.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " is Deleted.");
        }
    }
}
