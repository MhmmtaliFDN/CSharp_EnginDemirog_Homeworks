using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Homework2
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya sisteme eklendi: " + " " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya sistemde güncellendi: " + " " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya sistemden silindi: " + " " + campaign.CampaignName);
        }
    }
}
