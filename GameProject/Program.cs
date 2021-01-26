using System;
using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
     class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player();
            player1.Id = 1;
            player1.FirstName = "Melek";
            player1.LastName = "Olcay";
            player1.NationalityId = "12345678910";
            player1.DateOfBirth = new DateTime(1998, 08, 01);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Black Friday";
            campaign1.CampaignDiscount = 60.00;

            Game game1 = new Game();
            game1.GameId = 1;
            game1.GameName = "Okey";
            game1.GamePrice = 80;

            IPlayerService playerService = new PlayerManager(new PlayerCheckManager());
            playerService.Save(player1);
            playerService.Update(player1);
            playerService.Delete(player1);

            Console.WriteLine("**************************");

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(campaign1);
            campaignService.Update(campaign1);
            campaignService.Delete(campaign1);

            Console.WriteLine("***************************");

            IGameService gameService = new GameManager();
            gameService.SaleGame(game1, player1, campaign1);

            Console.ReadLine();
        }
    }
}
