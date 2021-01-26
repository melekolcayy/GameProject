using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void SaleGame(Game game, Player player, Campaign campaign)
        {
            Console.WriteLine("The Sold Game is : " + "\nGame Id No : " + game.GameId + "\nGame Name : " + game.GameName +
                "\nGame Price : " + game.GamePrice +
                "\n************************************" +
                "\nGame sold to : " + "\nId No : " + player.Id + "\nFirstname : " + player.FirstName +
                "\nLastname : " + player.LastName + "\nIdentity No : " + player.NationalityId +
                "\nDate Of Birth : " + player.DateOfBirth +
                "\n************************************" +
                "\nApproved Campaign is : " + "\nCampaign Id No : " + campaign.CampaignId +
                "\nCampaign Name : " + campaign.CampaignName +
                "\nCampaign Discount : " + campaign.CampaignDiscount);
        }
    }
}
