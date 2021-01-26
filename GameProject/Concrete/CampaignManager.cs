using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Abstract;


namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is added : " + "\nCampaign Id No : " + campaign.CampaignId +
                "\nCampaign Name : " + campaign.CampaignName + "\nCampaign Discount : " + campaign.CampaignDiscount);
            Console.WriteLine("********************************");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated : " + "\nCampaign Id No : " + campaign.CampaignId +
                "\nCampaign Name : " + campaign.CampaignName + "\nCampaign Discount : " + campaign.CampaignDiscount);
            Console.WriteLine("********************************");
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted : " + "\nCampaign Id No : " + campaign.CampaignId +
                "\nCampaign Name : " + campaign.CampaignName + "\nCampaign Discount : " + campaign.CampaignDiscount);
            Console.WriteLine("********************************");
        }
    }
}
