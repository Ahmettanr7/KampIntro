using System;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Doğrulama (Validation) Denemesi
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "AHMET",
                LastName = "TANRIKULU",
                IdentityNumber = 12345678910
            });

            //Kampanya Ekleme 
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                CampaignId = 1,
                CampaignCategorryId = 3,
                CampaignName = "İlk Alışverişe %25 İndirim"
            });
            Console.WriteLine("--------------------");

            Game game = new Game
            {
                GameId = 1,
                GameCategorry = 2,
                GameName = "CS Go",
                GamePrice = 25

            };

            Gamer gamer = new Gamer
            {
                Id = 1,
                BirthYear = 1998,
                FirstName = "AHMET",
                LastName = "TANRIKULU",
                IdentityNumber = 12345678910
            };

            Campaign campaign = new Campaign
            {
                CampaignId = 1,
                CampaignCategorryId = 3,
                CampaignName = "İlk Alışverişe %25 İndirim",
                CampaignGo = game.GamePrice-(game.GamePrice * 0.25)
            };

            SalesManager salesManager = new SalesManager();
            salesManager.Add(gamer, game, campaign);
        }
    }
}
