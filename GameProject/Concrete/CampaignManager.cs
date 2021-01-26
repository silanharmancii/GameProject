using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : CampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "deleted.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " " + "updated.");
        }
    }
}
